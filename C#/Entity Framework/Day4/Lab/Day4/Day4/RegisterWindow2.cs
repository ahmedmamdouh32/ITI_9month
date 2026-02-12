using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Day4.Entites;
namespace Day4
{
    public partial class RegisterWindow2 : Form
    {
        StartWindow startWindow;
        RegisterWindow registerWindow;
        public RegisterWindow2(StartWindow startWindow, RegisterWindow registerWindow)
        {
            InitializeComponent();
            this.startWindow = startWindow;
            this.registerWindow = registerWindow;
        }

        private void RegisterWindow2_Load(object sender, EventArgs e)
        {
            tbx_Email.Text = sharedAuthor.Author.Email;
            tbx_PhoneNumber.Text = sharedAuthor.Author.PhoneNumber;
            tbx_Password.Text = "";
            tbx_ConfirmPassword.Text = "";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            sharedAuthor.Author.Email = tbx_Email.Text;
            sharedAuthor.Author.PhoneNumber = tbx_PhoneNumber.Text;
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_Email.Text))
            {
                MessageBox.Show("Email is Mandatory");
            }
            else if(string.IsNullOrWhiteSpace(tbx_Password.Text) || string.IsNullOrWhiteSpace(tbx_ConfirmPassword.Text))
            {
                MessageBox.Show("Password is Mandatory");
            }
            else if (tbx_Password.Text != tbx_ConfirmPassword.Text)
            {
                MessageBox.Show("Passwords are not matching");
            }
            else
            {
                sharedAuthor.Author.Email = tbx_Email.Text;
                Context _dbContext = new Context();
                if (_dbContext.Authors.Where(a => a.Email == sharedAuthor.Author.Email).Count() > 0)
                {
                    MessageBox.Show("this email is reserved before");
                }
                else
                {
                    sharedAuthor.Author.PhoneNumber = tbx_PhoneNumber.Text;
                    sharedAuthor.Author.Password = tbx_ConfirmPassword.Text;
                    _dbContext.Authors.Add(sharedAuthor.Author);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Author Added Successfully", "Successfull Process", MessageBoxButtons.OK);
                    this.FormClosed -= registerWindow.RegisterWindowClosed;
                    registerWindow.FormClosed -= startWindow.RegisterWindowClosed;
                    startWindow.Show();     // Go back to start
                    registerWindow.Close();   // Close intermediate window
                    this.Close();
                }
            }
        }
    }
}
