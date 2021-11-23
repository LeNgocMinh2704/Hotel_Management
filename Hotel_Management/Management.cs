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
            Movepic(DashboardButton);
            uC_DashBoard1.Visible = true;
            uC_DashBoard1.BringToFront();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            Movepic(RoomButton);
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            Movepic(ClientButton);
            uC_AddUser2.Visible = true;
            uC_AddUser2.BringToFront();
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            Movepic(ReservationButton);
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Movepic(CheckOutButton);
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
            
        }

        private void ClientDetailButton_Click(object sender, EventArgs e)
        {
            Movepic(ClientDetailButton);
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }
    }
}
