using Task1.models;

namespace Task1
{
    
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            txt_Name = new TextBox();
            txt_ID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmb_Department = new ComboBox();
            label3 = new Label();
            rb_GenderMale = new RadioButton();
            label4 = new Label();
            rb_GenderFemale = new RadioButton();
            btn_addStudent = new Button();
            btn_Back = new Button();
            SuspendLayout();
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(349, 141);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(182, 27);
            txt_Name.TabIndex = 0;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(349, 174);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(182, 27);
            txt_ID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 144);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 177);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // cmb_Department
            // 
            cmb_Department.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Department.FormattingEnabled = true;
            cmb_Department.Location = new Point(349, 207);
            cmb_Department.Name = "cmb_Department";
            cmb_Department.Size = new Size(182, 28);
            cmb_Department.TabIndex = 4;
            cmb_Department.Items.AddRange(departments);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 210);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Department";
            // 
            // rb_GenderMale
            // 
            rb_GenderMale.AutoSize = true;
            rb_GenderMale.Location = new Point(349, 241);
            rb_GenderMale.Name = "rb_GenderMale";
            rb_GenderMale.Size = new Size(63, 24);
            rb_GenderMale.TabIndex = 6;
            rb_GenderMale.TabStop = true;
            rb_GenderMale.Text = "Male";
            rb_GenderMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 241);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // rb_GenderFemale
            // 
            rb_GenderFemale.AutoSize = true;
            rb_GenderFemale.Location = new Point(418, 241);
            rb_GenderFemale.Name = "rb_GenderFemale";
            rb_GenderFemale.Size = new Size(78, 24);
            rb_GenderFemale.TabIndex = 8;
            rb_GenderFemale.TabStop = true;
            rb_GenderFemale.Text = "Female";
            rb_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // btn_addStudent
            // 
            btn_addStudent.BackColor = Color.FromArgb(0, 192, 0);
            btn_addStudent.FlatStyle = FlatStyle.Flat;
            btn_addStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addStudent.ForeColor = SystemColors.ButtonFace;
            btn_addStudent.Location = new Point(310, 319);
            btn_addStudent.Name = "btn_addStudent";
            btn_addStudent.Size = new Size(186, 46);
            btn_addStudent.TabIndex = 9;
            btn_addStudent.Text = "Add";
            btn_addStudent.UseVisualStyleBackColor = false;
            btn_addStudent.Click += btn_addStudent_Click_1;
            // 
            // btn_Back
            // 
            btn_Back.ForeColor = SystemColors.ControlLight;
            btn_Back.Image = (Image)resources.GetObject("btn_Back.Image");
            btn_Back.Location = new Point(12, 12);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(70, 41);
            btn_Back.TabIndex = 10;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Back);
            Controls.Add(btn_addStudent);
            Controls.Add(rb_GenderFemale);
            Controls.Add(label4);
            Controls.Add(rb_GenderMale);
            Controls.Add(label3);
            Controls.Add(cmb_Department);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_ID);
            Controls.Add(txt_Name);
            Name = "AddStudent";
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            ParentPage.Show();
            this.Close();
        }

        private void btn_addStudent_Click_1(object sender, EventArgs e)
        {
            if(txt_Name.Text != "" && int.TryParse(txt_ID.Text, out int id) && (rb_GenderFemale.Checked||rb_GenderMale.Checked) && cmb_Department.Text != "")
            {
                Student student = new Student();
                student.Name = txt_Name.Text;
                student.Id = id;
                student.Department = cmb_Department.Text;
                student.Gender = rb_GenderFemale.Checked ? Gender.female : Gender.male;
                StudentRepository.addStudent(student);
                MessageBox.Show("Student Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ID.Clear();
                txt_Name.Clear();
                rb_GenderFemale.Checked = false;
                rb_GenderMale.Checked = false;
                cmb_Department.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Invalid Input","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        private TextBox txt_Name;
        private TextBox txt_ID;
        private Label label1;
        private Label label2;
        private ComboBox cmb_Department;
        private Label label3;
        private RadioButton rb_GenderMale;
        private Label label4;
        private RadioButton rb_GenderFemale;
        private Button btn_addStudent;
        private Button btn_Back;
    }
}