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
    /// Handles the game
    /// </summary>
    public partial class FormGame : Form
    {
        private FormLogin formLogin;
        private int userId = 0;
        private string login = "";
        private bool singlePlayerMode = false;

        private SqlConnection connection;

        private Font buttonPlayer1font;
        private Font buttonPlayer2font;
        private Color buttonPlayerActiveColor;
        private Color buttonPlayerInactiveColor = Color.Black;

        private int initialTimerInterval = 0;

        public FormGame(FormLogin formLogin, int userId, string login, bool singlePlayerMode)
        {
            InitializeComponent();
            this.formLogin = formLogin; // Get access to the login form
            this.userId = userId;
            this.login = login;
            this.singlePlayerMode = singlePlayerMode;
            this.FormClosing += FormGame_FormClosing; // Make sure the whole app closes when this form is closed
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            ticTacToeBoardGame.Enabled = false;
            ticTacToeBoardGame.playerChanged += OnPlayerChanged;
            ticTacToeBoardGame.gameFinished += OnGameFinished;

            buttonPlayer1font = buttonPlayer1.Font;
            buttonPlayer2font = buttonPlayer2.Font;

            buttonPlayerActiveColor = buttonPlayer1.ForeColor;

            buttonPlayer1.BackColor = this.BackColor;
            buttonPlayer2.BackColor = this.BackColor;

            buttonPlayer1.FlatAppearance.BorderColor = this.BackColor;
            buttonPlayer2.FlatAppearance.BorderColor = this.BackColor;

            if (singlePlayerMode)
            {
                ticTacToeBoardGame.SinglePlayer = true;
                buttonPlayer2.Text = "AI player";
                // Save initial timer interval
                initialTimerInterval = ticTacToeBoardGame.timerVirtualOpponent.Interval;
            }

            // With account
            if (userId > 0)
            {
                buttonPlayer1.Text = login;
            }
            // Without account
            else
            {
                buttonPlayer1.Text = "You";
                buttonScores.Visible = false;
                buttonSignOutBack.Text = "Back";
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonPlayer1.FlatAppearance.BorderColor = this.BackColor;
            buttonPlayer2.FlatAppearance.BorderColor = this.BackColor;

            labelWinnerPlayer1.Visible = false;
            labelWinnerPlayer2.Visible = false;

            textBoxPlayer1.Text = textBoxPlayer1.Text.ElementAt(0).ToString();
            textBoxPlayer2.Text = textBoxPlayer2.Text.ElementAt(0).ToString();

            ticTacToeBoardGame.ResetGame();
            ticTacToeBoardGame.ResetBoard();

            ticTacToeBoardGame.Enabled = true;
            ticTacToeBoardGame.GameStarted = true;

            buttonStart.Enabled = false;
            buttonScores.Enabled = false;
            buttonSignOutBack.Enabled = false;

            textBoxPlayer1.Enabled = false;
            textBoxPlayer2.Enabled = false;

            buttonPlaceholder.Focus(); // Make sure there is no visible focus when starting the game
        }

        private void buttonScores_Click(object sender, EventArgs e)
        {
            // Reset player indicators
            buttonPlayer1.Font = new Font(buttonPlayer1font, FontStyle.Bold);
            buttonPlayer1.ForeColor = buttonPlayerActiveColor;
            buttonPlayer2.Font = new Font(buttonPlayer2font, FontStyle.Bold);
            buttonPlayer2.ForeColor = buttonPlayerActiveColor;

            labelWinnerPlayer1.Visible = false;
            labelWinnerPlayer2.Visible = false;

            FormScores formScores = new FormScores(this, formLogin, userId, login);
            this.Hide();
            formScores.Show();
        }

        /// <summary>
        /// Swaps player indicators; called when player is changed
        /// </summary>
        /// <param name="currentPlayer"></param>
        private void OnPlayerChanged(int currentPlayer)
        {
            if (currentPlayer == 1)
            {
                buttonPlayer1.Font = new Font(buttonPlayer1font, FontStyle.Bold);
                buttonPlayer1.ForeColor = buttonPlayerActiveColor;
                buttonPlayer2.Font = new Font(buttonPlayer2font, FontStyle.Regular);
                buttonPlayer2.ForeColor = buttonPlayerInactiveColor;
            }

            if (currentPlayer == 2)
            {
                buttonPlayer2.Font = new Font(buttonPlayer2.Font, FontStyle.Bold);
                buttonPlayer2.ForeColor = buttonPlayerActiveColor;
                buttonPlayer1.Font = new Font(buttonPlayer1font, FontStyle.Regular);
                buttonPlayer1.ForeColor = buttonPlayerInactiveColor;

                if (ticTacToeBoardGame.SinglePlayer)
                {
                    VirtualOpponent();
                }
            }
        }

        /// <summary>
        /// Represents an action taken by the virtual opponent
        /// </summary>
        private void VirtualOpponent()
        {
            // Randomize wait time
            var random = new Random();
            int intervalModifier = random.Next(1, 3);
            ticTacToeBoardGame.timerVirtualOpponent.Interval = initialTimerInterval * intervalModifier;

            ticTacToeBoardGame.timerVirtualOpponent.Start();
        }

        /// <summary>
        /// Handles the end of the game; called when the game is finished
        /// </summary>
        private void OnGameFinished()
        {
            int winner = ticTacToeBoardGame.Winner;

            if (winner == 1)
            {
                labelWinnerPlayer1.Visible = true;
            }

            if (winner == 2)
            {
                labelWinnerPlayer2.Visible = true;
            }

            buttonStart.Enabled = true;
            buttonScores.Enabled = true;
            buttonSignOutBack.Enabled = true;

            textBoxPlayer1.Enabled = true;
            textBoxPlayer2.Enabled = true;

            if (userId > 0)
            {
                SaveGameData();
            }
        }

        /// <summary>
        /// Saves player's data in the database
        /// </summary>
        private void SaveGameData()
        {
            // Open connection for saving
            connection = formLogin.OpenConnection(true, connection);

            string userQuery = $"SELECT * FROM Games WHERE user_id = {userId};";

            // Get the table
            SqlDataAdapter adapterUser = new SqlDataAdapter(userQuery, connection);
            DataSet gamesUserData = new DataSet();
            adapterUser.Fill(gamesUserData, "Games");

            // Game won
            if (ticTacToeBoardGame.Win)
            {
                if (ticTacToeBoardGame.Winner == 1)
                {
                    // First time
                    if (gamesUserData.Tables["Games"].Rows.Count == 0)
                    {
                        string winsQuery = $"INSERT INTO Games (user_id, wins, ties, losses) VALUES ((SELECT id FROM Users WHERE id = {userId}), 1, 0, 0);";
                        adapterUser.InsertCommand = new SqlCommand(winsQuery, connection);
                        adapterUser.InsertCommand.ExecuteNonQuery();
                        adapterUser.Update(gamesUserData, "Games");
                    }
                    // Next time
                    else
                    {
                        int currentWins = Int32.Parse(gamesUserData.Tables["Games"].Rows[0]["wins"].ToString());
                        currentWins++;
                        string winsQuery = $"UPDATE Games SET wins = {currentWins} WHERE user_id = {userId};";
                        adapterUser.InsertCommand = new SqlCommand(winsQuery, connection);
                        adapterUser.InsertCommand.ExecuteNonQuery();
                        adapterUser.Update(gamesUserData, "Games");
                    }
                }
                // Game lost
                else
                {
                    // First time
                    if (gamesUserData.Tables["Games"].Rows.Count == 0)
                    {
                        string lossesQuery = $"INSERT INTO Games (user_id, wins, ties, losses) VALUES ((SELECT id FROM Users WHERE id = {userId}), 0, 0, 1);";
                        adapterUser.InsertCommand = new SqlCommand(lossesQuery, connection);
                        adapterUser.InsertCommand.ExecuteNonQuery();
                        adapterUser.Update(gamesUserData, "Games");
                    }
                    // Next time
                    else
                    {
                        int currentLosses = Int32.Parse(gamesUserData.Tables["Games"].Rows[0]["losses"].ToString());
                        currentLosses++;
                        string lossesQuery = $"UPDATE Games SET losses = {currentLosses} WHERE user_id = {userId};";
                        adapterUser.InsertCommand = new SqlCommand(lossesQuery, connection);
                        adapterUser.InsertCommand.ExecuteNonQuery();
                        adapterUser.Update(gamesUserData, "Games");
                    }
                }
            }

            // Game tied
            if (ticTacToeBoardGame.Tie)
            {
                // First time
                if (gamesUserData.Tables["Games"].Rows.Count == 0)
                {
                    string tiesQuery = $"INSERT INTO Games (user_id, wins, ties, losses) VALUES ((SELECT id FROM Users WHERE id = {userId}), 0, 1, 0);";
                    adapterUser.InsertCommand = new SqlCommand(tiesQuery, connection);
                    adapterUser.InsertCommand.ExecuteNonQuery();
                    adapterUser.Update(gamesUserData, "Games");
                }
                // Next time
                else
                {
                    int currentTies = Int32.Parse(gamesUserData.Tables["Games"].Rows[0]["ties"].ToString());
                    currentTies++;
                    string tiesQuery = $"UPDATE Games SET ties = {currentTies} WHERE user_id = {userId};";
                    adapterUser.InsertCommand = new SqlCommand(tiesQuery, connection);
                    adapterUser.InsertCommand.ExecuteNonQuery();
                    adapterUser.Update(gamesUserData, "Games");
                }
            }

            // Close connection
            connection = formLogin.OpenConnection(false, connection);
        }

        private void textBoxPlayer1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxPlayer1.Text))
            {
                ticTacToeBoardGame.PlayerSymbol1 = textBoxPlayer1.Text.ElementAt(0).ToString();
            }
        }

        private void textBoxPlayer2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxPlayer2.Text))
            {
                ticTacToeBoardGame.PlayerSymbol2 = textBoxPlayer2.Text.ElementAt(0).ToString();
            }
        }

        private void buttonSignOutBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGame_FormClosing(Object sender, FormClosingEventArgs e)
        {
            FormMode formMode = new FormMode(formLogin, userId, login);
            formMode.Show();
        }
    }
}
