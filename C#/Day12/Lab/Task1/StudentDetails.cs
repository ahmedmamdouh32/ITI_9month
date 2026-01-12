using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Task1.models;

namespace Task1
{
    public partial class StudentDetails : Form
    {

        Student student;
        StudentsList parentForm;
        public StudentDetails(Student _st, StudentsList parent)
        {
            InitializeComponent();
            student = _st;
            parentForm = parent;
            lbl_Name.Text = _st.Name;
            lbl_ID.Text = _st.Id.ToString();
            lbl_Department.Text = _st.Department;
            lbl_Gender.Text = _st.Gender == Gender.male ? "Male" : "Female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StudentRepository.removeStudentById(student.Id);
                MessageBox.Show("Student deleted successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                parentForm.dgv_StudentsList.DataSource = null;
                parentForm.dgv_StudentsList.DataSource = StudentRepository.getStudents();
                this.Close();
            }
        }
    }
}
