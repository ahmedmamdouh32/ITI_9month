using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace Day1
{
    public partial class Form1 : Form
    {
        public int? instructorId { set; get; }
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DBConStr"].ConnectionString; //added from references , right click add reference
            LoadAllInstructors();
        }

        private void LoadAllInstructors()
        {
            cmd = new SqlCommand("select ins_id, ins_name, degree, salary, dept_id from Instructor", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List <Instructor> instructors= new List<Instructor>();
            while (dr.Read())
            {
                Instructor instructor = new Instructor();
                instructor.ins_id = (int)dr["ins_id"];
                instructor.ins_name = dr["ins_name"].ToString();
                instructor.salary = (double)dr["salary"];
                instructor.dept_id = (int)dr["dept_id"];
                instructors.Add(instructor);
            }
            dgv_instructors.DataSource = instructors;
            con.Close();
        }
        

        

        private void dgv_instructors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DialogResult result = MessageBox.Show("Are You Sure", "Delete Instructor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                cmd = new SqlCommand("delete from Instructor where ins_id=@id", con);
                cmd.Parameters.AddWithValue("id", dgv_instructors.SelectedRows[0].Cells[0].Value);
                instructorId = null;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LoadAllInstructors(); //to get latest content
            }
        }

        private void dgv_instructors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_instructor_name.Text = dgv_instructors.SelectedRows[0].Cells["ins_name"].Value.ToString();
            tb_instructor_salary.Text = dgv_instructors.SelectedRows[0].Cells["salary"].Value.ToString();
            tb_instructor_department_id.Text = dgv_instructors.SelectedRows[0].Cells["dept_id"].Value.ToString();
            instructorId = int.Parse(dgv_instructors.SelectedRows[0].Cells["ins_id"].Value.ToString());
        }

        private void btn_update_instructor_Click(object sender, EventArgs e)
        {
            if (tb_instructor_name.Text == "" || tb_instructor_salary.Text == "" || tb_instructor_department_id.Text == "" || instructorId==null)
            {
                MessageBox.Show("Select Instructor first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result =  MessageBox.Show("Are You Sure", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    cmd = new SqlCommand("update Instructor set ins_name = @name, salary= @salary, Dept_id=@dept_id where ins_id=@id", con);
                    cmd.Parameters.AddWithValue("id", instructorId);
                    instructorId = null;
                    cmd.Parameters.AddWithValue("name", tb_instructor_name.Text);
                    cmd.Parameters.AddWithValue("salary", Convert.ToDouble(tb_instructor_salary.Text));
                    cmd.Parameters.AddWithValue("dept_id", Convert.ToInt32(tb_instructor_department_id.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadAllInstructors(); //to get latest content           

                }
            }
        }

        private void btn_create_instructor_Click(object sender, EventArgs e)
        {
            if (tb_instructor_name.Text == "" || tb_instructor_salary.Text == "" || tb_instructor_department_id.Text == "")
            {
                MessageBox.Show("Fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    cmd = new SqlCommand("insert into Instructor(ins_name, salary, dept_id ) values(@name, @salary, @dept_id)", con);
                    cmd.Parameters.AddWithValue("name", tb_instructor_name.Text);
                    cmd.Parameters.AddWithValue("salary", Convert.ToDouble(tb_instructor_salary.Text));
                    cmd.Parameters.AddWithValue("dept_id", Convert.ToInt32(tb_instructor_department_id.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadAllInstructors(); //to get latest content           

                }
            }
        }
    }
}
