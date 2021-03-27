using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Prototype
{
    public partial class userPage : Form
    {
        Boolean isClosing = true;
        Boolean isAdmin;
        int selIndex;
        List<UserModel> users = new List<UserModel>();

        public userPage()
        {
            InitializeComponent();
        }

        public userPage(Boolean isAdmin, int selIndex)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.selIndex = selIndex;
            tabControl.SelectedIndex = selIndex;

            if(selIndex == 3)
            {
                if (isAdmin)
                    showNewUserSlide();
                else {
                    newUserBtn.Enabled = false;
                    showExistingUserSlide();
                }
            }

            
        }

        private void showNewUserSlide()
        {
            nameLabel.Visible = true;
            usernameLabel.Visible = true;
            passwordLabel.Visible = true;
            nameText.Visible = true;
            usernameText.Visible = true;
            passwordText.Visible = true;
            adminChk.Visible = true;
            activeChk.Visible = true;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            userList.Visible = false;

            nameText.Focus();
        }

        private void showExistingUserSlide()
        {
            nameLabel.Visible = false;
            usernameLabel.Visible = false;
            passwordLabel.Visible = false;
            nameText.Visible = false;
            usernameText.Visible = false;
            passwordText.Visible = false;
            adminChk.Visible = false;
            activeChk.Visible = false;
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            userList.Visible = true;

            userList.Items.Clear();
            users.Clear();
            getUserDataFromDB();
            putUserDataToGrid();
        }

        private void getUserDataFromDB() {
            String connectionStr = "datasource=localhost;port=3306;username=root;password=;database=prototype;";
            MySqlConnection cnn = new MySqlConnection(connectionStr);

            String query = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(query, cnn);
            command.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                cnn.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserModel user = new UserModel();
                        user.id = reader.GetInt32(0);
                        user.Name = reader.GetString(1);
                        user.Username = reader.GetString(2);
                        user.Password = reader.GetString(3);
                        user.Role = reader.GetString(4);
                        user.Status = reader.GetBoolean(5);

                        users.Add(user);
                    }
                }
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }

            cnn.Close();
        }

        private void putUserDataToGrid()
        {
            for (int idx = 0; idx < users.Count; idx++)
            {
                ListViewItem item = new ListViewItem(users[idx].id.ToString(), idx);
                item.SubItems.Add(users[idx].Name);
                item.SubItems.Add(users[idx].Username);
                item.SubItems.Add((users[idx].Role == "Admin") ? "Yes" : "No");
                item.SubItems.Add((users[idx].Status == true) ? "Yes" : "No");

                userList.Items.Add(item);
            }
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

        private void userPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClosing)
            {
                for (int idx = Application.OpenForms.Count - 1; idx >= 0; idx--)
                {
                    Application.OpenForms[idx].Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            showNewUserSlide();
        }

        private void exUserBtn_Click(object sender, EventArgs e)
        {
            showExistingUserSlide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "")
            {
                MessageBox.Show("Name must be filled", "Input Error");
                nameText.Focus();
            }
            else if (usernameText.Text == "")
            {
                MessageBox.Show("UserName must be filled", "Input Error");
                usernameText.Focus();
            }
            else if (passwordText.Text == "")
            {
                MessageBox.Show("Password must be filled", "Input Error");
                passwordText.Focus();

            }
            else {
                String encryptedpwd;
                byte[] hashBytes = Encoding.UTF8.GetBytes(passwordText.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    hashBytes = md5.ComputeHash(hashBytes);
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (byte b in hashBytes)
                        stringBuilder.Append(b.ToString("X2"));
                    encryptedpwd = stringBuilder.ToString().ToLower();
                }

                String connectionStr = "datasource=localhost;port=3306;username=root;password=;database=prototype;";
                MySqlConnection cnn = new MySqlConnection(connectionStr);

                String query = "insert into users(Name, Username, Password, Role, Status) values('" + nameText.Text + "','" + usernameText.Text + "','" + encryptedpwd + "','" + (adminChk.Checked ? "Admin" : "Investigator") + "'," + activeChk.Checked + ")";
                MySqlCommand command = new MySqlCommand(query, cnn);
                command.CommandTimeout = 60;
                
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();

                DialogResult result = MessageBox.Show("User data stored succesfully.", "New User", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    showExistingUserSlide();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            usernameText.Text = "";
            passwordText.Text = "";
            adminChk.Checked = false;
            activeChk.Checked = false;
            exUserBtn.Focus();
            showExistingUserSlide();
        }
    }
}
