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
    public partial class LoginForm : Form
    {
        Fc fn = new Fc();
        string query;
        public LoginForm()
        {
            InitializeComponent();
        }
        void clear()
        {
            TextBoxRegUsername.Text = TextBoxRegPassword.Text = TextBoxRegConfirmPassword.Text = "";
        }
        public void clear1()
        {
            UsernameInput.Text = Password.Text = "";
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

        

        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.User != string.Empty)
            {
                ToggleSwitchRemember.Checked = true;
                UsernameInput.Text = Properties.Settings.Default.User;
                Password.Text = Properties.Settings.Default.Password;
            }

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            ShadowPanelRegister.Visible = true;
            ShadowPanelLogin.Hide();
            ShadowPanelRegister.BringToFront();
        }

        private void LoginNow_Click(object sender, EventArgs e)
        {
            ShadowPanelRegister.Hide();
            ShadowPanelLogin.Show();
        }

        private void CLoseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     

        private void ShowPassReg_Click(object sender, EventArgs e)
        {
            ShowPassReg.Hide();
            TextBoxRegPassword.UseSystemPasswordChar = true;
            HidePassReg.Show();
        }

        private void HidePassReg_Click(object sender, EventArgs e)
        {
            HidePassReg.Hide();
            TextBoxRegPassword.UseSystemPasswordChar = false;
            ShowPassReg.Show();
        }

        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            query = "select username,password from account where username='" + UsernameInput.Text + "'";
            SqlDataReader sqlDataReader = fn.getForCombo(query);

            if (sqlDataReader.Read() == true)
            {
                if (ToggleSwitchRemember.Checked == true)
                {
                    Properties.Settings.Default.User = UsernameInput.Text;
                    Properties.Settings.Default.Password = Password.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.User = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }
                lableError.Visible = false;
                Management management = new Management();
                this.Hide();
                management.Show();
                clear1();
            }
            else
            {
                lableError.Visible = true;
                Password.Clear();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            query = "select username from account where username='" + TextBoxRegUsername.Text + "'";
            SqlDataReader sqlDataReader = fn.getForCombo(query);
            if (sqlDataReader.Read() == true)
            {
                MessageBox.Show("Account already exisct");

            }
            else
            if (TextBoxRegUsername.Text == "" || TextBoxRegPassword.Text == "")
                MessageBox.Show("Please fill in all filds");
            else if (TextBoxRegConfirmPassword.Text != TextBoxRegPassword.Text)
                MessageBox.Show("Password do not match");
            else
            {
                string us = TextBoxRegUsername.Text;
                string ps = TextBoxRegPassword.Text;
                query = "insert into account values ('" + us + "','" + ps + "')";
                fn.setData(query, "Registrtion account successful");
                clear();
            }
        }
    }
}
