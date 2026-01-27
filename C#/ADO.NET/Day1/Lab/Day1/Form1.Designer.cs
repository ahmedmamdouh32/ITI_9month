namespace Day1
{
    partial class Form1
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
            this.dgv_instructors = new System.Windows.Forms.DataGridView();
            this.btn_update_instructor = new System.Windows.Forms.Button();
            this.tb_instructor_salary = new System.Windows.Forms.TextBox();
            this.tb_instructor_name = new System.Windows.Forms.TextBox();
            this.tb_instructor_department_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_create_instructor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_instructors
            // 
            this.dgv_instructors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_instructors.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_instructors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_instructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instructors.Location = new System.Drawing.Point(12, 12);
            this.dgv_instructors.Name = "dgv_instructors";
            this.dgv_instructors.RowHeadersWidth = 51;
            this.dgv_instructors.RowTemplate.Height = 24;
            this.dgv_instructors.Size = new System.Drawing.Size(776, 279);
            this.dgv_instructors.TabIndex = 0;
            this.dgv_instructors.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_instructors_RowHeaderMouseClick);
            this.dgv_instructors.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_instructors_RowHeaderMouseDoubleClick);
            // 
            // btn_update_instructor
            // 
            this.btn_update_instructor.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_update_instructor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_instructor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update_instructor.Location = new System.Drawing.Point(663, 330);
            this.btn_update_instructor.Name = "btn_update_instructor";
            this.btn_update_instructor.Size = new System.Drawing.Size(125, 41);
            this.btn_update_instructor.TabIndex = 1;
            this.btn_update_instructor.Text = "Update";
            this.btn_update_instructor.UseVisualStyleBackColor = false;
            this.btn_update_instructor.Click += new System.EventHandler(this.btn_update_instructor_Click);
            // 
            // tb_instructor_salary
            // 
            this.tb_instructor_salary.Location = new System.Drawing.Point(171, 349);
            this.tb_instructor_salary.Name = "tb_instructor_salary";
            this.tb_instructor_salary.Size = new System.Drawing.Size(133, 22);
            this.tb_instructor_salary.TabIndex = 3;
            // 
            // tb_instructor_name
            // 
            this.tb_instructor_name.Location = new System.Drawing.Point(12, 349);
            this.tb_instructor_name.Name = "tb_instructor_name";
            this.tb_instructor_name.Size = new System.Drawing.Size(133, 22);
            this.tb_instructor_name.TabIndex = 4;
            // 
            // tb_instructor_department_id
            // 
            this.tb_instructor_department_id.Location = new System.Drawing.Point(329, 349);
            this.tb_instructor_department_id.Name = "tb_instructor_department_id";
            this.tb_instructor_department_id.Size = new System.Drawing.Size(133, 22);
            this.tb_instructor_department_id.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Department ID";
            // 
            // btn_create_instructor
            // 
            this.btn_create_instructor.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_create_instructor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_instructor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_create_instructor.Location = new System.Drawing.Point(532, 330);
            this.btn_create_instructor.Name = "btn_create_instructor";
            this.btn_create_instructor.Size = new System.Drawing.Size(125, 41);
            this.btn_create_instructor.TabIndex = 9;
            this.btn_create_instructor.Text = "Create";
            this.btn_create_instructor.UseVisualStyleBackColor = false;
            this.btn_create_instructor.Click += new System.EventHandler(this.btn_create_instructor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_create_instructor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_instructor_department_id);
            this.Controls.Add(this.tb_instructor_name);
            this.Controls.Add(this.tb_instructor_salary);
            this.Controls.Add(this.btn_update_instructor);
            this.Controls.Add(this.dgv_instructors);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_instructors;
        private System.Windows.Forms.Button btn_update_instructor;
        private System.Windows.Forms.TextBox tb_instructor_salary;
        private System.Windows.Forms.TextBox tb_instructor_name;
        private System.Windows.Forms.TextBox tb_instructor_department_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_create_instructor;
    }
}

