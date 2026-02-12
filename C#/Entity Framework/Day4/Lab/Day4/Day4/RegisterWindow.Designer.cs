namespace Day4
{
    partial class RegisterWindow
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
            btn_Back = new Button();
            btn_Next = new Button();
            label1 = new Label();
            label2 = new Label();
            tbx_FullName = new TextBox();
            tbx_Age = new TextBox();
            tbx_YourExperience = new TextBox();
            label3 = new Label();
            lbl_YourExperienceLength = new Label();
            SuspendLayout();
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Back.ForeColor = Color.Sienna;
            btn_Back.Location = new Point(12, 397);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(105, 41);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += button1_Click;
            // 
            // btn_Next
            // 
            btn_Next.BackColor = Color.White;
            btn_Next.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Next.ForeColor = Color.Sienna;
            btn_Next.Location = new Point(683, 397);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(105, 41);
            btn_Next.TabIndex = 2;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = false;
            btn_Next.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(89, 59);
            label1.Name = "label1";
            label1.Size = new Size(115, 27);
            label1.TabIndex = 4;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(152, 116);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // tbx_FullName
            // 
            tbx_FullName.BackColor = Color.Honeydew;
            tbx_FullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_FullName.ForeColor = Color.IndianRed;
            tbx_FullName.Location = new Point(218, 59);
            tbx_FullName.Name = "tbx_FullName";
            tbx_FullName.Size = new Size(215, 34);
            tbx_FullName.TabIndex = 8;
            // 
            // tbx_Age
            // 
            tbx_Age.BackColor = Color.Honeydew;
            tbx_Age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_Age.ForeColor = Color.IndianRed;
            tbx_Age.Location = new Point(218, 116);
            tbx_Age.Name = "tbx_Age";
            tbx_Age.Size = new Size(215, 34);
            tbx_Age.TabIndex = 9;
            // 
            // tbx_YourExperience
            // 
            tbx_YourExperience.BackColor = Color.Honeydew;
            tbx_YourExperience.Font = new Font("Simple Indust Outline", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            tbx_YourExperience.ForeColor = Color.IndianRed;
            tbx_YourExperience.Location = new Point(218, 173);
            tbx_YourExperience.MaxLength = 3000;
            tbx_YourExperience.Multiline = true;
            tbx_YourExperience.Name = "tbx_YourExperience";
            tbx_YourExperience.ScrollBars = ScrollBars.Vertical;
            tbx_YourExperience.Size = new Size(468, 160);
            tbx_YourExperience.TabIndex = 10;
            tbx_YourExperience.TextChanged += tbx_YourExperience_TextChanged;
            tbx_YourExperience.KeyPress += tbx_YourExperience_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(38, 173);
            label3.Name = "label3";
            label3.Size = new Size(174, 27);
            label3.TabIndex = 6;
            label3.Text = "Your Experience";
            // 
            // lbl_YourExperienceLength
            // 
            lbl_YourExperienceLength.AutoSize = true;
            lbl_YourExperienceLength.ForeColor = Color.White;
            lbl_YourExperienceLength.Location = new Point(692, 313);
            lbl_YourExperienceLength.Name = "lbl_YourExperienceLength";
            lbl_YourExperienceLength.Size = new Size(55, 20);
            lbl_YourExperienceLength.TabIndex = 11;
            lbl_YourExperienceLength.Text = "0/3000";
            // 
            // RegisterWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_YourExperienceLength);
            Controls.Add(tbx_YourExperience);
            Controls.Add(tbx_Age);
            Controls.Add(tbx_FullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Next);
            Controls.Add(btn_Back);
            Name = "RegisterWindow";
            Text = "RegisterWindow";
            Load += RegisterWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Back;
        private Button btn_Next;
        private Label label1;
        private Label label2;
        private TextBox tbx_FullName;
        private TextBox tbx_Age;
        private TextBox tbx_YourExperience;
        private Label label3;
        private Label lbl_YourExperienceLength;
    }
}