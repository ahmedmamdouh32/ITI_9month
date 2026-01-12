namespace Task1
{
    partial class StudentDetails
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
            label3 = new Label();
            label4 = new Label();
            lbl_Name = new Label();
            lbl_ID = new Label();
            lbl_Department = new Label();
            lbl_Gender = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(77, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(77, 104);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 31);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(77, 175);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 31);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(77, 260);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 31);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(278, 28);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(79, 31);
            lbl_Name.TabIndex = 4;
            lbl_Name.Text = "label5";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(278, 104);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(79, 31);
            lbl_ID.TabIndex = 5;
            lbl_ID.Text = "label6";
            // 
            // lbl_Department
            // 
            lbl_Department.AutoSize = true;
            lbl_Department.Location = new Point(278, 175);
            lbl_Department.Name = "lbl_Department";
            lbl_Department.Size = new Size(79, 31);
            lbl_Department.TabIndex = 6;
            lbl_Department.Text = "label7";
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.Location = new Point(278, 260);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(79, 31);
            lbl_Gender.TabIndex = 7;
            lbl_Gender.Text = "label8";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(312, 359);
            button1.Name = "button1";
            button1.Size = new Size(178, 60);
            button1.TabIndex = 8;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(button1);
            Controls.Add(lbl_Gender);
            Controls.Add(lbl_Department);
            Controls.Add(lbl_ID);
            Controls.Add(lbl_Name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "StudentDetails";
            Text = "Student Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_Name;
        private Label lbl_ID;
        private Label lbl_Department;
        private Label lbl_Gender;
        private Button button1;
    }
}