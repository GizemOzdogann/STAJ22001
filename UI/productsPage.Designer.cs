namespace ManagerApp.UI
{
    partial class productsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView2 = new DataGridView();
            productName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Sell = new DataGridViewButtonColumn();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            splitter1 = new Splitter();
            panel2 = new Panel();
            labelCashStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowDrop = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { productName, Price, Quantity, Sell });
            dataGridView2.GridColor = Color.RoyalBlue;
            dataGridView2.Location = new Point(27, 5);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView2.Size = new Size(634, 143);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // productName
            // 
            productName.FillWeight = 130F;
            productName.HeaderText = "Name";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            productName.ReadOnly = true;
            productName.Resizable = DataGridViewTriState.False;
            // 
            // Price
            // 
            Price.FillWeight = 130F;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.FillWeight = 130F;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Sell
            // 
            Sell.FillWeight = 130F;
            Sell.HeaderText = "";
            Sell.MinimumWidth = 6;
            Sell.Name = "Sell";
            Sell.ReadOnly = true;
            Sell.Text = "Sell";
            Sell.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 33);
            panel1.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 33);
            splitter1.Margin = new Padding(3, 2, 3, 2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 305);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelCashStatus);
            panel2.Controls.Add(dataGridView2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(4, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 305);
            panel2.TabIndex = 3;
            // 
            // labelCashStatus
            // 
            labelCashStatus.AutoSize = true;
            labelCashStatus.Location = new Point(27, 163);
            labelCashStatus.Name = "labelCashStatus";
            labelCashStatus.Size = new Size(0, 15);
            labelCashStatus.TabIndex = 1;
            // 
            // productsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel2);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "productsPage";
            Load += productsPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private Panel panel1;
        public System.Windows.Forms.Timer timer1;
        private Splitter splitter1;
        private Panel panel2;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewButtonColumn Sell;
        private Label labelCashStatus;
    }
}