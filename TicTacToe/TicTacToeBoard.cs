using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    /// <summary>
    /// Represents the tic-tac-toe game board
    /// </summary>
    public partial class TicTacToeBoard: UserControl
    {
        private const int BoardSize = 9;

        private bool gameStarted = false;
        private bool win = false;
        private bool tie = false;

        private int currentPlayer = 0;
        private int winner = 0;
        private bool singlePlayer = false;

        private string playerSymbol1 = "X";
        private string playerSymbol2 = "O";

        private Color fieldColor = Color.FloralWhite;
        private Color winnerColor = Color.LightCoral;
        
        private Button[] buttons = new Button[BoardSize];
        private Field[] gameFields = new Field[BoardSize];

        public TicTacToeBoard()
        {
            InitializeComponent();
        }

        public event Action<int> playerChanged;
        public event Action gameFinished;

        public bool GameStarted
        {
            set { gameStarted = value; }
        }

        public bool Win
        {
            get { return win; }
        }

        public bool Tie
        {
            get { return tie; }
        }

        public int CurrentPlayer
        {
            get { return currentPlayer; }
        }

        public int Winner
        {
            get { return winner; }
        }

        public bool SinglePlayer
        {
            get { return singlePlayer; }
            set { singlePlayer = value; }
        }

        public string PlayerSymbol1
        {
            get { return playerSymbol1;  }
            set { playerSymbol1 = value; }
        }

        public string PlayerSymbol2
        {
            get { return playerSymbol2; }
            set { playerSymbol2 = value; }
        }

        public Color FieldColor
        {
            get { return fieldColor; }
            set { fieldColor = value; }
        }

        public Color WinnerColor
        {
            get { return winnerColor;  }
            set { winnerColor = value; }
        }

        /// <summary>
        /// Resets all game settings
        /// </summary>
        public void ResetGame()
        {
            gameStarted = false;
            win = false;
            tie = false;

            // Randomize which player starts this time
            var random = new Random();
            int player = random.Next(1, 3);

            currentPlayer = player;
            playerChanged?.Invoke(currentPlayer);
            winner = 0;
        }

        /// <summary>
        /// Resets the game board
        /// </summary>
        public void ResetBoard()
        {
            // Reset all buttons
            foreach (Field gameField in gameFields)
            {
                gameField.State = 0;
                gameField.FieldButton.Text = "";
                gameField.FieldButton.BackColor = fieldColor;
            }
        }

        private void TicTacToeBoard_Load(object sender, EventArgs e)
        {
            // Get all buttons
            buttons = this.Controls.OfType<Button>().ToArray();
            Button[] sortedButtons = new Button[BoardSize];

            // Sort buttons
            for (int i = 0; i < buttons.Length; i++)
            {
                sortedButtons[buttons[i].TabIndex] = buttons[i];
            }

            buttons = sortedButtons;

            // Instantiate field at each button
            for (int i = 0; i < buttons.Length; i++)
            {
                gameFields[i] = new Field(buttons[i], i);
                buttons[i].Text = "";
                buttons[i].BackColor = fieldColor;
            }

            // Set adjacent fields for each field
            for (int i = 0; i < buttons.Length; i++)
            {
                gameFields[i].PopulateAdjacentFields(gameFields);
            }

            if (!singlePlayer)
            {
                timerVirtualOpponent.Enabled = false;
            }

            this.Enabled = false;
        }

        private void field0_Click(object sender, EventArgs e)
        {
            if (singlePlayer && currentPlayer == 2)
            {
                return;
            }
            OnFieldClicked(field0, currentPlayer);
        }

        private void field1_Click(object sender, EventArgs e)
        {
            if (singlePlayer && currentPlayer == 2)
            {
                return;
            }
            OnFieldClicked(field1, currentPlayer);
        }

        private void field2_Click(object sender, EventArgs e)
        {
            if (singlePlayer && currentPlayer == 2)
            {
                return;
            }
            OnFieldClicked(field2, currentPlayer);
        }

        private void field3_Click(object sender, EventArgs e)
        {
            if (singlePlayer && currentPlayer == 2)
            {
                return;
            }
            OnFieldClicked(field3, currentPlayer);
        }

        private void field4_Click(object sender, EventArgs e)
        {
            if (singlePlayer && currentPlayer == 2)
            {
                return;
            }
            OnFieldClicked(field4, currentPlayer);
        }

        private void field5_Click(object sender, EventArgs e)
        {
            if (singlePlayer && currentPlayer == 2)
            {
                return;
            }
            OnFieldClicked(field5, currentPlayer);
        }

        private void field6_Click(object sender, EventArgs e)
        {
            if (singlePlayer && currentPlayer == 2)
            {
                return;
            }
            OnFieldClicked(field6, currentPlayer);
        }

        private void field7_Click(object sender, EventArgs e)
        {
            if (singlePlayer && currentPlayer == 2)
            {
                return;
            }
            OnFieldClicked(field7, currentPlayer);
        }

        private void field8_Click(object sender, EventArgs e)
        {
            if (singlePlayer && currentPlayer == 2)
            {
                return;
            }
            OnFieldClicked(field8, currentPlayer);
        }
        
        /// <summary>
        /// Handles player action on a field
        /// </summary>
        /// <param name="currentButton"></param>
        /// <param name="currentPlayer"></param>
        private void OnFieldClicked(Button currentButton, int currentPlayer)
        {
            // Make sure the game is still on
            if (!gameStarted || win || tie)
            {
                return;
            }

            // Apply player action
            bool actionValid = ChangeState(currentButton, currentPlayer);

            if (!actionValid)
            {
                return;
            }

            bool gameWon = CheckWin(currentButton);

            if (gameWon)
            {
                FinishGame();
                return;
            }

            bool gameTied = CheckTie();

            if (gameTied)
            {
                FinishGame();
                return;
            }

            ChangePlayer();
        }

        /// <summary>
        /// Changes field's state according to which player has taken the action
        /// </summary>
        /// <param name="button"></param>
        /// <param name="currentPlayer"></param>
        private bool ChangeState(Button button, int currentPlayer)
        {
            if (gameFields[int.Parse(button.Name.ElementAt(5).ToString())].State != 0)
            {
                return false;
            }

            gameFields[int.Parse(button.Name.ElementAt(5).ToString())].State = currentPlayer;

            button.Text = currentPlayer == 1 ? playerSymbol1 : playerSymbol2;

            return true;
        }

        /// <summary>
        /// Checks the winning conditions
        /// </summary>
        /// <param name="button"></param>
        /// <returns></returns>
        private bool CheckWin(Button button)
        {
            // Get the field of this button
            Field thisField = gameFields[int.Parse(button.Name.ElementAt(5).ToString())];

            for (int i = 0; i < thisField.adjacentFields.Length; i++)
            {
                // Bypass this field
                if (i == 4)
                {
                    continue;
                }

                // Make sure the adjacent field exists
                if (thisField.adjacentFields[i] == null)
                {
                    continue;
                }

                // Make sure the adjacent field is of the same state (marked by the same player)
                if (thisField.adjacentFields[i].State != thisField.State)
                {
                    continue;
                }

                // Check the field in the position opposite to the adjacent field
                if (CheckOppositeField(thisField, i, button))
                {
                    return true;
                }

                // Check the adjacent field's next adjacent field in the same position
                if (CheckNextField(thisField, i, button))
                {
                    return true;
                }

                continue;
            }

            return false;
        }

        /// <summary>
        /// Checks the winning conditions if the marked field is between other marked fields
        /// </summary>
        /// <param name="thisField"></param>
        /// <param name="i"></param>
        /// <param name="button"></param>
        /// <returns></returns>
        private bool CheckOppositeField(Field thisField, int i, Button button)
        {
            // Make sure the field in the position opposite to the adjacent field exists
            if (thisField.adjacentFields[BoardSize - 1 - i] == null)
            {
                return false;
            }

            // Make sure the field in the posistion opposite to the adjacent field is of the same state (marked by the same player)
            if (thisField.adjacentFields[BoardSize - 1 - i].State != thisField.State)
            {
                return false;
            }

            // Set the game as won if all conditions met
            win = true;
            winner = currentPlayer;

            // Change colors
            button.BackColor = winnerColor;
            thisField.adjacentFields[i].FieldButton.BackColor = winnerColor;
            thisField.adjacentFields[BoardSize - 1 - i].FieldButton.BackColor = winnerColor;

            return true;
        }

        /// <summary>
        /// Checks the winning conditions if the marked field is at the end of a line of other marked fields
        /// </summary>
        /// <param name="thisField"></param>
        /// <param name="i"></param>
        /// <param name="button"></param>
        /// <returns></returns>
        private bool CheckNextField(Field thisField, int i, Button button)
        {
            // Make sure the field adjacent to the adjacent field in the same position exists
            if (thisField.adjacentFields[i].adjacentFields[i] == null)
            {
                return false;
            }

            // Make sure the field adjacent to the adjacent field in the same position is of the same state (marked by the same player)
            if (thisField.adjacentFields[i].adjacentFields[i].State != thisField.State)
            {
                return false;
            }

            // Set the game as won if all conditions met
            win = true;
            winner = currentPlayer;

            // Change colors
            button.BackColor = winnerColor;
            thisField.adjacentFields[i].FieldButton.BackColor = winnerColor;
            thisField.adjacentFields[i].adjacentFields[i].FieldButton.BackColor = winnerColor;

            return true;
        }

        /// <summary>
        /// Checks the tie conditions
        /// </summary>
        /// <returns></returns>
        private bool CheckTie()
        {
            int counter = 0;

            foreach (Field field in gameFields)
            {
                // Check for empty fields
                if (field.State != 0)
                {
                    counter++;
                }
            }

            // Set the game as tied if no empty fields left
            if (counter == BoardSize)
            {
                tie = true;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Finishes the game
        /// </summary>
        private void FinishGame()
        {
            this.Enabled = false;
            gameFinished?.Invoke();
        }

        /// <summary>
        /// Changes the currently active player
        /// </summary>
        private void ChangePlayer()
        {
            currentPlayer = currentPlayer == 1 ? 2 : 1;
            playerChanged?.Invoke(currentPlayer);
        }

        private void timerVirtualOpponent_Tick(object sender, EventArgs e)
        {
            timerVirtualOpponent.Stop();

            List<Field> emptyFields = new List<Field>();

            foreach (Field field in gameFields)
            {
                if (field.State != 0)
                {
                    continue;
                }
                // Get all empty fields
                emptyFields.Add(field);
            }

            // Choose one of the empty fields at random
            var random = new Random();
            int chosenField = random.Next(0, emptyFields.Count);

            OnFieldClicked(emptyFields[chosenField].FieldButton, currentPlayer);
        }

        /// <summary>
        /// Represents a single field on the game board
        /// </summary>
        private class Field
        {
            private const int numberOfAdjacentFields = 9;

            public Field[] adjacentFields = new Field[numberOfAdjacentFields];

            private Button fieldButton;

            private int fieldNumber;

            private int state = 0;

            public Field(Button button, int buttonNumber)
            {
                this.fieldButton = button;
                this.fieldNumber = buttonNumber;
            }

            public Button FieldButton
            {
                get { return fieldButton; }
            }

            public int State
            {
                get { return state; }
                set { state = value; }
            }

            /// <summary>
            /// Populates adjacent fields with corresponding fields from the game board
            /// </summary>
            /// <param name="gameFields"></param>
            public void PopulateAdjacentFields(Field[] gameFields)
            {
                for (int i = 0; i < numberOfAdjacentFields; i++)
                {
                    if (i == 4)
                    {
                        adjacentFields[i] = this;
                    }
                    // Top left
                    else if (fieldNumber == 0)
                    {
                        if (i <= 3 || i == 6)
                        {
                            adjacentFields[i] = null;
                        }
                        else if (i == 5)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + 1];
                        }
                        else if (i >= 7)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + (int)Math.Sqrt(BoardSize) + i - 7];
                        }
                    }
                    // Top right
                    else if (fieldNumber == Math.Sqrt(BoardSize) - 1)
                    {
                        if (i <= 2 || i == 5 || i == 8)
                        {
                            adjacentFields[i] = null;
                        }
                        else if (i == 3)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - 1];
                        }
                        else if (i >= 6)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + (int)Math.Sqrt(BoardSize) + i - 7];
                        }
                    }
                    // Bottom left
                    else if (fieldNumber == BoardSize - Math.Sqrt(BoardSize))
                    {
                        if (i == 0 || i == 3 || i >= 6)
                        {
                            adjacentFields[i] = null;
                        }
                        else if (i <= 2)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - (int)Math.Sqrt(BoardSize) + i - 1];
                        }
                        else if (i == 5)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + 1];
                        }
                    }
                    // Bottom right
                    else if (fieldNumber == BoardSize - 1)
                    {
                        if (i == 2 || i >= 5)
                        {
                            adjacentFields[i] = null;
                        }
                        else if (i <= 1)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - (int)Math.Sqrt(BoardSize) + i - 1];
                        }
                        else if (i == 3)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - 1];
                        }
                    }
                    // Top
                    else if (fieldNumber > 0 && fieldNumber < Math.Sqrt(BoardSize) - 1)
                    {
                        if (i <= 2)
                        {
                            adjacentFields[i] = null;
                        }
                        else if (i == 3)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - 1];
                        }
                        else if (i == 5)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + 1];
                        }
                        else if (i >= 6)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + (int)Math.Sqrt(BoardSize) + i - 7];
                        }
                    }
                    // Bottom
                    else if (fieldNumber > BoardSize - Math.Sqrt(BoardSize) && fieldNumber < BoardSize - 1)
                    {
                        if (i >= 6)
                        {
                            adjacentFields[i] = null;
                        }
                        else if (i <= 2)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - (int)Math.Sqrt(BoardSize) + i - 1];
                        }
                        else if (i == 3)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - 1];
                        }
                        else if (i == 5)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + 1];
                        }
                    }
                    // Left
                    else if (fieldNumber % Math.Sqrt(BoardSize) == 0)
                    {
                        if (i == 0 || i == 3 || i == 6)
                        {
                            adjacentFields[i] = null;
                        }
                        else if (i <= 2)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - (int)Math.Sqrt(BoardSize) + i - 1];
                        }
                        else if (i == 5)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + 1];
                        }
                        else if (i >= 7)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + (int)Math.Sqrt(BoardSize) + i - 7];
                        }
                    }
                    // Right
                    else if (fieldNumber % Math.Sqrt(BoardSize) == Math.Sqrt(BoardSize) - 1)
                    {
                        if (i == 2 || i == 5 || i == 8)
                        {
                            adjacentFields[i] = null;
                        }
                        else if (i <= 1)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - (int)Math.Sqrt(BoardSize) + i - 1];
                        }
                        else if (i == 3)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - 1];
                        }
                        else if (i >= 6)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + (int)Math.Sqrt(BoardSize) + i - 7];
                        }
                    }
                    // Center
                    else
                    {
                        if (i <= 2)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - (int)Math.Sqrt(BoardSize) + i - 1];
                        }
                        else if (i == 3)
                        {
                            adjacentFields[i] = gameFields[fieldNumber - 1];
                        }
                        else if (i == 5)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + 1];
                        }
                        else if (i >= 6)
                        {
                            adjacentFields[i] = gameFields[fieldNumber + (int)Math.Sqrt(BoardSize) + i - 7];
                        }
                    }
                }
            }
        }
    }
}
