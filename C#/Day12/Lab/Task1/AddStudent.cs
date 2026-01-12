using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task1
{
    public partial class AddStudent : Form
    {
        MainForm ParentPage; //MainForm
        public AddStudent(MainForm parentPage)
        {
            InitializeComponent();
            ParentPage = parentPage;
        }
        string[] departments = { "HR", "IT", "Finance" };

       
    }
}
