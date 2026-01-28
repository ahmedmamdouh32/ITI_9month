using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal static class DBLayer
    {
        static private SqlConnection connection = new SqlConnection();
        static private SqlCommand command = new SqlCommand();
        static DBLayer()
        {
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["DBConStr"].ConnectionString;
            command.Connection = connection;
        }

        public static DataTable Select(string cmd)
        {
            command.CommandText = cmd;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static int Delete(string cmd, int id)
        {
            command.CommandText = cmd;
            command.Parameters.AddWithValue("id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return affectedRows;
        }

        public static int Update(string cmd, int? id, string name, double salary, int dept_id)
        {
            command.CommandText = cmd;
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("salary", salary);
            command.Parameters.AddWithValue("dept_id", dept_id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return affectedRows;
        }

        public static int Create(string cmd, string name, double salary, int dept_id)
        {
            
            command.CommandText = cmd;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("salary", salary);
            command.Parameters.AddWithValue("dept_id", dept_id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return affectedRows;
        }



    }
}
