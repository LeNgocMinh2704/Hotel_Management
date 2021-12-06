using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class UC_CustomerDetails : UserControl
    {
        Fc fn = new Fc();
        string query;
        public UC_CustomerDetails()
        {
            
            InitializeComponent();
        }

        private void ComboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSearchBy.SelectedIndex == 0)
            {
                query = "select customers.cid,customers.cname,customers.mobie,customers.nationalily,customers.gender,customers.dob,customers.idproof,customers.address,customers.checkin,customers.checkout,rooms.roomNo from customers inner join rooms on customers.roomid=rooms.roomid";
                DataSet ds = fn.GetData(query);
                DataGridViewCustomer.DataSource = ds.Tables[0];
            }
            else if (ComboBoxSearchBy.SelectedIndex == 1)
            {
                query = "select customers.cid,customers.cname,customers.mobie,customers.nationalily,customers.gender,customers.dob,customers.idproof,customers.address,customers.checkin,customers.checkout,rooms.roomNo from customers inner join rooms on customers.roomid=rooms.roomid where checkout is null";
                DataSet ds = fn.GetData(query);
                DataGridViewCustomer.DataSource = ds.Tables[0];
            }
            else if (ComboBoxSearchBy.SelectedIndex == 2)
            {
                query = "select customers.cid,customers.cname,customers.mobie,customers.nationalily,customers.gender,customers.dob,customers.idproof,customers.address,customers.checkin,customers.checkout,rooms.roomNo from customers inner join rooms on customers.roomid=rooms.roomid where checkout is not null";
                DataSet ds = fn.GetData(query);
                DataGridViewCustomer.DataSource = ds.Tables[0];
            }
        }

        private void DataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
