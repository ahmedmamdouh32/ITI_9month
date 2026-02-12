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

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow(this);
            registerWindow.FormClosed += RegisterWindowClosed;
            this.Hide();
            registerWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
