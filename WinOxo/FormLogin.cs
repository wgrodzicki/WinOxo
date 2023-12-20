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
using TicTacToe;

namespace WinOxo
{
    /// <summary>
    /// Handles logging in to access the game
    /// </summary>
    public partial class FormLogin : Form
    {
        private SqlConnection connection;
        private int titleOffset = 8;

        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles opening/closing of the database connection
        /// </summary>
        /// <param name="value"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public SqlConnection OpenConnection(bool value, SqlConnection connection)
        {
            if (value)
            {
                string connectionString = Properties.Settings.Default.DatabaseOxoConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            else
            {
                connection.Close();
            }
            return connection;
        }

        /// <summary>
        /// Clears all the data from the form
        /// </summary>
        public void ClearForm()
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            labelLoginWarning.Text = "";
            labelPasswordWarning.Text = "";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Make sure the local machine has access to the database
            try
            {
                connection = OpenConnection(true, connection);
                connection = OpenConnection(false, connection);
            }
            catch (Exception ex)
            {
                textBoxLogin.Visible = false;
                textBoxPassword.Visible = false;

                labelLogin.Visible = false;
                labelPassword.Visible = false;

                labelLoginWarning.Visible = false;
                labelPasswordWarning.Visible = false;

                buttonSignIn.Visible = false;
                buttonSignUp.Visible = false;
                buttonJustPlay.Visible = false;

                buttonClose.Location = buttonSignUp.Location;
                labelTitle.Location = new Point(labelTitle.Location.X - titleOffset, textBoxLogin.Location.Y);
                labelTitle.Font = new Font(labelTitle.Font.FontFamily, 18.0f, FontStyle.Bold);
                buttonPlay.Visible = true;
            }
        }

        /// <summary>
        /// Validates the given login depending on the mode (log in/register)
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="mode"></param>
        /// <param name="login"></param>
        /// <param name="loginWarning"></param>
        /// <returns></returns>
        public int ValidateLogin(SqlConnection connection, string mode, string login, Label loginWarning)
        {
            /*
            Return values:
            -1 login not found
            0 error
            > 0 login found
            */

            // Make sure the mode is selected
            if (mode != "log" && mode != "reg")
            {
                return 0;
            }

            string loginQuery = $"SELECT id FROM Users WHERE login = '{login}';";

            // Get the table
            SqlDataAdapter adapterLogin = new SqlDataAdapter(loginQuery, connection);
            DataSet usersLoginData = new DataSet();
            adapterLogin.Fill(usersLoginData, "Users");

            int userId;

            // Log in
            if (mode == "log")
            {
                // Login not found in the database
                if (usersLoginData.Tables["Users"].Rows.Count == 0)
                {
                    loginWarning.Text = "Wrong login";
                    return -1;
                }
                // Login found
                else
                {
                    userId = Int32.Parse(usersLoginData.Tables["Users"].Rows[0]["id"].ToString());
                    return userId;
                }
            }
            // Register
            else
            {
                // Login not found in the database
                if (usersLoginData.Tables["Users"].Rows.Count == 0)
                {
                    //!!
                    if (login.Length > 8)
                    {
                        loginWarning.Text = "Max. 8 characters";
                        return 0;
                    }
                    //!!
                    return -1;
                }
                // Login found
                else
                {
                    loginWarning.Text = "Login unavailable";
                    userId = Int32.Parse(usersLoginData.Tables["Users"].Rows[0]["id"].ToString());
                    return userId;
                }
            }
        }

        /// <summary>
        /// Validates the given password depending on the mode (log in/register)
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="mode"></param>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <param name="passwordWarning"></param>
        /// <returns></returns>
        public bool ValidatePassword(SqlConnection connection, string mode, int userId, string password, Label passwordWarning)
        {
            // Make sure the mode is selected 
            if (mode != "log" && mode != "reg")
            {
                return false;
            }

            string passwordQuery = $"SELECT password FROM Users WHERE id = {userId};";

            // Get the table
            SqlDataAdapter adapterPassword = new SqlDataAdapter(passwordQuery, connection);
            DataSet usersPasswordData = new DataSet();
            adapterPassword.Fill(usersPasswordData, "Users");

            // Log in
            if (mode == "log")
            {
                // Password doesn't match
                if (usersPasswordData.Tables["Users"].Rows[0]["password"].ToString().Trim() != password)
                {
                    passwordWarning.Text = "Wrong password";
                    return false;
                }
                // Password matches
                else
                {
                    return true;
                }
            }
            // Register
            else
            {
                // Password too short
                if (password.Length <= 3)
                {
                    passwordWarning.Text = "Min. 4 characters";
                    return false;
                }
                // Password long enough
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Checks if the login text box is empty and displays appropriate warning
        /// </summary>
        /// <param name="loginText"></param>
        /// <returns></returns>
        public bool CheckLogin(string loginText, Label loginWarning)
        {
            if (String.IsNullOrEmpty(loginText))
            {
                loginWarning.Text = "No login";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the password text box is empty and displays appropriate warning
        /// </summary>
        /// <param name="passwordText"></param>
        /// <returns></returns>
        public bool CheckPassword(string passwordText, Label passwordWarning)
        {
            if (String.IsNullOrEmpty(passwordText))
            {
                passwordWarning.Text = "No password";
                return false;
            }
            return true;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            // Clear text boxes on each click
            labelLoginWarning.Text = "";
            labelPasswordWarning.Text = "";

            if (!CheckLogin(textBoxLogin.Text, labelLoginWarning) || !CheckPassword(textBoxPassword.Text, labelPasswordWarning))
            {
                return;
            }

            // Open connection for logging in validation
            connection = OpenConnection(true, connection);

            int userId = ValidateLogin(connection, "log", textBoxLogin.Text, labelLoginWarning);

            // Do nothing if login invalid
            if (userId <= 0)
            {
                // Close connection
                connection = OpenConnection(false, connection);
                return;
            }

            bool passwordValid = ValidatePassword(connection, "log", userId, textBoxPassword.Text, labelPasswordWarning);

            // Close connection
            connection = OpenConnection(false, connection);

            // Log in if both login and password valid
            if (userId > 0 && passwordValid)
            {
                //!!
                FormMode formMode = new FormMode(this, userId, textBoxLogin.Text);
                this.Hide();
                formMode.Show();

                //FormGame formGame = new FormGame(this, userId, textBoxLogin.Text);
                //this.Hide();
                //formGame.Show();
                //!!
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister(this);
            this.Hide();
            formRegister.Show();
        }

        private void buttonJustPlay_Click(object sender, EventArgs e)
        {
            PlayWithoutAccount();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayWithoutAccount();
        }

        private void PlayWithoutAccount()
        {
            //!!
            FormMode formMode = new FormMode(this, 0, "");
            this.Hide();
            formMode.Show();


            //FormGame formGame = new FormGame(this, 0, "");
            //this.Hide();
            //formGame.Show();
            //!!
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
