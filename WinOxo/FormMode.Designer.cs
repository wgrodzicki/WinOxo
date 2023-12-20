namespace WinOxo
{
    partial class FormMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMode));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTwoPlayers = new System.Windows.Forms.Button();
            this.buttonSinglePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonBack.Location = new System.Drawing.Point(77, 137);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(115, 35);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonTwoPlayers
            // 
            this.buttonTwoPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonTwoPlayers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.buttonTwoPlayers.FlatAppearance.BorderSize = 2;
            this.buttonTwoPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwoPlayers.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTwoPlayers.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonTwoPlayers.Location = new System.Drawing.Point(77, 92);
            this.buttonTwoPlayers.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonTwoPlayers.Name = "buttonTwoPlayers";
            this.buttonTwoPlayers.Size = new System.Drawing.Size(115, 35);
            this.buttonTwoPlayers.TabIndex = 11;
            this.buttonTwoPlayers.Text = "Two players";
            this.buttonTwoPlayers.UseVisualStyleBackColor = false;
            this.buttonTwoPlayers.Click += new System.EventHandler(this.buttonTwoPlayers_Click);
            // 
            // buttonSinglePlayer
            // 
            this.buttonSinglePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonSinglePlayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.buttonSinglePlayer.FlatAppearance.BorderSize = 2;
            this.buttonSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSinglePlayer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSinglePlayer.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonSinglePlayer.Location = new System.Drawing.Point(77, 47);
            this.buttonSinglePlayer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonSinglePlayer.Name = "buttonSinglePlayer";
            this.buttonSinglePlayer.Size = new System.Drawing.Size(115, 35);
            this.buttonSinglePlayer.TabIndex = 12;
            this.buttonSinglePlayer.Text = "Single player";
            this.buttonSinglePlayer.UseVisualStyleBackColor = false;
            this.buttonSinglePlayer.Click += new System.EventHandler(this.buttonSinglePlayer_Click);
            // 
            // FormMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(269, 211);
            this.Controls.Add(this.buttonSinglePlayer);
            this.Controls.Add(this.buttonTwoPlayers);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMode";
            this.Padding = new System.Windows.Forms.Padding(77, 0, 77, 0);
            this.Text = "WinOxo Mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonTwoPlayers;
        private System.Windows.Forms.Button buttonSinglePlayer;
    }
}