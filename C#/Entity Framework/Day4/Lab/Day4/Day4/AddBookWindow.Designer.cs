namespace Day4
{
    partial class AddBookWindow
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
            tbx_Title = new TextBox();
            Title = new Label();
            lbl_YourExperienceLength = new Label();
            tbx_Brief = new TextBox();
            label3 = new Label();
            dtp_PublishDate = new DateTimePicker();
            label1 = new Label();
            tbx_Price = new TextBox();
            label2 = new Label();
            tbx_Quantity = new TextBox();
            label4 = new Label();
            cbx_Category = new ComboBox();
            label5 = new Label();
            ofd_BookImage = new OpenFileDialog();
            pbx_BookImage = new PictureBox();
            label7 = new Label();
            btn_AddBook = new Button();
            btn_Back = new Button();
            btn_ChooseFile = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbx_BookImage).BeginInit();
            SuspendLayout();
            // 
            // tbx_Title
            // 
            tbx_Title.BackColor = Color.Honeydew;
            tbx_Title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Title.ForeColor = Color.IndianRed;
            tbx_Title.Location = new Point(182, 12);
            tbx_Title.Name = "tbx_Title";
            tbx_Title.Size = new Size(375, 34);
            tbx_Title.TabIndex = 11;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            Title.ForeColor = Color.Transparent;
            Title.Location = new Point(119, 17);
            Title.Name = "Title";
            Title.Size = new Size(57, 27);
            Title.TabIndex = 10;
            Title.Text = "Title";
            // 
            // lbl_YourExperienceLength
            // 
            lbl_YourExperienceLength.AutoSize = true;
            lbl_YourExperienceLength.ForeColor = Color.White;
            lbl_YourExperienceLength.Location = new Point(656, 208);
            lbl_YourExperienceLength.Name = "lbl_YourExperienceLength";
            lbl_YourExperienceLength.Size = new Size(47, 20);
            lbl_YourExperienceLength.TabIndex = 14;
            lbl_YourExperienceLength.Text = "0/300";
            // 
            // tbx_Brief
            // 
            tbx_Brief.BackColor = Color.Honeydew;
            tbx_Brief.Font = new Font("Simple Indust Outline", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            tbx_Brief.ForeColor = Color.IndianRed;
            tbx_Brief.Location = new Point(182, 82);
            tbx_Brief.MaxLength = 300;
            tbx_Brief.Multiline = true;
            tbx_Brief.Name = "tbx_Brief";
            tbx_Brief.ScrollBars = ScrollBars.Vertical;
            tbx_Brief.Size = new Size(468, 160);
            tbx_Brief.TabIndex = 13;
            tbx_Brief.TextChanged += tbx_Brief_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(115, 82);
            label3.Name = "label3";
            label3.Size = new Size(60, 27);
            label3.TabIndex = 12;
            label3.Text = "Brief";
            // 
            // dtp_PublishDate
            // 
            dtp_PublishDate.Location = new Point(182, 278);
            dtp_PublishDate.Name = "dtp_PublishDate";
            dtp_PublishDate.Size = new Size(322, 27);
            dtp_PublishDate.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(39, 278);
            label1.Name = "label1";
            label1.Size = new Size(140, 27);
            label1.TabIndex = 16;
            label1.Text = "Publish Date";
            // 
            // tbx_Price
            // 
            tbx_Price.BackColor = Color.Honeydew;
            tbx_Price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Price.ForeColor = Color.IndianRed;
            tbx_Price.Location = new Point(182, 341);
            tbx_Price.Name = "tbx_Price";
            tbx_Price.Size = new Size(375, 34);
            tbx_Price.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(114, 341);
            label2.Name = "label2";
            label2.Size = new Size(61, 27);
            label2.TabIndex = 18;
            label2.Text = "Price";
            label2.Click += label2_Click;
            // 
            // tbx_Quantity
            // 
            tbx_Quantity.BackColor = Color.Honeydew;
            tbx_Quantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Quantity.ForeColor = Color.IndianRed;
            tbx_Quantity.Location = new Point(182, 411);
            tbx_Quantity.Name = "tbx_Quantity";
            tbx_Quantity.Size = new Size(375, 34);
            tbx_Quantity.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(80, 411);
            label4.Name = "label4";
            label4.Size = new Size(99, 27);
            label4.TabIndex = 20;
            label4.Text = "Quantity";
            // 
            // cbx_Category
            // 
            cbx_Category.BackColor = Color.Honeydew;
            cbx_Category.Font = new Font("Segoe UI", 12F);
            cbx_Category.FormattingEnabled = true;
            cbx_Category.Location = new Point(182, 481);
            cbx_Category.Name = "cbx_Category";
            cbx_Category.Size = new Size(375, 36);
            cbx_Category.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(74, 481);
            label5.Name = "label5";
            label5.Size = new Size(102, 27);
            label5.TabIndex = 22;
            label5.Text = "Category";
            // 
            // ofd_BookImage
            // 
            ofd_BookImage.FileName = "openFileDialog1";
            // 
            // pbx_BookImage
            // 
            pbx_BookImage.Cursor = Cursors.Hand;
            pbx_BookImage.Image = Properties.Resources.addImage;
            pbx_BookImage.Location = new Point(806, 49);
            pbx_BookImage.Name = "pbx_BookImage";
            pbx_BookImage.Size = new Size(256, 256);
            pbx_BookImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbx_BookImage.TabIndex = 23;
            pbx_BookImage.TabStop = false;
            pbx_BookImage.Click += pbx_BookImage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(845, 308);
            label7.Name = "label7";
            label7.Size = new Size(187, 27);
            label7.TabIndex = 25;
            label7.Text = "Add Cover Image";
            label7.Click += label7_Click;
            // 
            // btn_AddBook
            // 
            btn_AddBook.BackColor = Color.White;
            btn_AddBook.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold);
            btn_AddBook.ForeColor = Color.Sienna;
            btn_AddBook.Location = new Point(710, 631);
            btn_AddBook.Name = "btn_AddBook";
            btn_AddBook.Size = new Size(183, 62);
            btn_AddBook.TabIndex = 26;
            btn_AddBook.Text = "Add";
            btn_AddBook.UseVisualStyleBackColor = false;
            btn_AddBook.Click += btn_AddBook_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold);
            btn_Back.ForeColor = Color.Sienna;
            btn_Back.Location = new Point(12, 891);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(115, 43);
            btn_Back.TabIndex = 27;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_ChooseFile
            // 
            btn_ChooseFile.BackColor = Color.Honeydew;
            btn_ChooseFile.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ChooseFile.ForeColor = Color.Maroon;
            btn_ChooseFile.Location = new Point(182, 550);
            btn_ChooseFile.Name = "btn_ChooseFile";
            btn_ChooseFile.Size = new Size(249, 42);
            btn_ChooseFile.TabIndex = 29;
            btn_ChooseFile.Text = "Choose File";
            btn_ChooseFile.UseVisualStyleBackColor = false;
            btn_ChooseFile.Click += btn_ChooseFile_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(80, 554);
            label6.Name = "label6";
            label6.Size = new Size(93, 27);
            label6.TabIndex = 30;
            label6.Text = "PDF File";
            // 
            // AddBookWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 64, 0);
            ClientSize = new Size(1307, 946);
            Controls.Add(label6);
            Controls.Add(btn_ChooseFile);
            Controls.Add(btn_Back);
            Controls.Add(btn_AddBook);
            Controls.Add(label7);
            Controls.Add(pbx_BookImage);
            Controls.Add(label5);
            Controls.Add(cbx_Category);
            Controls.Add(label4);
            Controls.Add(tbx_Quantity);
            Controls.Add(label2);
            Controls.Add(tbx_Price);
            Controls.Add(label1);
            Controls.Add(dtp_PublishDate);
            Controls.Add(lbl_YourExperienceLength);
            Controls.Add(tbx_Brief);
            Controls.Add(label3);
            Controls.Add(tbx_Title);
            Controls.Add(Title);
            Name = "AddBookWindow";
            Text = "AddBookWindow";
            WindowState = FormWindowState.Maximized;
            Load += AddBookWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_BookImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_Title;
        private Label Title;
        private Label lbl_YourExperienceLength;
        private TextBox tbx_Brief;
        private Label label3;
        private DateTimePicker dtp_PublishDate;
        private Label label1;
        private TextBox tbx_Price;
        private Label label2;
        private TextBox tbx_Quantity;
        private Label label4;
        private ComboBox cbx_Category;
        private Label label5;
        private OpenFileDialog ofd_BookImage;
        private PictureBox pbx_BookImage;
        private Label label7;
        private Button btn_AddBook;
        private Button btn_Back;
        private Button btn_ChooseFile;
        private Label label6;
    }
}