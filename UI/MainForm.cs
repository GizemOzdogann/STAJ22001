using System.Drawing.Text;
using System.Data.SqlClient;
using System.Data;
using ManagerApp;
using ManagerApp.Interfaces;
using ManagerApp.UI;
using ManagerApp.Entities;
using static ManagerApp.UI.productsPage;
using System.Windows.Forms;

namespace FarmManagementApp
{
    public partial class MainForm : Form
    {
        private readonly IAnimalService _animalService;

        private AddAnimalPage _animalPage;

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
            _animalPage = new AddAnimalPage();
            
        }

        public void LoadForm(Form form)
        {
            if (this.MainPanel == null)
            {
                throw new InvalidOperationException("MainPanel is not initialized.");
            }

            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            if (form == null)
            {
                throw new ArgumentNullException(nameof(form), "The form parameter cannot be null.");
            }

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;


            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;

            form.Show();

            //TimerHelper.GetTimer(_productsPage.timer1, timer1_Tick);
        }
        
        private void CustomizeDesign()
        {
            animalsSubPanel.Visible = false;
            productsSubPanel.Visible = false;
        }

        private void HideSubMenu()
        {
            if (animalsSubPanel.Visible) animalsSubPanel.Visible = false;
            if (productsSubPanel.Visible) productsSubPanel.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void AnimalsButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(animalsSubPanel);
        }

        #region AnimalsSubMenu
        private void ListAnimalsButton_Click(object sender, EventArgs e)
        {
            //...
            //LoadForm(new ListAnimals());
            HideSubMenu();
        }

        private void AddAnimalsButton_Click(object sender, EventArgs e)
        {
            //...
            LoadForm(new AddAnimalPage());
            HideSubMenu();
        }

        #endregion AnimalsSubMenu

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(productsSubPanel);
        }

        #region ProductsSubMenu

        private void ShowProductsButton_Click(object sender, EventArgs e)
        {
            //...
            LoadForm(new productsPage());
            HideSubMenu();
        }

        #endregion ProductsSubMenu



        #region SalesSubMenu

        private void CashStatusButton_Click(object sender, EventArgs e)
        {
            //...
            //LoadForm(new cashStatus());
            HideSubMenu();
        }

        private void SellProductsButton_Click(object sender, EventArgs e)
        {
            //...
            HideSubMenu();
        }

        #endregion SalesSubMenu

        private void exitButton_Click(object sender, EventArgs e)
        {
            ConfirmExit();
        }

        private void ConfirmExit()
        {
            DialogResult exit;

            exit = MessageBox.Show("Are you sure you want to exit?", "Exit Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}