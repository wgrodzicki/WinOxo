using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOxo
{
    /// <summary>
    /// Handles the registration of a new user
    /// </summary>
    public partial class FormRegister : Form
    {
        private FormLogin formLogin = new FormLogin();
        private SqlConnection connection;

        public FormRegister(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin; // Get access to the login form
            this.FormClosing += FormRegister_FormClosing; // Make sure the whole app closes when this form is closed
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            // Clear text boxes on each click
            labelLoginWarning.Text = "";
            labelPasswordWarning.Text = "";

            if (!formLogin.CheckLogin(textBoxLogin.Text, labelLoginWarning) || !formLogin.CheckPassword(textBoxPassword.Text, labelPasswordWarning))
            {
                return;
            }

            // Open connection for registration validation
            connection = formLogin.OpenConnection(true, connection);

            int userId = formLogin.ValidateLogin(connection, "reg", textBoxLogin.Text, labelLoginWarning);

            // Do nothing if login invalid
            if (userId >= 0)
            {
                // Close connection
                connection = formLogin.OpenConnection(false, connection);
                return;
            }

            bool passwordValid = formLogin.ValidatePassword(connection, "reg", userId, textBoxPassword.Text, labelPasswordWarning);

            // Close connection
            connection = formLogin.OpenConnection(false, connection);

            // Register if both login and password valid
            if (userId < 0 && passwordValid)
            {
                RegisterUser(textBoxLogin, textBoxPassword);
            }
        }

        /// <summary>
        /// Registers new user in the database
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        private void RegisterUser(TextBox login, TextBox password)
        {
            // Open connection for registering
            connection = formLogin.OpenConnection(true, connection);

            string registerQuery = "SELECT * FROM Users";

            // Get the table
            SqlDataAdapter adapterRegister = new SqlDataAdapter(registerQuery, connection);
            DataSet usersRegisterData = new DataSet();
            adapterRegister.Fill(usersRegisterData, "Users");

            // Insert new user into the table
            string registerQueryInsert = $"INSERT INTO Users (login, password) VALUES ('{login.Text}', '{password.Text}');";
            adapterRegister.InsertCommand = new SqlCommand(registerQueryInsert, connection);
            adapterRegister.InsertCommand.ExecuteNonQuery();
            adapterRegister.Update(usersRegisterData, "Users"); // Save changes to the database

            // Close connection
            connection = formLogin.OpenConnection(false, connection);

            // Display message
            MessageBox.Show("Signed up successfully!");

            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegister_FormClosing(Object sender, FormClosingEventArgs e)
        {
            formLogin.ClearForm();
            formLogin.Show();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
