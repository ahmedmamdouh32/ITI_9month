namespace Day4
{
    partial class UserProfileWindow
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
            lbl_YourExperienceLength = new Label();
            tbx_YourExperience = new TextBox();
            tbx_Age = new TextBox();
            tbx_FullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbx_Address = new TextBox();
            label4 = new Label();
            tbx_PhoneNumber = new TextBox();
            label5 = new Label();
            tbx_Username = new TextBox();
            label6 = new Label();
            btn_Update = new Button();
            btn_Back = new Button();
            SuspendLayout();
            // 
            // lbl_YourExperienceLength
            // 
            lbl_YourExperienceLength.AutoSize = true;
            lbl_YourExperienceLength.ForeColor = Color.White;
            lbl_YourExperienceLength.Location = new Point(691, 423);
            lbl_YourExperienceLength.Name = "lbl_YourExperienceLength";
            lbl_YourExperienceLength.Size = new Size(55, 20);
            lbl_YourExperienceLength.TabIndex = 18;
            lbl_YourExperienceLength.Text = "0/3000";
            // 
            // tbx_YourExperience
            // 
            tbx_YourExperience.BackColor = Color.Honeydew;
            tbx_YourExperience.Font = new Font("Simple Indust Outline", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            tbx_YourExperience.ForeColor = Color.IndianRed;
            tbx_YourExperience.Location = new Point(217, 283);
            tbx_YourExperience.MaxLength = 3000;
            tbx_YourExperience.Multiline = true;
            tbx_YourExperience.Name = "tbx_YourExperience";
            tbx_YourExperience.ScrollBars = ScrollBars.Vertical;
            tbx_YourExperience.Size = new Size(468, 160);
            tbx_YourExperience.TabIndex = 17;
            tbx_YourExperience.TextChanged += tbx_YourExperience_TextChanged;
            // 
            // tbx_Age
            // 
            tbx_Age.BackColor = Color.Honeydew;
            tbx_Age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Age.ForeColor = Color.IndianRed;
            tbx_Age.Location = new Point(217, 85);
            tbx_Age.Name = "tbx_Age";
            tbx_Age.Size = new Size(215, 34);
            tbx_Age.TabIndex = 16;
            // 
            // tbx_FullName
            // 
            tbx_FullName.BackColor = Color.Honeydew;
            tbx_FullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_FullName.ForeColor = Color.IndianRed;
            tbx_FullName.Location = new Point(217, 19);
            tbx_FullName.Name = "tbx_FullName";
            tbx_FullName.Size = new Size(215, 34);
            tbx_FullName.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(37, 282);
            label3.Name = "label3";
            label3.Size = new Size(174, 27);
            label3.TabIndex = 14;
            label3.Text = "Your Experience";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(159, 85);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 13;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(96, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 27);
            label1.TabIndex = 12;
            label1.Text = "Full Name";
            // 
            // tbx_Address
            // 
            tbx_Address.BackColor = Color.Honeydew;
            tbx_Address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Address.ForeColor = Color.IndianRed;
            tbx_Address.Location = new Point(217, 475);
            tbx_Address.Name = "tbx_Address";
            tbx_Address.Size = new Size(468, 34);
            tbx_Address.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(131, 479);
            label4.Name = "label4";
            label4.Size = new Size(80, 27);
            label4.TabIndex = 20;
            label4.Text = "Adress";
            // 
            // tbx_PhoneNumber
            // 
            tbx_PhoneNumber.BackColor = Color.Honeydew;
            tbx_PhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_PhoneNumber.ForeColor = Color.IndianRed;
            tbx_PhoneNumber.Location = new Point(217, 151);
            tbx_PhoneNumber.Name = "tbx_PhoneNumber";
            tbx_PhoneNumber.Size = new Size(215, 34);
            tbx_PhoneNumber.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(46, 151);
            label5.Name = "label5";
            label5.Size = new Size(165, 27);
            label5.TabIndex = 23;
            label5.Text = "Phone Number";
            // 
            // tbx_Username
            // 
            tbx_Username.BackColor = Color.Honeydew;
            tbx_Username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Username.ForeColor = Color.IndianRed;
            tbx_Username.Location = new Point(217, 217);
            tbx_Username.Name = "tbx_Username";
            tbx_Username.Size = new Size(215, 34);
            tbx_Username.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(96, 217);
            label6.Name = "label6";
            label6.Size = new Size(115, 27);
            label6.TabIndex = 25;
            label6.Text = "Username";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.White;
            btn_Update.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold);
            btn_Update.ForeColor = Color.Sienna;
            btn_Update.Location = new Point(801, 706);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(183, 62);
            btn_Update.TabIndex = 26;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold);
            btn_Back.ForeColor = Color.Sienna;
            btn_Back.Location = new Point(12, 925);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(130, 48);
            btn_Back.TabIndex = 27;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // UserProfileWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 64, 0);
            ClientSize = new Size(1802, 925);
            Controls.Add(btn_Back);
            Controls.Add(btn_Update);
            Controls.Add(label6);
            Controls.Add(tbx_Username);
            Controls.Add(label5);
            Controls.Add(tbx_PhoneNumber);
            Controls.Add(label4);
            Controls.Add(tbx_Address);
            Controls.Add(lbl_YourExperienceLength);
            Controls.Add(tbx_YourExperience);
            Controls.Add(tbx_Age);
            Controls.Add(tbx_FullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserProfileWindow";
            Text = "UserProfileWindow";
            WindowState = FormWindowState.Maximized;
            Load += UserProfileWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_YourExperienceLength;
        private TextBox tbx_YourExperience;
        private TextBox tbx_Age;
        private TextBox tbx_FullName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox tbx_PhoneNumber;
        private TextBox tbx_Address;
        private Label label5;
        private TextBox tbx_Username;
        private Label label6;
        private Button btn_Update;
        private Button btn_Back;
    }
}