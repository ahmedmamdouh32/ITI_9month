using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADOLec02
{
    internal class DBLayer
    {
        public static DataTable select(string cmd)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            
            SqlCommand command = new SqlCommand(cmd, connection);



            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;

        }


        public static int DML(string cmd)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            return affectedRows;
        }


    }
}
