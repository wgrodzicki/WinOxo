namespace WinOxo
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelLoginWarning = new System.Windows.Forms.Label();
            this.labelPasswordWarning = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(117, 56);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(174, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(117, 86);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(174, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelLogin.Location = new System.Drawing.Point(64, 57);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 17);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelPassword.Location = new System.Drawing.Point(41, 87);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(66, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.buttonSignUp.FlatAppearance.BorderSize = 2;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonSignUp.Location = new System.Drawing.Point(159, 121);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(90, 35);
            this.buttonSignUp.TabIndex = 4;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelLoginWarning
            // 
            this.labelLoginWarning.AutoSize = true;
            this.labelLoginWarning.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginWarning.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelLoginWarning.Location = new System.Drawing.Point(301, 58);
            this.labelLoginWarning.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoginWarning.Name = "labelLoginWarning";
            this.labelLoginWarning.Size = new System.Drawing.Size(0, 16);
            this.labelLoginWarning.TabIndex = 5;
            // 
            // labelPasswordWarning
            // 
            this.labelPasswordWarning.AutoSize = true;
            this.labelPasswordWarning.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordWarning.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelPasswordWarning.Location = new System.Drawing.Point(301, 88);
            this.labelPasswordWarning.Name = "labelPasswordWarning";
            this.labelPasswordWarning.Size = new System.Drawing.Size(0, 16);
            this.labelPasswordWarning.TabIndex = 6;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.buttonBack.FlatAppearance.BorderSize = 2;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonBack.Location = new System.Drawing.Point(300, 121);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 35);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelTitle.Location = new System.Drawing.Point(154, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(95, 26);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "WinOXO";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(404, 170);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelPasswordWarning);
            this.Controls.Add(this.labelLoginWarning);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.Text = "WinOXO Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label labelLoginWarning;
        private System.Windows.Forms.Label labelPasswordWarning;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
    }
}