using Day3.Models;
using System.Windows.Forms;

namespace Day3
{
    public partial class Form1 : Form
    {
        db34477Context db;
        int? selectedId = null;
        public Form1()
        {
            InitializeComponent();
            db = new db34477Context();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmb_departments.DataSource = db.Departments.ToList();
            cmb_departments.ValueMember = "Dept_Id";
            cmb_departments.DisplayMember = "Dept_Name";


            dgv_students.DataSource = db.Students.Select(s =>
            new
            {
                ID = s.St_Id,
                Name = $"{s.St_Fname} {s.St_Lname}",
                Address = s.St_Address,
                Department = s.Dept.Dept_Name

            }).ToList();
            dgv_students.Columns["ID"]?.Visible = false;


        }

       

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (txt_name.Text.ToArray().Length > 1)
            {
                student.St_Fname = txt_name.Text.Split(" ")[0];
                student.St_Lname = txt_name.Text.Split(" ")[1];
            }
            else
            {
                student.St_Fname = txt_name.Text;
                student.St_Lname = null;
            }

            student.St_Address = txt_address.Text ?? "not found";
            student.Dept_Id = (int?)cmb_departments.SelectedValue;

            db.Students.Add(student);
            db.SaveChanges();
            txt_address.Text = "";
            txt_name.Text = "";
            dgv_students.DataSource = db.Students.Select(s =>
                       new
                       {
                           ID = s.St_Id,
                           Name = $"{s.St_Fname} {s.St_Lname}",
                           Address = s.St_Address,
                           Department = s.Dept.Dept_Name
                       }).ToList();
            MessageBox.Show("Student Added Successfully");
        }

        private void button2_Click(object sender, EventArgs e) //delete button
        {
            if (selectedId != null)
            {
                Student st = db.Students.Where(st => st.St_Id == selectedId).SingleOrDefault();
                db.Students.Remove(st);
                db.SaveChanges();

                dgv_students.DataSource = db.Students.Select(s =>
                      new
                      {
                          ID = s.St_Id,
                          Name = $"{s.St_Fname} {s.St_Lname}",
                          Address = s.St_Address,
                          Department = s.Dept.Dept_Name
                      }).ToList();
                MessageBox.Show($"Student id Deleted Successfully");
                selectedId = null;
            }
        }

        private void dgv_students_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgv_students.SelectedRows[0]?.Cells["Name"]?.Value?.ToString() == "")
            {
                txt_name.Text = "not set";
            }
            else
            {
                txt_name.Text = dgv_students.SelectedRows[0]?.Cells["Name"]?.Value?.ToString() ?? "no address";
            }
            if (dgv_students.SelectedRows[0]?.Cells["Address"]?.Value?.ToString() == "")
            {
                txt_address.Text = "not set";
            }
            else
            {
                txt_address.Text = dgv_students.SelectedRows[0]?.Cells["Address"]?.Value?.ToString() ?? "no address";
            }

            cmb_departments.Text = dgv_students.SelectedRows[0].Cells["Department"].Value.ToString();
            selectedId = (int)dgv_students.SelectedRows[0]?.Cells["ID"]?.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = db.Students.Where(s => s.St_Id == selectedId).SingleOrDefault();
            if (st != null)
            {
                st.St_Lname = null;
                st.St_Fname = txt_name.Text;
                st.St_Address = txt_address.Text;
                st.Dept_Id = (int?)cmb_departments.SelectedValue;

                db.SaveChanges();
                dgv_students.DataSource = db.Students.Select(s =>
                          new
                          {
                              ID = s.St_Id,
                              Name = $"{s.St_Fname} {s.St_Lname}",
                              Address = s.St_Address,
                              Department = s.Dept.Dept_Name
                          }).ToList();
                MessageBox.Show("Student Updated Successfully");
            }
        }
    }
}
