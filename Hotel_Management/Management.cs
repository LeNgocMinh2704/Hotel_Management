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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }
        public void Movepic(Control btn)
        {
            PicSlide.Top = btn.Top;
            PicSlide.Height = btn.Height;
        }
        

        

       

      

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardButton_Click_1(object sender, EventArgs e)
        {
            
            uC_AddRoom1.Hide();
            uC_AddUser1.Hide();
            uC_CustomerDetails1.Hide();
            Movepic(DashboardButton);
            uC_DashBoard1.Visible = true;
            uC_DashBoard1.BringToFront();
            
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Hide();
            uC_CustomerDetails1.Hide();
            Movepic(RoomButton);
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
            uC_AddRoom1.Hide();
            uC_AddRoom1.clear();
            uC_AddRoom1.Show();
            
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.Hide();
            uC_CustomerDetails1.Hide();
            Movepic(ClientButton);
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
            uC_AddUser1.Hide();
            uC_AddUser1.Clear();
            uC_AddUser1.Show();
        }

        

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.Hide();
            uC_AddUser1.Hide();
            uC_CustomerDetails1.Hide();
            Movepic(CheckOutButton);
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();

        }

        private void ClientDetailButton_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.Hide();
            uC_AddUser1.Hide();
            Movepic(ClientDetailButton);
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
            uC_CustomerDetails1.Hide();
            uC_CustomerDetails1.Show();
        }

       

        

        private void Management_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            DateTime dt = DateTime.Now;
            Clock.Text = dt.ToLongDateString();

        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            Movepic(SettingButton);
            uC_Setting1.Visible = true;
            uC_Setting1.BringToFront();
        }

        
    }
}
