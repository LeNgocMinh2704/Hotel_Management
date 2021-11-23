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
    public partial class UC_AddUser : UserControl
    {
        Fc fn = new Fc();
        string query;

        public UC_AddUser()
        {
            InitializeComponent();
        }
        public void setComboBox(string query, ComboBox comboBox)
        {
            SqlDataReader sqlDataReader = fn.getForCombo(query);
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    comboBox.Items.Add(sqlDataReader.GetString(i));
                }
            }
            sqlDataReader.Close();
        }

        private void ComboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxRoomNumber.Items.Clear();
            TextBoxPrice.Clear();
            query = "select roomNo from rooms where bed ='" + ComboBoxBed.Text + "' and roomType='" + ComboBoxRoomType.Text + "'and booked= 'NO' ";
            setComboBox(query, ComboBoxRoomNumber);
        }

        private void ComboBoxBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxRoomType.SelectedIndex = -1;
            ComboBoxRoomNumber.Items.Clear();
            TextBoxPrice.Clear();

        }
        int rid;
        private void ComboBoxRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo='" + ComboBoxRoomNumber.Text + "'";
            DataSet dataSet = fn.GetData(query);
            TextBoxPrice.Text = dataSet.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(dataSet.Tables[0].Rows[0][1].ToString());
        }
        public void Clear()
        {
            TextBoxRoomId.Clear();
            TextBoxName.Clear();
            TextBoxMobile.Clear();
            TextBoxNationality.Clear();
            ComboBoxGender.SelectedIndex = -1;
            dateTimePickerDOB.ResetText();
            TextBoxIDP.Clear();
            TextBoxAddress.Clear();
            dateTimePickerCheckIn.ResetText();
            ComboBoxBed.SelectedIndex = -1;
            ComboBoxRoomNumber.Items.Clear();
            ComboBoxRoomType.SelectedIndex = -1;
            TextBoxPrice.Clear();
        }
        private void ButtonAlloteRoom_Click(object sender, EventArgs e)
        {
            if (TextBoxRoomId.Text != "" && TextBoxName.Text != "" && TextBoxMobile.Text != ""
                && TextBoxNationality.Text != "" && ComboBoxGender.Text != ""
                && dateTimePickerDOB.Text != "" && TextBoxIDP.Text != ""
                && TextBoxAddress.Text != "" && dateTimePickerCheckIn.Text != "" && TextBoxPrice.Text != "")
            {
                Int64 id = Int64.Parse(TextBoxRoomId.Text);
                string name = TextBoxName.Text;
                Int64 mobie = Int64.Parse(TextBoxMobile.Text);
                string national = TextBoxNationality.Text;
                string gender = ComboBoxGender.Text;
                string dob = dateTimePickerDOB.Text;
                string idproof = TextBoxIDP.Text;
                string address = TextBoxAddress.Text;
                string checkin = dateTimePickerCheckIn.Text;
                query = "insert into customers (cid,cname,mobie,nationalily,gender,dob,idproof,address,checkin,roomid) values ('" + id + "','" + name + "','" + mobie + "','" + national + "','" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + checkin + "'," + rid + ")update rooms set booked = 'YES' where roomNo = '" + ComboBoxRoomNumber.Text + "'";
                fn.setData(query, " Room Number " + ComboBoxRoomNumber.Text + " Allocation Sucessful. ");
                Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all field", "Infomation !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_AddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
