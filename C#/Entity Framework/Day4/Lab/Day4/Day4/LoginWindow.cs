using Day4.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Day4
{
    public partial class LoginWindow : Form
    {
        bool eyeImageOpen = false;
        StartWindow startWindow;
        Context _dbContext;
        public LoginWindow(StartWindow startWindow)
        {
            InitializeComponent();
            this.startWindow = startWindow;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (eyeImageOpen == true)
            {
                pbx_Eye.Image = Properties.Resources.eyeOpened;
                tbx_Password.UseSystemPasswordChar = true;
            }
            else
            {
                pbx_Eye.Image = Properties.Resources.eyeClosed;
                tbx_Password.UseSystemPasswordChar = false;
            }
            eyeImageOpen = !eyeImageOpen;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            _dbContext = new Context();
            Author user = _dbContext.Authors.FirstOrDefault(a => a.Email == tbx_Email.Text && a.Password == tbx_Password.Text);
            if(user == null)
            {
                MessageBox.Show("Email or Password is not true");
            }
            else
            {
                this.FormClosed -= startWindow.RegisterWindowClosed;
                HomeWindow homeWindow = new HomeWindow(startWindow, user,_dbContext);
                homeWindow.FormClosed += startWindow.RegisterWindowClosed;
                homeWindow.Show();
                this.Close();
            }
        }
    }
}
