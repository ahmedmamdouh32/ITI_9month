namespace Day4
{
    partial class StartWindow
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
            btn_Register = new Button();
            btn_Login = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.White;
            btn_Register.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Register.ForeColor = Color.Sienna;
            btn_Register.Location = new Point(307, 133);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(183, 62);
            btn_Register.TabIndex = 0;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.White;
            btn_Login.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold);
            btn_Login.ForeColor = Color.Sienna;
            btn_Login.Location = new Point(307, 248);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(183, 62);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ImageLocation = "C:\\Users\\adminstrator\\Documents\\ITI_9Months\\C#\\Entity Framework\\Day4\\Lab\\Day4\\Day4\\Properties\\resources\\book.png";
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(123, 27);
            label1.TabIndex = 3;
            label1.Text = "Book Store";
            label1.Click += label1_Click;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Login);
            Controls.Add(btn_Register);
            Name = "StartWindow";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Register;
        private Button btn_Login;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
