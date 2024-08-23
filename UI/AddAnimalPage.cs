using ManagerApp.Factories;
using ManagerApp.Interfaces;
using ManagerApp.Entities;
using ManagerApp.Stores;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Newtonsoft.Json;
using static ManagerApp.UI.productsPage;
using ManagerApp.UI;

namespace ManagerApp
{
    public partial class AddAnimalPage : Form
    {
        private static int _nextId = 1;
        private productsPage _productsPage;
        public AddAnimalPage()
        {
            InitializeComponent();
            InitializeAnimalType();
            InitializeGender();
            //InitializeAgeBox();
            InitializeDataGridView();
            BindDataToGrid();
            InitializeCashStatus();
            _productsPage = new productsPage();
            TimerHelper.GetTimer(_productsPage.timer1, timer1_Tick);
        }

        private void InitializeAnimalType()
        {
            AnimalType.Items.Add(nameof(Cow));
            AnimalType.Items.Add(nameof(Chicken));
            AnimalType.Items.Add(nameof(Sheep));
        }

        private void InitializeGender()
        {
            ChooseGender.Items.Add((Gender.Female));
            ChooseGender.Items.Add(Gender.Male);
        }

        private void InitializeCashStatus()
        {
            labelCashStatus.Text = $"Cash Status: ${GlobalCashStatus.cashStatus:F2}";
        }
        private void InitializeAgeBox(string animalType)
        {
            AgePick.MaxDropDownItems = 10;

            animalType = AnimalType.SelectedItem?.ToString();

            AgePick.Items.Clear();

            if (animalType != null && maxAgeD.TryGetValue(animalType, out int maxAgeValue))
            {
                for (int i = 1; i <= maxAgeValue; i++)
                {
                    AgePick.Items.Add(i);
                }
            }
        }

        private void AnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAnimalType = AnimalType.SelectedItem?.ToString();

            InitializeAgeBox(selectedAnimalType);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string? animalType = AnimalType.SelectedItem?.ToString();
            string? gender = ChooseGender.SelectedItem?.ToString();
            int? age = AgePick.SelectedItem as int?;
           
            if (!string.IsNullOrEmpty(animalType) && !string.IsNullOrEmpty(gender) && age.HasValue)
            {
                datagridview1.ClearSelection();

                AnimalFactory factory = AnimalFactory.GetFactory(animalType);
                Animal animal = factory.CreateAnimal();
                animal.Id = _nextId++;
                animal.Gender = gender;
                animal.Age = age.Value;
                
                int rowIndex = datagridview1.Rows.Add(animal.Id, animalType, gender.ToString(), age.Value);
                
                int lifeValue = Convert.ToInt32(datagridview1.Rows[rowIndex].Cells["Lifespan"].Value);

                switch (animalType)
                {
                    case "Cow":
                        lifeValue = 100 - (int)age *4;
                        break;
                    case "Chicken":
                        lifeValue = 100 - (int)age * 10;
                        break;
                    case "Sheep":
                        lifeValue = 100 - (int)age * 5;
                        break;
                }

                datagridview1.Rows[rowIndex].Cells["Lifespan"].Value = lifeValue;
                Store.Instance.AnimalList.Add(animal);
            }
            else
            {
                MessageBox.Show("Please select animal type, gender, and age.");
            }

            
            ClearComboBoxes();
        }

        public void InitializeDataGridView()
        {
            datagridview1.ColumnCount = 4;
            datagridview1.Columns[0].Name = "Id";
            datagridview1.Columns[0].Visible = false;
            datagridview1.Columns[1].Name = "Type";
            datagridview1.Columns[2].Name = "Gender";
            datagridview1.Columns[3].Name = "Age";

            datagridview1.Columns[1].Width = 90;
            datagridview1.Columns[2].Width = 90;
            datagridview1.Columns[3].Width = 40;

            datagridview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = " ";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            datagridview1.Columns.Add(deleteButtonColumn);

            deleteButtonColumn.DefaultCellStyle.BackColor = Color.FromArgb(209, 233, 246);
            deleteButtonColumn.DefaultCellStyle.ForeColor = Color.Black;

            DataGridViewProgressColumn column = new() { HeaderText = "Lifespan", Name = "Lifespan" };
            datagridview1.Columns.Add(column);

            datagridview1.CellClick += dataGridView1_CellClick;
            datagridview1.CellFormatting += dataGridView1_CellFormatting;

            datagridview1.ClearSelection();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == datagridview1.Columns["Delete"].Index)
            {
                var result = MessageBox.Show("Are you sure you want to delete this?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int animalId = Convert.ToInt32(datagridview1.Rows[e.RowIndex].Cells["Id"].Value);

                        var animal = Store.Instance.AnimalList.FirstOrDefault(a => a.Id == animalId);
                        if (animal != null)
                        {
                            Store.Instance.RemoveAnimal(animal);
                        }

                        datagridview1.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the animal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (datagridview1.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.SelectionBackColor = datagridview1.DefaultCellStyle.BackColor;
                e.CellStyle.SelectionForeColor = datagridview1.DefaultCellStyle.ForeColor;
            }
        }
        private void BindDataToGrid()
        {
            datagridview1.Rows.Clear();
            foreach (var animal in Store.Instance.AnimalList)
            {
                datagridview1.Rows.Add(animal.Id, animal.GetType().Name, animal.Gender, animal.Age);
            }
        }

        private void ClearComboBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
        }

        private readonly Dictionary<string, int> maxAgeD = new Dictionary<string, int>
        {
            { "Cow", 25 },
            { "Chicken", 10 },
            { "Sheep", 20 }
        };

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = datagridview1.Rows.Count - 1; i >= 0; i--)
            {
                int iterator = 0;

                var animalType = datagridview1.Rows[i].Cells["Type"].Value.ToString();

                int currentValue = Convert.ToInt32(datagridview1.Rows[i].Cells["Lifespan"].Value);
                int ageValue = Convert.ToInt32(datagridview1.Rows[i].Cells["Age"].Value);

                int maxAge = maxAgeD.ContainsKey(animalType) ? maxAgeD[animalType] : 0;

                switch (animalType)
                {
                    case "Cow":
                        iterator = 4;
                        break;
                    case "Chicken":
                        iterator = 20;
                        break;
                    case "Sheep":
                        iterator = 10;
                        break;
                }

                if (currentValue > 0 && ageValue <= maxAge)
                {
                    currentValue -= iterator;

                    if (currentValue < 0)
                    {
                        currentValue = 0;
                    }

                    datagridview1.Rows[i].Cells["Lifespan"].Value = currentValue;
                    datagridview1.Rows[i].Cells["Age"].Value = ++ageValue;
                }

                if (currentValue <= 0 || ageValue >= maxAge)
                {
                    datagridview1.Rows.RemoveAt(i);
                }
            }
        }

    }
}