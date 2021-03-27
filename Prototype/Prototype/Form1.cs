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
    public partial class loginPage : Form
    {
        Boolean isConnected_DB = false;
        
        public loginPage()
        {
            InitializeComponent();
            String connectionStr;
            connectionStr = "datasource=localhost;port=3306;username=root;password=;database=prototype;";
            MySqlConnection cnn = new MySqlConnection(connectionStr);
            cnn.Open();
            if (cnn.State == ConnectionState.Open)
            {
                isConnected_DB = true;
                cnn.Close();
            }
                
            else isConnected_DB = false;

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameInput.Text;
            String password = passwordInput.Text;
            String encryptedpwd = "";

            if (username == "")
            {
                MessageBox.Show("Username is required.", "Input Error");
                usernameInput.Focus();
            }
            else if (password == "") { 
                MessageBox.Show("Password is required.", "Input Error");
                passwordInput.Focus();
            }
            else
            {
                byte[] hashBytes = Encoding.UTF8.GetBytes(password);
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

                String query = "SELECT Username, Password, Status, Role FROM users WHERE Username = @username";
                MySqlCommand command = new MySqlCommand(query, cnn);
                command.Parameters.AddWithValue("@username", username);
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
                            String pwd = reader.GetString(1);
                            
                            if (pwd != encryptedpwd)
                            {
                                MessageBox.Show("Password is incorrect", "Password not match");
                                passwordInput.Text = "";
                                passwordInput.Focus();
                            }
                            else {
                                Boolean state = reader.GetBoolean(2);
                                if (!state)
                                {
                                    MessageBox.Show("This account is not disabled. Please contact the administrator.", "Account disabled");
                                    LoginBtn.Focus();
                                }
                                else {
                                    String role = reader.GetString(3);
                                    Boolean isAdmin = false;
                                    if (role == "Admin") isAdmin = true;

                                    this.Hide();
                                    dashboardPage dashboard = new dashboardPage(username, isAdmin);
                                    dashboard.Show();
                                    
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username is unregistered.", "Username not exist");
                        usernameInput.Text = "";
                        usernameInput.Focus();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void loginPage_Shown(object sender, EventArgs e)
        {
            if (!isConnected_DB) {
                DialogResult result = MessageBox.Show("Failed to connect to Database", "DB_Connection", MessageBoxButtons.OK);
                if (result == System.Windows.Forms.DialogResult.OK)
                    this.Close();
            }

            usernameInput.Focus();
        }

    }
}
