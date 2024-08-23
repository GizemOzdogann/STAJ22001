namespace ManagerApp
{
    partial class AddAnimalPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            AnimalTypeLabel = new Label();
            ChooseGender = new ComboBox();
            GenderLabel = new Label();
            AgePick = new ComboBox();
            AgePickLabel = new Label();
            AddButton = new Button();
            datagridview1 = new DataGridView();
            panel1 = new Panel();
            AnimalType = new ComboBox();
            labelCashStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridview1).BeginInit();
            SuspendLayout();
            // 
            // AnimalTypeLabel
            // 
            AnimalTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AnimalTypeLabel.AutoSize = true;
            AnimalTypeLabel.Location = new Point(56, 90);
            AnimalTypeLabel.Name = "AnimalTypeLabel";
            AnimalTypeLabel.Size = new Size(140, 20);
            AnimalTypeLabel.TabIndex = 1;
            AnimalTypeLabel.Text = "Choose animal type";
            // 
            // ChooseGender
            // 
            ChooseGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ChooseGender.DropDownStyle = ComboBoxStyle.DropDownList;
            ChooseGender.FormattingEnabled = true;
            ChooseGender.Location = new Point(54, 194);
            ChooseGender.Name = "ChooseGender";
            ChooseGender.Size = new Size(151, 28);
            ChooseGender.TabIndex = 2;
            // 
            // GenderLabel
            // 
            GenderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(54, 165);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(109, 20);
            GenderLabel.TabIndex = 3;
            GenderLabel.Text = "Choose gender";
            // 
            // AgePick
            // 
            AgePick.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AgePick.DropDownStyle = ComboBoxStyle.DropDownList;
            AgePick.FormattingEnabled = true;
            AgePick.Location = new Point(54, 266);
            AgePick.Name = "AgePick";
            AgePick.Size = new Size(151, 28);
            AgePick.TabIndex = 4;
            // 
            // AgePickLabel
            // 
            AgePickLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AgePickLabel.AutoSize = true;
            AgePickLabel.Location = new Point(54, 237);
            AgePickLabel.Name = "AgePickLabel";
            AgePickLabel.Size = new Size(87, 20);
            AgePickLabel.TabIndex = 5;
            AgePickLabel.Text = "Choose age";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.AutoSize = true;
            AddButton.Location = new Point(56, 322);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(85, 30);
            AddButton.TabIndex = 6;
            AddButton.Text = "Save";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // datagridview1
            // 
            datagridview1.AllowUserToAddRows = false;
            datagridview1.AllowUserToDeleteRows = false;
            datagridview1.AllowUserToResizeColumns = false;
            datagridview1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            datagridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridview1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            datagridview1.BackgroundColor = SystemColors.Control;
            datagridview1.BorderStyle = BorderStyle.None;
            datagridview1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            datagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagridview1.DefaultCellStyle = dataGridViewCellStyle3;
            datagridview1.GridColor = SystemColors.HotTrack;
            datagridview1.Location = new Point(264, 79);
            datagridview1.MultiSelect = false;
            datagridview1.Name = "datagridview1";
            datagridview1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            datagridview1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            datagridview1.RowHeadersVisible = false;
            datagridview1.RowHeadersWidth = 45;
            datagridview1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            datagridview1.Size = new Size(466, 310);
            datagridview1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 44);
            panel1.TabIndex = 9;
            // 
            // AnimalType
            // 
            AnimalType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AnimalType.DropDownStyle = ComboBoxStyle.DropDownList;
            AnimalType.FormattingEnabled = true;
            AnimalType.Location = new Point(54, 125);
            AnimalType.Name = "AnimalType";
            AnimalType.Size = new Size(151, 28);
            AnimalType.TabIndex = 10;
            AnimalType.SelectedIndexChanged += AnimalType_SelectedIndexChanged;
            // 
            // labelCashStatus
            // 
            labelCashStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelCashStatus.AutoSize = true;
            labelCashStatus.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCashStatus.Location = new Point(56, 380);
            labelCashStatus.Name = "labelCashStatus";
            labelCashStatus.Size = new Size(0, 20);
            labelCashStatus.TabIndex = 11;
            // 
            // AddAnimalPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCashStatus);
            Controls.Add(AnimalType);
            Controls.Add(panel1);
            Controls.Add(datagridview1);
            Controls.Add(AddButton);
            Controls.Add(AgePickLabel);
            Controls.Add(AgePick);
            Controls.Add(GenderLabel);
            Controls.Add(ChooseGender);
            Controls.Add(AnimalTypeLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAnimalPage";
            Text = "Add Animal";
            ((System.ComponentModel.ISupportInitialize)datagridview1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AnimalTypeLabel;
        private ComboBox ChooseGender;
        private Label GenderLabel;
        private ComboBox AgePick;
        private Label AgePickLabel;
        private Button AddButton;
        public DataGridView datagridview1;
        private Panel panel1;
        private ComboBox AnimalType;
        private Label labelCashStatus;
    }
}
