
namespace FarmManagementApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Panel();
            productsSubPanel = new Panel();
            ShowProductsButton = new Button();
            ProductsButton = new Button();
            animalsSubPanel = new Panel();
            AddAnimalsButton = new Button();
            exitButton = new Button();
            AnimalsButton = new Button();
            logoPanel = new Panel();
            logoLabel = new Label();
            MainPanel = new Panel();
            splitter1 = new Splitter();
            sidePanel.SuspendLayout();
            productsSubPanel.SuspendLayout();
            animalsSubPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.RoyalBlue;
            sidePanel.Controls.Add(productsSubPanel);
            sidePanel.Controls.Add(ProductsButton);
            sidePanel.Controls.Add(animalsSubPanel);
            sidePanel.Controls.Add(exitButton);
            sidePanel.Controls.Add(AnimalsButton);
            sidePanel.Controls.Add(logoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = SystemColors.Window;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(4, 3, 4, 3);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(134, 463);
            sidePanel.TabIndex = 0;
            // 
            // productsSubPanel
            // 
            productsSubPanel.Controls.Add(ShowProductsButton);
            productsSubPanel.Dock = DockStyle.Top;
            productsSubPanel.Location = new Point(0, 191);
            productsSubPanel.Margin = new Padding(4, 3, 4, 3);
            productsSubPanel.Name = "productsSubPanel";
            productsSubPanel.Size = new Size(134, 48);
            productsSubPanel.TabIndex = 8;
            // 
            // ShowProductsButton
            // 
            ShowProductsButton.Dock = DockStyle.Top;
            ShowProductsButton.FlatAppearance.BorderSize = 0;
            ShowProductsButton.FlatStyle = FlatStyle.Flat;
            ShowProductsButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ShowProductsButton.ForeColor = SystemColors.Window;
            ShowProductsButton.ImageAlign = ContentAlignment.MiddleRight;
            ShowProductsButton.Location = new Point(0, 0);
            ShowProductsButton.Margin = new Padding(4, 3, 4, 3);
            ShowProductsButton.Name = "ShowProductsButton";
            ShowProductsButton.Padding = new Padding(32, 0, 0, 0);
            ShowProductsButton.Size = new Size(134, 48);
            ShowProductsButton.TabIndex = 5;
            ShowProductsButton.Text = "Show";
            ShowProductsButton.UseVisualStyleBackColor = true;
            ShowProductsButton.Click += ShowProductsButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Dock = DockStyle.Top;
            ProductsButton.FlatAppearance.BorderSize = 0;
            ProductsButton.FlatStyle = FlatStyle.Flat;
            ProductsButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ProductsButton.ForeColor = SystemColors.Window;
            ProductsButton.Location = new Point(0, 143);
            ProductsButton.Margin = new Padding(4, 3, 4, 3);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Padding = new Padding(12, 0, 0, 0);
            ProductsButton.Size = new Size(134, 48);
            ProductsButton.TabIndex = 7;
            ProductsButton.Text = "Products";
            ProductsButton.TextAlign = ContentAlignment.MiddleLeft;
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // animalsSubPanel
            // 
            animalsSubPanel.Controls.Add(AddAnimalsButton);
            animalsSubPanel.Dock = DockStyle.Top;
            animalsSubPanel.Location = new Point(0, 91);
            animalsSubPanel.Margin = new Padding(4, 3, 4, 3);
            animalsSubPanel.Name = "animalsSubPanel";
            animalsSubPanel.Size = new Size(134, 52);
            animalsSubPanel.TabIndex = 6;
            // 
            // AddAnimalsButton
            // 
            AddAnimalsButton.Dock = DockStyle.Top;
            AddAnimalsButton.FlatAppearance.BorderSize = 0;
            AddAnimalsButton.FlatStyle = FlatStyle.Flat;
            AddAnimalsButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AddAnimalsButton.ForeColor = SystemColors.Window;
            AddAnimalsButton.ImageAlign = ContentAlignment.MiddleRight;
            AddAnimalsButton.Location = new Point(0, 0);
            AddAnimalsButton.Margin = new Padding(4, 3, 4, 3);
            AddAnimalsButton.Name = "AddAnimalsButton";
            AddAnimalsButton.Padding = new Padding(32, 0, 0, 0);
            AddAnimalsButton.Size = new Size(134, 50);
            AddAnimalsButton.TabIndex = 6;
            AddAnimalsButton.Text = "New";
            AddAnimalsButton.UseVisualStyleBackColor = true;
            AddAnimalsButton.Click += AddAnimalsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Bottom;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            exitButton.Location = new Point(0, 423);
            exitButton.Margin = new Padding(4, 3, 4, 3);
            exitButton.Name = "exitButton";
            exitButton.Padding = new Padding(12, 0, 0, 0);
            exitButton.Size = new Size(134, 40);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // AnimalsButton
            // 
            AnimalsButton.BackColor = Color.RoyalBlue;
            AnimalsButton.Dock = DockStyle.Top;
            AnimalsButton.FlatAppearance.BorderSize = 0;
            AnimalsButton.FlatStyle = FlatStyle.Flat;
            AnimalsButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AnimalsButton.ForeColor = SystemColors.Window;
            AnimalsButton.Location = new Point(0, 43);
            AnimalsButton.Margin = new Padding(4, 3, 4, 3);
            AnimalsButton.Name = "AnimalsButton";
            AnimalsButton.Padding = new Padding(12, 0, 0, 0);
            AnimalsButton.Size = new Size(134, 48);
            AnimalsButton.TabIndex = 1;
            AnimalsButton.Text = "Animals";
            AnimalsButton.TextAlign = ContentAlignment.MiddleLeft;
            AnimalsButton.UseVisualStyleBackColor = false;
            AnimalsButton.Click += AnimalsButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(logoLabel);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Margin = new Padding(4, 3, 4, 3);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(134, 43);
            logoPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            logoLabel.Location = new Point(13, 9);
            logoLabel.Margin = new Padding(4, 0, 4, 0);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(117, 20);
            logoLabel.TabIndex = 0;
            logoLabel.Text = "Farm Manager";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(splitter1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainPanel.ForeColor = SystemColors.ControlText;
            MainPanel.Location = new Point(134, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(758, 463);
            MainPanel.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 463);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 463);
            Controls.Add(MainPanel);
            Controls.Add(sidePanel);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Window;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farm Manager";
            sidePanel.ResumeLayout(false);
            productsSubPanel.ResumeLayout(false);
            animalsSubPanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel logoPanel;
        private Button AnimalsButton;
        private Button exitButton;
        private Panel animalsSubPanel;
        private Button AddAnimalsButton;
        private Panel productsSubPanel;
        private Button ShowProductsButton;
        private Button ProductsButton;
        private Label logoLabel;
        private Panel MainPanel;
        private Splitter splitter1;
    }
}
