namespace Day3
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
            dgv_students = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmb_departments = new ComboBox();
            txt_name = new TextBox();
            txt_address = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_students).BeginInit();
            SuspendLayout();
            // 
            // dgv_students
            // 
            dgv_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_students.Location = new Point(44, 20);
            dgv_students.Name = "dgv_students";
            dgv_students.RowHeadersWidth = 51;
            dgv_students.Size = new Size(797, 273);
            dgv_students.TabIndex = 0;
            dgv_students.RowHeaderMouseClick += dgv_students_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 317);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 361);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 405);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "Department";
            // 
            // cmb_departments
            // 
            cmb_departments.FormattingEnabled = true;
            cmb_departments.Location = new Point(140, 402);
            cmb_departments.Name = "cmb_departments";
            cmb_departments.Size = new Size(129, 28);
            cmb_departments.TabIndex = 7;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(140, 314);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 8;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(140, 358);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(125, 27);
            txt_address.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(490, 331);
            button1.Name = "button1";
            button1.Size = new Size(98, 42);
            button1.TabIndex = 10;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(611, 331);
            button2.Name = "button2";
            button2.Size = new Size(114, 42);
            button2.TabIndex = 11;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.DarkOliveGreen;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = SystemColors.ButtonHighlight;
            btn_add.Location = new Point(553, 389);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(99, 42);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 450);
            Controls.Add(btn_add);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_address);
            Controls.Add(txt_name);
            Controls.Add(cmb_departments);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_students);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_students;
        private TextBox txt_address;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmb_departments;
        private TextBox txt_name;
        private Button button1;
        private Button button2;
        private Button btn_add;
    }
}
