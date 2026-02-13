namespace Day4
{
    partial class LoginWindow
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
            label1 = new Label();
            label2 = new Label();
            tbx_Email = new TextBox();
            tbx_Password = new TextBox();
            btn_Login = new Button();
            btn_Back = new Button();
            pbx_Eye = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbx_Eye).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(170, 121);
            label1.Name = "label1";
            label1.Size = new Size(67, 27);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(129, 187);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // tbx_Email
            // 
            tbx_Email.BackColor = Color.Honeydew;
            tbx_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Email.ForeColor = Color.IndianRed;
            tbx_Email.Location = new Point(243, 116);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(375, 34);
            tbx_Email.TabIndex = 9;
            // 
            // tbx_Password
            // 
            tbx_Password.BackColor = Color.Honeydew;
            tbx_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Password.ForeColor = Color.IndianRed;
            tbx_Password.Location = new Point(243, 182);
            tbx_Password.Name = "tbx_Password";
            tbx_Password.Size = new Size(375, 34);
            tbx_Password.TabIndex = 10;
            tbx_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.White;
            btn_Login.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold);
            btn_Login.ForeColor = Color.Sienna;
            btn_Login.Location = new Point(319, 273);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(183, 62);
            btn_Login.TabIndex = 11;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Back.ForeColor = Color.Sienna;
            btn_Back.Location = new Point(12, 397);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(105, 41);
            btn_Back.TabIndex = 12;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // pbx_Eye
            // 
            pbx_Eye.BackgroundImageLayout = ImageLayout.None;
            pbx_Eye.Cursor = Cursors.Hand;
            pbx_Eye.ImageLocation = "C:\\Users\\adminstrator\\Documents\\ITI_9Months\\C#\\Entity Framework\\Day4\\Lab\\Day4\\Day4\\Properties\\resources\\eyeOpened.png";
            pbx_Eye.Location = new Point(624, 182);
            pbx_Eye.Name = "pbx_Eye";
            pbx_Eye.Size = new Size(47, 32);
            pbx_Eye.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_Eye.TabIndex = 13;
            pbx_Eye.TabStop = false;
            pbx_Eye.Click += pictureBox1_Click;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(pbx_Eye);
            Controls.Add(btn_Back);
            Controls.Add(btn_Login);
            Controls.Add(tbx_Password);
            Controls.Add(tbx_Email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginWindow";
            Text = "LoginWindow";
            ((System.ComponentModel.ISupportInitialize)pbx_Eye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbx_Email;
        private TextBox tbx_Password;
        private Button btn_Login;
        private Button btn_Back;
        private PictureBox pbx_Eye;
    }
}