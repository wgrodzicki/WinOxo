namespace WinOxo
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlayer1 = new System.Windows.Forms.Button();
            this.buttonPlayer2 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonScores = new System.Windows.Forms.Button();
            this.buttonPlaceholder = new System.Windows.Forms.Button();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.buttonSignOutBack = new System.Windows.Forms.Button();
            this.ticTacToeBoardGame = new TicTacToe.TicTacToeBoard();
            this.labelWinnerPlayer1 = new System.Windows.Forms.Label();
            this.labelWinnerPlayer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlayer1
            // 
            this.buttonPlayer1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPlayer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPlayer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayer1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayer1.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonPlayer1.Location = new System.Drawing.Point(12, 22);
            this.buttonPlayer1.Name = "buttonPlayer1";
            this.buttonPlayer1.Size = new System.Drawing.Size(100, 45);
            this.buttonPlayer1.TabIndex = 1;
            this.buttonPlayer1.Text = "Player 1";
            this.buttonPlayer1.UseVisualStyleBackColor = true;
            // 
            // buttonPlayer2
            // 
            this.buttonPlayer2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPlayer2.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPlayer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPlayer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayer2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayer2.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonPlayer2.Location = new System.Drawing.Point(419, 22);
            this.buttonPlayer2.Name = "buttonPlayer2";
            this.buttonPlayer2.Size = new System.Drawing.Size(100, 45);
            this.buttonPlayer2.TabIndex = 2;
            this.buttonPlayer2.Text = "Player 2";
            this.buttonPlayer2.UseVisualStyleBackColor = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonStart.FlatAppearance.BorderSize = 2;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonStart.Location = new System.Drawing.Point(123, 321);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 35);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start game";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonScores
            // 
            this.buttonScores.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonScores.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonScores.FlatAppearance.BorderSize = 2;
            this.buttonScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScores.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonScores.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonScores.Location = new System.Drawing.Point(218, 321);
            this.buttonScores.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonScores.Name = "buttonScores";
            this.buttonScores.Size = new System.Drawing.Size(90, 35);
            this.buttonScores.TabIndex = 4;
            this.buttonScores.Text = "Scores";
            this.buttonScores.UseVisualStyleBackColor = false;
            this.buttonScores.Click += new System.EventHandler(this.buttonScores_Click);
            // 
            // buttonPlaceholder
            // 
            this.buttonPlaceholder.FlatAppearance.BorderSize = 0;
            this.buttonPlaceholder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPlaceholder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPlaceholder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaceholder.Location = new System.Drawing.Point(229, 364);
            this.buttonPlaceholder.Name = "buttonPlaceholder";
            this.buttonPlaceholder.Size = new System.Drawing.Size(68, 18);
            this.buttonPlaceholder.TabIndex = 5;
            this.buttonPlaceholder.UseVisualStyleBackColor = true;
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxPlayer1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayer1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxPlayer1.Location = new System.Drawing.Point(38, 73);
            this.textBoxPlayer1.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(52, 32);
            this.textBoxPlayer1.TabIndex = 6;
            this.textBoxPlayer1.Text = "X";
            this.textBoxPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPlayer1.TextChanged += new System.EventHandler(this.textBoxPlayer1_TextChanged);
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxPlayer2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlayer2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBoxPlayer2.Location = new System.Drawing.Point(436, 73);
            this.textBoxPlayer2.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(52, 32);
            this.textBoxPlayer2.TabIndex = 7;
            this.textBoxPlayer2.Text = "O";
            this.textBoxPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPlayer2.TextChanged += new System.EventHandler(this.textBoxPlayer2_TextChanged);
            // 
            // buttonSignOutBack
            // 
            this.buttonSignOutBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSignOutBack.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonSignOutBack.FlatAppearance.BorderSize = 2;
            this.buttonSignOutBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignOutBack.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSignOutBack.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonSignOutBack.Location = new System.Drawing.Point(313, 321);
            this.buttonSignOutBack.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSignOutBack.Name = "buttonSignOutBack";
            this.buttonSignOutBack.Size = new System.Drawing.Size(90, 35);
            this.buttonSignOutBack.TabIndex = 8;
            this.buttonSignOutBack.Text = "Sign out";
            this.buttonSignOutBack.UseVisualStyleBackColor = false;
            this.buttonSignOutBack.Click += new System.EventHandler(this.buttonSignOutBack_Click);
            // 
            // ticTacToeBoardGame
            // 
            this.ticTacToeBoardGame.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ticTacToeBoardGame.FieldColor = System.Drawing.Color.FloralWhite;
            this.ticTacToeBoardGame.Location = new System.Drawing.Point(113, 22);
            this.ticTacToeBoardGame.Name = "ticTacToeBoardGame";
            this.ticTacToeBoardGame.PlayerSymbol1 = "X";
            this.ticTacToeBoardGame.PlayerSymbol2 = "O";
            this.ticTacToeBoardGame.Size = new System.Drawing.Size(300, 300);
            this.ticTacToeBoardGame.TabIndex = 0;
            this.ticTacToeBoardGame.WinnerColor = System.Drawing.Color.LightCoral;
            // 
            // labelWinnerPlayer1
            // 
            this.labelWinnerPlayer1.AutoSize = true;
            this.labelWinnerPlayer1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWinnerPlayer1.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelWinnerPlayer1.Location = new System.Drawing.Point(26, 118);
            this.labelWinnerPlayer1.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.labelWinnerPlayer1.Name = "labelWinnerPlayer1";
            this.labelWinnerPlayer1.Size = new System.Drawing.Size(74, 22);
            this.labelWinnerPlayer1.TabIndex = 9;
            this.labelWinnerPlayer1.Text = "Winner!";
            this.labelWinnerPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWinnerPlayer1.Visible = false;
            // 
            // labelWinnerPlayer2
            // 
            this.labelWinnerPlayer2.AutoSize = true;
            this.labelWinnerPlayer2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWinnerPlayer2.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelWinnerPlayer2.Location = new System.Drawing.Point(426, 118);
            this.labelWinnerPlayer2.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.labelWinnerPlayer2.Name = "labelWinnerPlayer2";
            this.labelWinnerPlayer2.Size = new System.Drawing.Size(74, 22);
            this.labelWinnerPlayer2.TabIndex = 10;
            this.labelWinnerPlayer2.Text = "Winner!";
            this.labelWinnerPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWinnerPlayer2.Visible = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(530, 379);
            this.Controls.Add(this.labelWinnerPlayer2);
            this.Controls.Add(this.labelWinnerPlayer1);
            this.Controls.Add(this.buttonSignOutBack);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.buttonPlaceholder);
            this.Controls.Add(this.buttonScores);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonPlayer2);
            this.Controls.Add(this.buttonPlayer1);
            this.Controls.Add(this.ticTacToeBoardGame);
            this.Name = "FormGame";
            this.Text = "WinOXO";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPlayer2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonScores;
        private System.Windows.Forms.Button buttonPlaceholder;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Button buttonSignOutBack;
        private System.Windows.Forms.Button buttonPlayer1;
        public TicTacToe.TicTacToeBoard ticTacToeBoardGame;
        private System.Windows.Forms.Label labelWinnerPlayer1;
        private System.Windows.Forms.Label labelWinnerPlayer2;
    }
}