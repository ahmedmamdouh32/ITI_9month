namespace Task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_addStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent(this);
            this.Hide();
            addStudentForm.Show();
        }

        private void btn_studentsList_Click(object sender, EventArgs e)
        {
            StudentsList studentsListForm = new StudentsList();
            studentsListForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sur you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
