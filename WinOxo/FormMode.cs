using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOxo
{
    public partial class FormMode : Form
    {
        private FormLogin formLogin;
        private int userId = 0;
        private string login = "";
        private bool openGameWindow = false;

        public FormMode(FormLogin formLogin, int userId, string login)
        {
            InitializeComponent();
            this.formLogin = formLogin; // Get access to the login form
            this.userId = userId;
            this.login = login;
            this.FormClosing += FormMode_FormClosing; // Make sure the whole app closes when this form is closed
        }

        private void buttonSinglePlayer_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame(formLogin, userId, login, true);
            openGameWindow = true;
            this.Close();
            formGame.Show();
        }

        private void buttonTwoPlayers_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame(formLogin, userId, login, false);
            openGameWindow = true;
            this.Close();
            formGame.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //formLogin.ClearForm();
            //formLogin.Show();
        }

        private void FormMode_FormClosing(Object sender, FormClosingEventArgs e)
        {
            formLogin.ClearForm();

            if (!openGameWindow)
            {
                formLogin.Show();
            }
        }
    }
}
