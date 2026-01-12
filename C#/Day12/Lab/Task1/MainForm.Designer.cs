namespace Task1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btn_addStudent = new Button();
            btn_studentsList = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // btn_addStudent
            // 
            resources.ApplyResources(btn_addStudent, "btn_addStudent");
            btn_addStudent.Name = "btn_addStudent";
            btn_addStudent.UseVisualStyleBackColor = true;
            btn_addStudent.Click += btn_addStudent_Click;
            // 
            // btn_studentsList
            // 
            resources.ApplyResources(btn_studentsList, "btn_studentsList");
            btn_studentsList.Name = "btn_studentsList";
            btn_studentsList.UseVisualStyleBackColor = true;
            btn_studentsList.Click += btn_studentsList_Click;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_studentsList);
            Controls.Add(btn_addStudent);
            Name = "MainForm";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_addStudent;
        private Button btn_studentsList;
        private ColorDialog colorDialog1;
    }
}
