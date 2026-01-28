using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace ADOLec02
{
    public partial class Form1 : Form
    {
        DataTable dt;
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            dt = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_update.Visible = false;
            //define connection



            //define selecet command

            SqlCommand cmd = new SqlCommand("select * from topic", con);

            //define data adapter   

            SqlDataAdapter adabter = new SqlDataAdapter();
            adabter.SelectCommand = cmd;




            //define data table 

            



            // fill adabter
            adabter.Fill(dt);

            dgv_topic.DataSource = dt;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["top_id"] = txt_id.Text;
            dr["top_name"] = txt_name.Text;
            dt.Rows.Add(dr);


            txt_id.Text = txt_name.Text = "";
        }

        private void dgv_topic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = dgv_topic.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = dgv_topic.SelectedRows[0].Cells[1].Value.ToString();
            txt_id.Enabled = false;
            btn_add.Visible = false;
            btn_update.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);

            foreach (DataRow dr in dt.Rows)
            {
                if ((int)dr["top_id"] == id)
                {
                    dr["top_name"] = txt_name.Text;
                    
                }
            }

            txt_id.Enabled = true;
            btn_add.Visible = true;
            btn_update.Visible = false;


            txt_id.Text = txt_name.Text = "";
            lbl_updateStatus.Text = "Topic updated Successfully!";





        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            //foreach(DataRow row in dt.Rows)
            //{
            //    Debug.WriteLine(row.RowState);
            //}
            SqlCommand insertCmd = new SqlCommand("insert into topic values(@id,@name)", con);
            insertCmd.Parameters.Add("id", SqlDbType.Int, 4, "top_id");
            insertCmd.Parameters.Add("name", SqlDbType.NVarChar, 50, "top_name");


            SqlCommand updateCmd = new SqlCommand("update topic set top_name=@name where top_id=@id", con);
            updateCmd.Parameters.Add("id", SqlDbType.Int, 4, "top_id");
            updateCmd.Parameters.Add("name", SqlDbType.NVarChar, 50, "top_name");

            SqlCommand deleteCmd = new SqlCommand("delete from topic where top_id=@id", con);
            deleteCmd.Parameters.Add("id", SqlDbType.Int, 4, "top_id");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = insertCmd;
            adapter.UpdateCommand = updateCmd;
            adapter.DeleteCommand = deleteCmd;


            adapter.Update(dt);
            MessageBox.Show("Changes Saved Successfully in database!");



        }
    }
}
