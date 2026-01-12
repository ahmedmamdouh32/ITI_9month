using Task1.models;

namespace Task1
{
    partial class StudentsList
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
            dgv_StudentsList = new DataGridView();
            label1 = new Label();
            txt_Search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_StudentsList).BeginInit();
            SuspendLayout();
            // 
            // dgv_StudentsList
            // 
            dgv_StudentsList.AllowUserToAddRows = false;
            dgv_StudentsList.AllowUserToDeleteRows = false;
            dgv_StudentsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_StudentsList.BackgroundColor = SystemColors.ActiveCaption;
            dgv_StudentsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_StudentsList.Dock = DockStyle.Bottom;
            dgv_StudentsList.ImeMode = ImeMode.Off;
            dgv_StudentsList.Location = new Point(0, 59);
            dgv_StudentsList.Name = "dgv_StudentsList";
            dgv_StudentsList.ReadOnly = true;
            dgv_StudentsList.RowHeadersWidth = 51;
            dgv_StudentsList.Size = new Size(800, 391);
            dgv_StudentsList.TabIndex = 0;
            dgv_StudentsList.CellContentClick += dgv_StudentsList_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(192, 17);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(399, 27);
            txt_Search.TabIndex = 2;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // StudentsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Search);
            Controls.Add(label1);
            Controls.Add(dgv_StudentsList);
            Name = "StudentsList";
            Text = "List of Students";
            ((System.ComponentModel.ISupportInitialize)dgv_StudentsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgv_StudentsList;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private Label label1;
        private TextBox txt_Search;
    }
}