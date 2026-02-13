using Day4.Entites;

namespace Day4
{
    public partial class StartWindow : Form
    {
        public void RegisterWindowClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        public StartWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow(this);
            registerWindow.FormClosed += RegisterWindowClosed;
            this.Hide();
            registerWindow.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(this);
            loginWindow.FormClosed += RegisterWindowClosed;
            this.Hide();
            loginWindow.Show();

        }

        private void StartWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
