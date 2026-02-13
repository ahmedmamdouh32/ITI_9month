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
    public partial class UserProfileWindow : Form
    {
        Author user;
        Context _dbContext;
        public UserProfileWindow(Author user,Context _dbContext)
        {
            InitializeComponent();
            this.user = user;
            this._dbContext = _dbContext;
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

        private void UserProfileWindow_Load(object sender, EventArgs e)
        {
            tbx_FullName.Text = user?.Name;
            tbx_Age.Text = user?.Age.ToString();
            tbx_PhoneNumber.Text = user?.PhoneNumber;
            tbx_YourExperience.Text = user?.Bio;
            tbx_Address.Text = user?.Address;
            tbx_Username.Text = user?.Username;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbx_Username.Text) || string.IsNullOrWhiteSpace(tbx_FullName.Text))
            {
                MessageBox.Show("Name and Username are Mandatory !!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure", "Update Author", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    user.Name = tbx_FullName.Text;
                    user.Age = Convert.ToInt32(tbx_Age.Text);
                    user.PhoneNumber = tbx_PhoneNumber.Text;
                    user.Bio = tbx_YourExperience.Text;
                    user.Address = tbx_Address.Text;
                    user.Username = tbx_Username.Text;
                    _dbContext.SaveChanges();
                }
            }
                


        }
    }
}
