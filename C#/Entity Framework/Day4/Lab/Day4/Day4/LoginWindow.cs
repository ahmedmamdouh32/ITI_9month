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
        public LoginWindow(StartWindow startWindow)
        {
            InitializeComponent();
            this.startWindow = startWindow;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (eyeImageOpen == true)
            {
                pbx_Eye.ImageLocation = "C:\\Users\\adminstrator\\Documents\\ITI_9Months\\C#\\Entity Framework\\Day4\\Lab\\Day4\\Day4\\Properties\\resources\\eyeOpened.png";
                tbx_Password.UseSystemPasswordChar = true;
            }
            else
            {
                pbx_Eye.ImageLocation = "C:\\Users\\adminstrator\\Documents\\ITI_9Months\\C#\\Entity Framework\\Day4\\Lab\\Day4\\Day4\\Properties\\resources\\eyeColsed.png";
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
            Context _dbContext = new Context();
            if(_dbContext.Authors.Where(a=> a.Email==tbx_Email.Text && a.Password == tbx_Password.Text).Count() == 1)
            {
                MessageBox.Show("user found");
            }
            else
            {
                MessageBox.Show("user not found");
            }
        }
    }
}
