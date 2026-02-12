using Day4.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging.Effects;
using System.Text;
using System.Windows.Forms;

namespace Day4
{
    public partial class RegisterWindow : Form
    {
        StartWindow startWindow;
        public void RegisterWindowClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        public RegisterWindow(StartWindow startWindow)
        {
            InitializeComponent();
            this.startWindow = startWindow;
        }

        private void RegisterWindow_Load(object sender, EventArgs e)
        {
            tbx_FullName.Text = sharedAuthor.Author.Name;
            tbx_Age.Text = Convert.ToString(sharedAuthor.Author.Age);
            tbx_YourExperience.Text = sharedAuthor.Author.Bio;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_FullName.Text == "")
            {
                MessageBox.Show("Your Name is Mandatory");
            }
            else
            {
                sharedAuthor.Author.Name = tbx_FullName.Text;
                if (string.IsNullOrWhiteSpace(tbx_Age.Text))
                {
                    sharedAuthor.Author.Age = null;
                }
                else if (int.TryParse(tbx_Age.Text, out int age))
                {
                    sharedAuthor.Author.Age = age;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Age.");
                }
                sharedAuthor.Author.Bio = tbx_YourExperience.Text;

                RegisterWindow2 registerWindow2 = new RegisterWindow2(startWindow, this);
                registerWindow2.FormClosed += RegisterWindowClosed;
                this.Hide();
                registerWindow2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_YourExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbx_YourExperience_TextChanged(object sender, EventArgs e)
        {
            int textLength = tbx_YourExperience.Text.Length;
            if (textLength < 3000)
            {
                lbl_YourExperienceLength.ForeColor = Color.White;
                lbl_YourExperienceLength.Text = $"{tbx_YourExperience.Text.Length}/3000";
            }
            else
            {
                lbl_YourExperienceLength.ForeColor = Color.Yellow;
                lbl_YourExperienceLength.Text = $"{tbx_YourExperience.Text.Length}/3000";
            }

        }
    }
}
