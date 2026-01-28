using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOLec02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //DataTable dt = DBLayer.select("select * from topic");

            dgv_topic.DataSource = BuissinessLogic.getAll();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //string command = $"insert into topic values({txt_id.Text},'{txt_name.Text}')";

            //int affectedRows = DBLayer.DML(command);


            int affectedRows = BuissinessLogic.addTopic(int.Parse(txt_id.Text), txt_name.Text);

            if (affectedRows > 0)
            {
                dgv_topic.DataSource = BuissinessLogic.getAll();
                txt_id.Text = txt_name.Text = "";   
            }
            
     
        }
    }
}
