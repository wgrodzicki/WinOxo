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
    /// Handles the display of player's scores
    /// </summary>
    public partial class FormScores : Form
    {
        private FormGame formGame;
        private FormLogin formLogin;
        private int userId = 0;
        private string login = "";

        private SqlConnection connection;

        private bool accountDeleted = false;

        public FormScores(FormGame formGame, FormLogin formLogin, int userId, string login)
        {
            InitializeComponent();
            this.formGame = formGame; // Get access to the game form
            this.formLogin = formLogin; // Get access to the login form
            this.userId = userId;
            this.login = login;
            this.FormClosing += FormScores_FormClosing; // Make sure the whole app closes when this form is closed
        }

        private void FormScores_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = login;
            
            if(GetGamesData())
            {
                GetRankingData();
            }
        }

        /// <summary>
        /// Fetches and displays player's wins, ties and losses
        /// </summary>
        /// <returns></returns>
        private bool GetGamesData()
        {
            // Open connection for fetching
            connection = formLogin.OpenConnection(true, connection);

            string gamesQuery = $"SELECT * FROM Games WHERE user_id = {userId};";

            // Get the table
            SqlDataAdapter adapterGames = new SqlDataAdapter(gamesQuery, connection);
            DataSet gamesData = new DataSet();
            adapterGames.Fill(gamesData, "Games");

            // No data found
            if (gamesData.Tables["Games"].Rows.Count == 0)
            {
                textBoxRanking.Text = "No data";
                textBoxRatio.Text = "No data";
                textBoxWins.Text = "No data";
                textBoxTies.Text = "No data";
                textBoxLosses.Text = "No data";
                connection = formLogin.OpenConnection(false, connection);
                return false;
            }
            // Data found
            else
            {
                textBoxWins.Text = gamesData.Tables["Games"].Rows[0]["wins"].ToString();
                textBoxTies.Text = gamesData.Tables["Games"].Rows[0]["ties"].ToString();
                textBoxLosses.Text = gamesData.Tables["Games"].Rows[0]["losses"].ToString();
            }

            // Close connection
            connection = formLogin.OpenConnection(false, connection);

            return true;   
        }

        /// <summary>
        /// Fetches and displays player's wins/games ratio and ranking position among all registered players
        /// </summary>
        private void GetRankingData()
        {
            // Open connection for fetching
            connection = formLogin.OpenConnection(true, connection);

            string rankingQuery = $"SELECT * FROM Games ORDER BY wins DESC;";

            // Get the table
            SqlDataAdapter adapterRanking = new SqlDataAdapter(rankingQuery, connection);
            DataSet rankingData = new DataSet();
            adapterRanking.Fill(rankingData, "Games");

            float userRatio = 0.0f;
            List<Dictionary<int, float>> ratios = new List<Dictionary<int, float>>();

            for (int i = 0; i < rankingData.Tables["Games"].Rows.Count; i++)
            {
                int currentRowId = Int32.Parse(rankingData.Tables["Games"].Rows[i]["user_id"].ToString());
                float currentRowRatio = 0.0f;
                Dictionary<int, float> currentDictionary = new Dictionary<int, float>();

                // Valid wins
                if (Int32.Parse(rankingData.Tables["Games"].Rows[i]["wins"].ToString()) != 0)
                {
                    // Calculate ratio
                    float currentWins = float.Parse(rankingData.Tables["Games"].Rows[i]["wins"].ToString());
                    float currentTies = float.Parse(rankingData.Tables["Games"].Rows[i]["ties"].ToString());
                    float currentLosses = float.Parse(rankingData.Tables["Games"].Rows[i]["losses"].ToString());
                    currentRowRatio = currentWins / (currentWins + currentTies + currentLosses);

                    // Set player ratio if the current row belongs to the player
                    if (Int32.Parse(rankingData.Tables["Games"].Rows[i]["user_id"].ToString()) == userId)
                    {
                        userRatio = currentRowRatio;
                    }
                }

                // Store current ratio with current player's id
                currentDictionary.Add(currentRowId, currentRowRatio);
                
                // Add current data to the list
                ratios.Add(currentDictionary);
            }

            // Display player's ratio
            textBoxRatio.Text = (userRatio * 100).ToString("0.00") + "%";

            // Sort the list of data through bubble sort
            bool valuesSwapped = false;

            do
            {
                valuesSwapped = false;

                for (int i = 0; i < ratios.Count; i++)
                {
                    if (i + 1 >= ratios.Count)
                    {
                        break;
                    }

                    if (ratios[i + 1].ElementAt(0).Value > ratios[i].ElementAt(0).Value)
                    {
                        var temp = ratios[i];
                        ratios[i] = ratios[i + 1];
                        ratios[i + 1] = temp;
                        valuesSwapped = true;
                    }
                }
            } while (valuesSwapped);

            // Look for the player's ratio among all sorted ratios
            int tiedValues = 0;

            for (int i = 0; i < ratios.Count; i++)
            {
                // Account for tied values
                if (i > 0)
                {
                    if (ratios[i].ElementAt(0).Value == ratios[i - 1].ElementAt(0).Value)
                    {
                        tiedValues++;
                    }
                }

                if (ratios[i].ElementAt(0).Key == userId)
                {
                    textBoxRanking.Text = (i + 1 - tiedValues).ToString();
                    break;
                }
            }

            // Close connection
            connection = formLogin.OpenConnection(false, connection);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Display message
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete your account?", "Delete account confirmation", MessageBoxButtons.OKCancel);
            
            if (deleteConfirmation == DialogResult.OK)
            {
                DeleteAccount();
            }
            else
            {
                return;
            }    
        }

        private void DeleteAccount()
        {
            // Open connection for deleting
            connection = formLogin.OpenConnection(true, connection);

            // Games
            string gamesQuery = $"SELECT * FROM Games;";

            // Get the table
            SqlDataAdapter adapterGamesDelete = new SqlDataAdapter(gamesQuery, connection);
            DataSet gamesDeleteData = new DataSet();
            adapterGamesDelete.Fill(gamesDeleteData, "Games");

            // Delete games from the table
            string gamesDeleteQuery = $"DELETE FROM Games WHERE user_id = {userId};";
            adapterGamesDelete.DeleteCommand = new SqlCommand(gamesDeleteQuery, connection);
            adapterGamesDelete.DeleteCommand.ExecuteNonQuery();
            adapterGamesDelete.Update(gamesDeleteData, "Games"); // Save changes to the database

            // User
            string usersQuery = $"SELECT * FROM Users;";

            // Get the table
            SqlDataAdapter adapterUsersDelete = new SqlDataAdapter(usersQuery, connection);
            DataSet usersDeleteData = new DataSet();
            adapterUsersDelete.Fill(usersDeleteData, "Users");

            // Delete user from the table
            string usersDeleteQuery = $"DELETE FROM Users WHERE id = {userId};";
            adapterUsersDelete.DeleteCommand = new SqlCommand(usersDeleteQuery, connection);
            adapterUsersDelete.DeleteCommand.ExecuteNonQuery();
            adapterUsersDelete.Update(usersDeleteData, "Users"); // Save changes to the database

            // Close connection
            connection = formLogin.OpenConnection(false, connection);

            // Display message
            MessageBox.Show("Account deleted successfully!");

            accountDeleted = true;
            
            this.Close();
            formLogin.ClearForm();
            formLogin.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formGame.Show();
        }

        private void FormScores_FormClosing(Object sender, FormClosingEventArgs e)
        {
            formGame.ticTacToeBoardGame.ResetBoard();

            if (!accountDeleted)
            {
                formGame.Show();
            }
        }
    }

}
