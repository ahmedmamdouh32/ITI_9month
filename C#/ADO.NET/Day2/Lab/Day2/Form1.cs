using System;
using System.Windows.Forms;
namespace Day1
{
    public partial class Form1 : Form
    {
        public int? instructorId { set; get; }
       
        public Form1()
        {
            InitializeComponent();
            LoadAllInstructors();
            LoadAllDeparments();
        }

        private void LoadAllDeparments()
        {
            cb_instructor_department_name.DataSource = BusinessLogicLayer.getAllDepartments();
            cb_instructor_department_name.ValueMember = "dept_id";
            cb_instructor_department_name.DisplayMember = "dept_name";
            cb_instructor_department_name.Text = null;
        }

        private void LoadAllInstructors()
        {
            dgv_instructors.DataSource = BusinessLogicLayer.getAllInstructors();
        }

        private void dgv_instructors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DialogResult result = MessageBox.Show("Are You Sure", "Delete Instructor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                BusinessLogicLayer.deleteInstructor((int)dgv_instructors.SelectedRows[0].Cells[0].Value);
                LoadAllInstructors(); //to get latest content
            }
        }

        private void dgv_instructors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_instructor_name.Text = dgv_instructors.SelectedRows[0].Cells["ins_name"].Value.ToString();
            tb_instructor_salary.Text = dgv_instructors.SelectedRows[0].Cells["salary"].Value.ToString();
            cb_instructor_department_name.Text = dgv_instructors.SelectedRows[0].Cells["dept_name"].Value.ToString();
            instructorId = int.Parse(dgv_instructors.SelectedRows[0].Cells["ins_id"].Value.ToString());
        }

        private void btn_update_instructor_Click(object sender, EventArgs e)
        {
            if (tb_instructor_name.Text == "" || tb_instructor_salary.Text == "" || cb_instructor_department_name.Text == "" || instructorId==null)
            {
                MessageBox.Show("Select Instructor first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result =  MessageBox.Show("Are You Sure", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {

                    BusinessLogicLayer.updateInstructor(id: instructorId, name: tb_instructor_name.Text,salary: Convert.ToDouble(tb_instructor_salary.Text), dept_id: Convert.ToInt32(cb_instructor_department_name.SelectedValue));
                    instructorId = null;
                    LoadAllInstructors(); //to get latest content           
                }
            }
        }

        private void btn_create_instructor_Click(object sender, EventArgs e)
        {
            if (tb_instructor_name.Text == "" || tb_instructor_salary.Text == "" || cb_instructor_department_name.Text == "")
            {
                MessageBox.Show("Fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    BusinessLogicLayer.createInstructor(name: tb_instructor_name.Text, salary: Convert.ToDouble(tb_instructor_salary.Text), dept_id: Convert.ToInt32(cb_instructor_department_name.SelectedValue));
                    LoadAllInstructors(); //to get latest content           
                }
            }
        }
    }
}
