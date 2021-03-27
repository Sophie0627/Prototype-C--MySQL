using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class dashboardPage : Form
    {
        Boolean isAdmin;
        Boolean isClosing = true;
        public dashboardPage()
        {
            InitializeComponent();
        }

        public dashboardPage(String username, Boolean isAdmin)
        {
            InitializeComponent();
            welcomeText.Text = "Welcome  " + username;
            this.isAdmin = isAdmin;
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isClosing = false;

            for (int idx = Application.OpenForms.Count - 1; idx >= 0; idx--)
            {
                if (Application.OpenForms[idx].Name == "loginPage")
                {
                    Application.OpenForms[idx].Show();
                }
            }
            this.Close();
        }

        private void Manageuser_Click(object sender, EventArgs e)
        {
            isClosing = false;

            userPage adminPage = new userPage(isAdmin, 3);
            adminPage.Show();
            this.Close();
        }

        private void Managesoftware_Click(object sender, EventArgs e)
        {
            isClosing = false;

            userPage adminPage = new userPage(isAdmin, 2);
            adminPage.Show();
            this.Close();
        }

        private void dashboardPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClosing)
            {
                for (int idx = Application.OpenForms.Count - 1; idx >= 0; idx--)
                {
                   Application.OpenForms[idx].Close();
                }
            }
        }
    }
}
