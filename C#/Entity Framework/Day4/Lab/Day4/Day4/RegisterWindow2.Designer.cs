namespace Day4
{
    partial class RegisterWindow2
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
            tbx_Email = new TextBox();
            tbx_Password = new TextBox();
            tbx_ConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbx_PhoneNumber = new TextBox();
            label4 = new Label();
            this.btn_Back = new Button();
            btn_Confirm = new Button();
            SuspendLayout();
            // 
            // tbx_Email
            // 
            tbx_Email.BackColor = Color.Honeydew;
            tbx_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Email.ForeColor = Color.IndianRed;
            tbx_Email.Location = new Point(225, 36);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(215, 34);
            tbx_Email.TabIndex = 9;
            // 
            // tbx_Password
            // 
            tbx_Password.BackColor = Color.Honeydew;
            tbx_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Password.ForeColor = Color.IndianRed;
            tbx_Password.Location = new Point(225, 162);
            tbx_Password.Name = "tbx_Password";
            tbx_Password.Size = new Size(215, 34);
            tbx_Password.TabIndex = 10;
            tbx_Password.UseSystemPasswordChar = true;
            // 
            // tbx_ConfirmPassword
            // 
            tbx_ConfirmPassword.BackColor = Color.Honeydew;
            tbx_ConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_ConfirmPassword.ForeColor = Color.IndianRed;
            tbx_ConfirmPassword.Location = new Point(225, 225);
            tbx_ConfirmPassword.Name = "tbx_ConfirmPassword";
            tbx_ConfirmPassword.Size = new Size(215, 34);
            tbx_ConfirmPassword.TabIndex = 11;
            tbx_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(65, 36);
            label1.Name = "label1";
            label1.Size = new Size(154, 27);
            label1.TabIndex = 12;
            label1.Text = "Email Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(111, 162);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(24, 225);
            label3.Name = "label3";
            label3.Size = new Size(195, 27);
            label3.TabIndex = 14;
            label3.Text = "Confirm Password";
            // 
            // tbx_PhoneNumber
            // 
            tbx_PhoneNumber.BackColor = Color.Honeydew;
            tbx_PhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_PhoneNumber.ForeColor = Color.IndianRed;
            tbx_PhoneNumber.Location = new Point(225, 99);
            tbx_PhoneNumber.Name = "tbx_PhoneNumber";
            tbx_PhoneNumber.Size = new Size(215, 34);
            tbx_PhoneNumber.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(54, 99);
            label4.Name = "label4";
            label4.Size = new Size(165, 27);
            label4.TabIndex = 16;
            label4.Text = "Phone Number";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = Color.White;
            this.btn_Back.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btn_Back.ForeColor = Color.Sienna;
            this.btn_Back.Location = new Point(12, 397);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new Size(105, 41);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += this.btn_Back_Click;
            // 
            // btn_Confirm
            // 
            btn_Confirm.BackColor = Color.White;
            btn_Confirm.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Confirm.ForeColor = Color.Sienna;
            btn_Confirm.Location = new Point(671, 397);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(117, 41);
            btn_Confirm.TabIndex = 18;
            btn_Confirm.Text = "Confirm";
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // RegisterWindow2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Confirm);
            Controls.Add(this.btn_Back);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbx_PhoneNumber);
            Controls.Add(tbx_ConfirmPassword);
            Controls.Add(tbx_Password);
            Controls.Add(tbx_Email);
            Name = "RegisterWindow2";
            Text = "RegisterWindow2";
            Load += RegisterWindow2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_Email;
        private TextBox tbx_Password;
        private TextBox tbx_ConfirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbx_PhoneNumber;
        private Label label4;
        private Button btn_Back;
        private Button btn_Confirm;
    }
}