using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Hotel_Management
{
    class Fc
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "data source = MINH;database=Hotel_Management;integrated security= True";
            return sqlConnection;
        }

        public DataSet GetData(String query)
        {
            SqlConnection sqlConnection = GetConnection();//get data
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = query;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            return ds;
        }

        public void setData(string query, string message) //insert delete update
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("" + message + "'", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SqlDataReader getForCombo(string query)
        {
            SqlConnection sqlConnection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

    }
}
