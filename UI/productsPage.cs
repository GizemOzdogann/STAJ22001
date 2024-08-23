using ManagerApp.Entities;
using ManagerApp.Factories;
using ManagerApp.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ManagerApp.UI
{
    public partial class productsPage : Form
    {
        private static int _nextId = 1;
        public productsPage()
        {
            InitializeComponent();
        }


        public static class GlobalCashStatus
        {
            public static decimal cashStatus { get; set; } = 0;

            public static void UpdateCashStatus(decimal amount)
            {
                cashStatus += amount;
            }
        }

        private void productsPage_Load(object sender, EventArgs e)
        {
            DataGridViewProgressColumn column = new() { HeaderText = "Production", Name = "Production" };
            dataGridView2.Columns.Add(column);

            dataGridView2.Rows.Add("Meat", 50);
            dataGridView2.Rows.Add("Milk", 20);
            dataGridView2.Rows.Add("Egg", 10);

            TimerHelper.GetTimer(timer1, timer1_Tick);

            DataGridViewButtonColumn deleteButtonColumn = (DataGridViewButtonColumn)dataGridView2.Columns["Delete"];
            
            labelCashStatus.Text = $"Cash Status: ${GlobalCashStatus.cashStatus:F2}";
        }

        public static class TimerHelper
        {
            public static void GetTimer(Timer timer1,EventHandler tickEvent)
            {
                timer1.Interval = 1000;
                timer1.Tick += tickEvent;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                int iterator = 0;
                int currentValue = Convert.ToInt32(dataGridView2.Rows[i].Cells["Production"].Value);
                int quantity = Convert.ToInt32(dataGridView2.Rows[i].Cells["Quantity"].Value);

                switch (i)
                {
                    case 0: // meat
                        iterator = 5; break;
                    case 1: // milk
                        iterator = 10; break;
                    case 2: // egg
                        iterator = 20; break;
                }

                if (currentValue < 100)
                {
                    currentValue += iterator;
                    dataGridView2.Rows[i].Cells["Production"].Value = currentValue;

                }
                else if (currentValue == 100)
                {
                    currentValue = 0;
                    dataGridView2.Rows[i].Cells["Production"].Value = currentValue;
                    quantity++;
                    dataGridView2.Rows[i].Cells["Quantity"].Value = quantity;

                    var product = dataGridView2.Rows[i].Cells["productName"].Value;
                    Product _product = ProductFactory.Produce((string)product);

                    Store.Instance.ProductList.Add(_product);
                    

                    //int productId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Id"].Value);

                    //int productId = Convert.ToInt32(dataGridView2.Rows[i].Cells["Id"].Value);
                    //var product = Store.Instance.AnimalList.FirstOrDefault(a => a.Id == productId);

                    //if (product != null)
                    //{
                    // Add to ProductList
                    //Store.Instance.ProductList.Add(product);
                    //}
                    //var product = Store.Instance.AnimalList.FirstOrDefault((a => a.Id == productId));

                    //timer1.Stop();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Sell"].Index && e.RowIndex >= 0)            
            {
                int cellValue = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Quantity"].Value);

                if (cellValue > 0)
                {
                    var result = MessageBox.Show($"Are you sure you want to sell this animal?", "Confirm Sale", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cellValue--;
                        dataGridView2.Rows[e.RowIndex].Cells["Quantity"].Value = cellValue;

                        decimal price = Convert.ToDecimal(dataGridView2.Rows[e.RowIndex].Cells["Price"].Value);

                        GlobalCashStatus.UpdateCashStatus(price);
                        UpdateCashStatusDisplay();
                    }
                }
                else
                {
                    MessageBox.Show("There is no product to be sold", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void UpdateCashStatusDisplay()
        {
            labelCashStatus.Text = $"Cash Status: ${GlobalCashStatus.  cashStatus:F2}";
        }

    }
}
