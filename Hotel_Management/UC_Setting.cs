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
namespace Hotel_Management
{
    public partial class UC_Setting : UserControl
    {
        Fc fn = new Fc();
        string query;
        public UC_Setting()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {

            query = "select username from account where username='" + UsernameBox.Text + "'";
            SqlDataReader sqlDataReader = fn.getForCombo(query);
            if (sqlDataReader.Read())
            {
                MessageBox.Show("Check Account Sucess");
                PanelChange.Visible = true;
            }
            else
            {
                MessageBox.Show("Not Match");
            }
        }

        private void ChangeNow_Click(object sender, EventArgs e)
        {
            if (NewPassBox.Text == ConfirmPassBox.Text)
            {
                query = "update account set password='" + NewPassBox.Text + "' where username='" + UsernameBox.Text + "'";
                fn.setData(query, "Password changed");
            }
            else
            {
                MessageBox.Show("Not Match");
            }
        }
    }
}
