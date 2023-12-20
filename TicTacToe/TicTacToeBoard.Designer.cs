namespace TicTacToe
{
    partial class TicTacToeBoard
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.field0 = new System.Windows.Forms.Button();
            this.field1 = new System.Windows.Forms.Button();
            this.field2 = new System.Windows.Forms.Button();
            this.field3 = new System.Windows.Forms.Button();
            this.field4 = new System.Windows.Forms.Button();
            this.field5 = new System.Windows.Forms.Button();
            this.field6 = new System.Windows.Forms.Button();
            this.field7 = new System.Windows.Forms.Button();
            this.field8 = new System.Windows.Forms.Button();
            this.timerVirtualOpponent = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // field0
            // 
            this.field0.BackColor = System.Drawing.Color.FloralWhite;
            this.field0.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field0.ForeColor = System.Drawing.Color.Black;
            this.field0.Location = new System.Drawing.Point(10, 10);
            this.field0.Margin = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.field0.Name = "field0";
            this.field0.Size = new System.Drawing.Size(90, 90);
            this.field0.TabIndex = 0;
            this.field0.Text = "field0";
            this.field0.UseVisualStyleBackColor = false;
            this.field0.Click += new System.EventHandler(this.field0_Click);
            // 
            // field1
            // 
            this.field1.BackColor = System.Drawing.Color.FloralWhite;
            this.field1.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field1.ForeColor = System.Drawing.Color.Black;
            this.field1.Location = new System.Drawing.Point(105, 10);
            this.field1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(90, 90);
            this.field1.TabIndex = 1;
            this.field1.Text = "field1";
            this.field1.UseVisualStyleBackColor = false;
            this.field1.Click += new System.EventHandler(this.field1_Click);
            // 
            // field2
            // 
            this.field2.BackColor = System.Drawing.Color.FloralWhite;
            this.field2.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field2.ForeColor = System.Drawing.Color.Black;
            this.field2.Location = new System.Drawing.Point(200, 10);
            this.field2.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(90, 90);
            this.field2.TabIndex = 2;
            this.field2.Text = "field2";
            this.field2.UseVisualStyleBackColor = false;
            this.field2.Click += new System.EventHandler(this.field2_Click);
            // 
            // field3
            // 
            this.field3.BackColor = System.Drawing.Color.FloralWhite;
            this.field3.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field3.ForeColor = System.Drawing.Color.Black;
            this.field3.Location = new System.Drawing.Point(10, 105);
            this.field3.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(90, 90);
            this.field3.TabIndex = 3;
            this.field3.Text = "field3";
            this.field3.UseVisualStyleBackColor = false;
            this.field3.Click += new System.EventHandler(this.field3_Click);
            // 
            // field4
            // 
            this.field4.BackColor = System.Drawing.Color.FloralWhite;
            this.field4.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field4.ForeColor = System.Drawing.Color.Black;
            this.field4.Location = new System.Drawing.Point(105, 105);
            this.field4.Margin = new System.Windows.Forms.Padding(0);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(90, 90);
            this.field4.TabIndex = 4;
            this.field4.Text = "field4";
            this.field4.UseVisualStyleBackColor = false;
            this.field4.Click += new System.EventHandler(this.field4_Click);
            // 
            // field5
            // 
            this.field5.BackColor = System.Drawing.Color.FloralWhite;
            this.field5.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field5.ForeColor = System.Drawing.Color.Black;
            this.field5.Location = new System.Drawing.Point(200, 105);
            this.field5.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(90, 90);
            this.field5.TabIndex = 5;
            this.field5.Text = "field5";
            this.field5.UseVisualStyleBackColor = false;
            this.field5.Click += new System.EventHandler(this.field5_Click);
            // 
            // field6
            // 
            this.field6.BackColor = System.Drawing.Color.FloralWhite;
            this.field6.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field6.ForeColor = System.Drawing.Color.Black;
            this.field6.Location = new System.Drawing.Point(10, 200);
            this.field6.Margin = new System.Windows.Forms.Padding(10, 5, 5, 10);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(90, 90);
            this.field6.TabIndex = 6;
            this.field6.Text = "field6";
            this.field6.UseVisualStyleBackColor = false;
            this.field6.Click += new System.EventHandler(this.field6_Click);
            // 
            // field7
            // 
            this.field7.BackColor = System.Drawing.Color.FloralWhite;
            this.field7.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field7.ForeColor = System.Drawing.Color.Black;
            this.field7.Location = new System.Drawing.Point(105, 200);
            this.field7.Margin = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(90, 90);
            this.field7.TabIndex = 7;
            this.field7.Text = "field7";
            this.field7.UseVisualStyleBackColor = false;
            this.field7.Click += new System.EventHandler(this.field7_Click);
            // 
            // field8
            // 
            this.field8.BackColor = System.Drawing.Color.FloralWhite;
            this.field8.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.field8.ForeColor = System.Drawing.Color.Black;
            this.field8.Location = new System.Drawing.Point(200, 200);
            this.field8.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(90, 90);
            this.field8.TabIndex = 8;
            this.field8.Text = "field8";
            this.field8.UseVisualStyleBackColor = false;
            this.field8.Click += new System.EventHandler(this.field8_Click);
            // 
            // timerVirtualOpponent
            // 
            this.timerVirtualOpponent.Interval = 1000;
            this.timerVirtualOpponent.Tick += new System.EventHandler(this.timerVirtualOpponent_Tick);
            // 
            // TicTacToeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.field8);
            this.Controls.Add(this.field7);
            this.Controls.Add(this.field6);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Controls.Add(this.field0);
            this.Name = "TicTacToeBoard";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.TicTacToeBoard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button field0;
        private System.Windows.Forms.Button field1;
        private System.Windows.Forms.Button field2;
        private System.Windows.Forms.Button field3;
        private System.Windows.Forms.Button field4;
        private System.Windows.Forms.Button field5;
        private System.Windows.Forms.Button field6;
        private System.Windows.Forms.Button field7;
        private System.Windows.Forms.Button field8;
        public System.Windows.Forms.Timer timerVirtualOpponent;
    }
}
