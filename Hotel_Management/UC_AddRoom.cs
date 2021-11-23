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
    public partial class UC_AddRoom : UserControl
    {
        Fc fn = new Fc();
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.GetData(query);
            DataGridViewAddRoom.DataSource = ds.Tables[0];
        }
        public void clear()
        {
            TextBoxRoomID.Clear();
            TextBoxRoomNumber.Clear();
            ComboBoxRoomType.SelectedIndex = -1;
            ComboBoxBed.SelectedIndex = -1;
            TextBoxPrice.Clear();
        }
        private void ButtonAddRoom_Click(object sender, EventArgs e)
        {
            if (TextBoxRoomID.Text != "" && TextBoxRoomNumber.Text != ""
                && ComboBoxRoomType.Text != "" && ComboBoxBed.Text != ""
                && TextBoxPrice.Text != "")
            {
                string roomid = TextBoxRoomID.Text;
                string roomno = TextBoxRoomNumber.Text;
                string type = ComboBoxRoomType.Text;
                string bed = ComboBoxBed.Text;
                Int64 price = Int64.Parse(TextBoxPrice.Text);
                query = "insert into rooms (roomid,roomNo,roomType,bed,price) " +
                    "values ('" + roomid + "','" + roomno + "','" + type + "','" + bed + "'," + price + ")";
                fn.setData(query, "Room Added.");
                UC_AddRoom_Load(this, null);
                clear();
            }
            else
            {
                MessageBox.Show("Please fill in all field.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "roomNo", "*" + SearchBox.Text + "*");
            (DataGridViewAddRoom.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
