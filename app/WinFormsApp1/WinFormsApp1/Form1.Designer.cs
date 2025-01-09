namespace WinFormsApp1
{
    partial class Form1
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
            saveBtn = new Button();
            panel1 = new Panel();
            typeComboBox = new ComboBox();
            descTextbox = new TextBox();
            priceTextbox = new TextBox();
            nameTextbox = new TextBox();
            searchTextBox = new TextBox();
            searchBtn = new Button();
            panel2 = new Panel();
            StatisticsBtn = new Button();
            resultsListbox = new ListBox();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            discountType = new ComboBox();
            label1 = new Label();
            discountTextBox = new TextBox();
            discountBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(448, 0);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(82, 23);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Mentés";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(typeComboBox);
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(descTextbox);
            panel1.Controls.Add(priceTextbox);
            panel1.Controls.Add(nameTextbox);
            panel1.Location = new Point(203, 255);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 25);
            panel1.TabIndex = 1;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "CPU", "GPU", "RAM", "MOBO", "HDD", "SSD", "MOUSE", "KEYBOARD" });
            typeComboBox.Location = new Point(0, 0);
            typeComboBox.Margin = new Padding(3, 2, 3, 2);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(86, 23);
            typeComboBox.TabIndex = 6;
            typeComboBox.Text = "Típus";
            // 
            // descTextbox
            // 
            descTextbox.ForeColor = SystemColors.ControlText;
            descTextbox.Location = new Point(222, 0);
            descTextbox.Margin = new Padding(3, 2, 3, 2);
            descTextbox.Name = "descTextbox";
            descTextbox.PlaceholderText = "Leírás";
            descTextbox.Size = new Size(129, 23);
            descTextbox.TabIndex = 3;
            // 
            // priceTextbox
            // 
            priceTextbox.ForeColor = SystemColors.ControlText;
            priceTextbox.Location = new Point(357, 0);
            priceTextbox.Margin = new Padding(3, 2, 3, 2);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.PlaceholderText = "Ár (Ft)";
            priceTextbox.Size = new Size(85, 23);
            priceTextbox.TabIndex = 4;
            // 
            // nameTextbox
            // 
            nameTextbox.ForeColor = SystemColors.ControlText;
            nameTextbox.Location = new Point(92, 0);
            nameTextbox.Margin = new Padding(3, 2, 3, 2);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.PlaceholderText = "Név";
            nameTextbox.Size = new Size(124, 23);
            nameTextbox.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(0, 1);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(360, 23);
            searchTextBox.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.BackgroundImage = Properties.Resources.srch;
            searchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            searchBtn.Image = Properties.Resources.srch;
            searchBtn.Location = new Point(365, -1);
            searchBtn.Margin = new Padding(3, 2, 3, 2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(25, 25);
            searchBtn.TabIndex = 3;
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchbtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(StatisticsBtn);
            panel2.Controls.Add(resultsListbox);
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(searchBtn);
            panel2.Location = new Point(203, 96);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 140);
            panel2.TabIndex = 4;
            // 
            // StatisticsBtn
            // 
            StatisticsBtn.Location = new Point(396, -1);
            StatisticsBtn.Name = "StatisticsBtn";
            StatisticsBtn.Size = new Size(75, 25);
            StatisticsBtn.TabIndex = 7;
            StatisticsBtn.Text = "Statisztika";
            StatisticsBtn.UseVisualStyleBackColor = true;
            StatisticsBtn.Click += StatisticsBtn_Click;
            // 
            // resultsListbox
            // 
            resultsListbox.FormattingEnabled = true;
            resultsListbox.ItemHeight = 15;
            resultsListbox.Location = new Point(0, 26);
            resultsListbox.Margin = new Padding(3, 2, 3, 2);
            resultsListbox.Name = "resultsListbox";
            resultsListbox.Size = new Size(360, 94);
            resultsListbox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.RoyalBlue;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Arial", 30F, FontStyle.Bold);
            richTextBox1.ForeColor = Color.WhiteSmoke;
            richTextBox1.Location = new Point(74, 0);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(246, 53);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "Admin Panel";
            // 
            // discountType
            // 
            discountType.FormattingEnabled = true;
            discountType.Items.AddRange(new object[] { "CPU", "GPU", "RAM", "MOBO", "HDD", "SSD", "MOUSE", "KEYBOARD", "ÖSZZES" });
            discountType.Location = new Point(203, 335);
            discountType.Name = "discountType";
            discountType.Size = new Size(86, 23);
            discountType.TabIndex = 7;
            discountType.Text = "Típus";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(203, 304);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 8;
            label1.Text = "Akció";
            // 
            // discountTextBox
            // 
            discountTextBox.Location = new Point(295, 335);
            discountTextBox.Name = "discountTextBox";
            discountTextBox.PlaceholderText = "%";
            discountTextBox.Size = new Size(44, 23);
            discountTextBox.TabIndex = 9;
            // 
            // discountBtn
            // 
            discountBtn.Location = new Point(344, 334);
            discountBtn.Name = "discountBtn";
            discountBtn.Size = new Size(75, 23);
            discountBtn.TabIndex = 10;
            discountBtn.Text = "Mentés";
            discountBtn.UseVisualStyleBackColor = true;
            discountBtn.Click += discountBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 133, 239);
            ClientSize = new Size(959, 455);
            Controls.Add(discountBtn);
            Controls.Add(discountTextBox);
            Controls.Add(label1);
            Controls.Add(discountType);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "-";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Panel panel1;
        private TextBox nameTextbox;
        private TextBox descTextbox;
        private TextBox priceTextbox;
        private TextBox searchTextBox;
        private Button searchBtn;
        private Panel panel2;
        private ListBox resultsListbox;
        private PictureBox pictureBox1;
        private ComboBox typeComboBox;
        private RichTextBox richTextBox1;
        private Button StatisticsBtn;
        private ComboBox discountType;
        private Label label1;
        private TextBox discountTextBox;
        private Button discountBtn;
    }
}
