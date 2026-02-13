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
    public partial class HomeWindow : Form
    {
        StartWindow startWindow;
        Author author;
        Context _dbContext;
        public HomeWindow(StartWindow startWindow, Author author, Context _dbContext)
        {
            InitializeComponent();
            this.startWindow = startWindow;
            this.author = author;
            this._dbContext = _dbContext;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void UserProfile_Click(object sender, EventArgs e)
        {

            UserProfileWindow userProfile = new UserProfileWindow(author, _dbContext);
            userProfile.FormClosed += (e, args) => this.Show();
            this.Hide();
            userProfile.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookWindow AddBook= new AddBookWindow(author,_dbContext);
            AddBook.FormClosed += (e, args) => this.Show();
            this.Hide();
            AddBook.Show();
        }

    }
}
