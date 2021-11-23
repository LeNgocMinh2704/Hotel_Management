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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowPass_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ShowPass, "Show password");
        }

        private void HidePass_MouseHouver(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(HidePass, "Hide password");
        }
        private void ShowPass_Click(object sender, EventArgs e)
        {
            ShowPass.Hide();
            Password.UseSystemPasswordChar = true;
            HidePass.Show();
        }

        private void HidePass_Click(object sender, EventArgs e)
        {
            HidePass.Hide();
            Password.UseSystemPasswordChar = false;
            ShowPass.Show();
        }

        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Text == "minh" && Password.Text == "123456")
            {

                lableError.Visible = false;
                Management ds = new Management();
                this.Hide();
                ds.Show();
            }
            else
            {
                lableError.Visible = true;
                Password.Clear();
            }
        }
    }
}
