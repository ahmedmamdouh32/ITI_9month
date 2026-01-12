using Task1.models;

namespace Task1
{
    public partial class StudentsList : Form
    {
        public StudentsList()
        {
            InitializeComponent();
            dgv_StudentsList.DataSource = StudentRepository.getStudents();
            dgv_StudentsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //to select full row

        }

        private void dgv_StudentsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_StudentsList.SelectedRows[0];
            Student st = new Student();
            st.Name = row.Cells["Name"].Value?.ToString();
            st.Id = int.Parse(row.Cells["Id"].Value?.ToString());
            st.Department = row.Cells["Department"].Value?.ToString();
            st.Gender = row.Cells["Gender"].Value?.ToString() == "male" ? Gender.male : Gender.female;
            StudentDetails stdDetails = new StudentDetails(st, this);
            stdDetails.Show();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            List<Student> result = StudentRepository.getStudentByName(txt_Search.Text);
            dgv_StudentsList.DataSource = null;
            dgv_StudentsList.DataSource = result;
        }
    }
}
