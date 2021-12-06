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
    public partial class UC_CheckOut : UserControl
    {
        Fc fn = new Fc();
        string query;
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            query = "select customers.cid,customers.cname,customers.mobie,customers.nationalily,customers.gender,customers.dob,customers.idproof,customers.address,customers.checkin,customers.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customers inner join rooms on customers.roomid=rooms.roomid where chekout ='NO'";
            DataSet ds = fn.GetData(query);
            DataGridViewCheckOut.DataSource = ds.Tables[0];
        }
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select customers.cid,customers.cname,customers.mobie,customers.nationalily,customers.gender,customers.dob,customers.idproof,customers.address,customers.checkin,customers.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customers inner join rooms on customers.roomid = rooms.roomid where cname like'" + TextBoxSearch.Text + "%' and chekout = 'NO'";
            DataSet ds = fn.GetData(query);
            DataGridViewCheckOut.DataSource = ds.Tables[0];
            
        }
        int id;

        private void DataGridViewCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewCheckOut.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(DataGridViewCheckOut.Rows[e.RowIndex].Cells[0].Value.ToString());
                TextBoxNameCheckOut.Text = DataGridViewCheckOut.Rows[e.RowIndex].Cells[1].Value.ToString();
                TextBoxRoomNo.Text = DataGridViewCheckOut.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if (TextBoxNameCheckOut.Text != "")
            {
                string cdate = dateTimePickerCheckOut.Text;
                query = "update customers set chekout = 'YES' ,checkout = '" + cdate + "' where cid = " +id+" update rooms set booked = 'NO' where roomNo = '"+ TextBoxRoomNo.Text+"'";
                fn.setData(query, "Check Out Succesafully.");
                UC_CheckOut_Load(this, null);
                clearAll();

            }
            else
                MessageBox.Show("No customer selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void clearAll()
        {
            TextBoxNameCheckOut.Clear();
            TextBoxSearch.Clear();
            TextBoxRoomNo.Clear();
            dateTimePickerCheckOut.ResetText();
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        
    }
}
