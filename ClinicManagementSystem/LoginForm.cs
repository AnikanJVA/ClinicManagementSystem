using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = button1;
            this.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Username and Password must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = UsernameTextBox.Text.Trim();
                string password = PasswordTextBox.Text;

                if (Database.AuthenticateUser(username, password))
                {
                    MessageBox.Show("Login Successful!", "Success");

                    switch (Database.GetUserAccType(username, password).ToUpper())
                    {
                        case "ADMIN":
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();
                            break;

                        case "DOCTOR":
                            DocView docView = new DocView();
                            docView.Show();
                            this.Hide();
                            break;

                        case "RECEPTIONIST":
                            RecepView recepView = new RecepView();
                            recepView.Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        public sealed class Database
        {
            private static readonly Lazy<Database> instance = new Lazy<Database>(() => new Database());
            private MySqlConnection connection;

            private Database()
            {
                string connectionString = "server=localhost;database=dentalclinic;user=root;password=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }

            public static Database Instance => instance.Value;

            public MySqlConnection Connection
            {
                get
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    return connection;
                }
            }

            
            public static bool AuthenticateUser(string username, string password)
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = SHA2(@password, 256) AND status = 'ACTIVE'";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }

            public static bool AddUser(string username, string password, string accType)
            {
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND accType = @accType AND status = 'ACTIVE'";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, Instance.connection))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@accType", accType);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        return false;
                    }
                }
                string insertQuery = "INSERT INTO users (username, password, accType) VALUES (@username, SHA2(@password, 256), @accType)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@accType", accType);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }


            public static bool DeleteUser(string username, string accType)
            {
                string updateQuery = "UPDATE users SET status = 'inactive' WHERE username = @username AND accType = @accType";
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, Instance.connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@accType", accType);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }


            public static string GetUserAccType(string username, string password)
            {
                string query = "SELECT accType FROM users WHERE username = @username AND password = SHA2(@password, 256) LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }

                    return null;
                }
            }


            public static DataTable GetUsers()
            {
                string query = "SELECT Username, accType AS AccountType FROM users WHERE status = 'active' AND accType <> 'admin'";
                using (MySqlCommand cmd = new MySqlCommand(query, Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }

            
        }

        // TODO: database class and methods
    }
}
