namespace RoShamCSharp
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAi = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblP2pick = new System.Windows.Forms.Label();
            this.lblP1pick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(84, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAi
            // 
            this.btnAi.Location = new System.Drawing.Point(84, 177);
            this.btnAi.Name = "btnAi";
            this.btnAi.Size = new System.Drawing.Size(89, 23);
            this.btnAi.TabIndex = 1;
            this.btnAi.Text = "Run AI game";
            this.btnAi.UseVisualStyleBackColor = true;
            this.btnAi.Click += new System.EventHandler(this.btnAi_Click);
            // 
            // lblWin
            // 
            this.lblWin.Location = new System.Drawing.Point(69, 122);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(128, 36);
            this.lblWin.TabIndex = 2;
            this.lblWin.Text = "88888888888888888888";
            // 
            // lblP2pick
            // 
            this.lblP2pick.Location = new System.Drawing.Point(146, 9);
            this.lblP2pick.Name = "lblP2pick";
            this.lblP2pick.Size = new System.Drawing.Size(128, 36);
            this.lblP2pick.TabIndex = 3;
            this.lblP2pick.Text = "Player 2 pick: ";
            // 
            // lblP1pick
            // 
            this.lblP1pick.Location = new System.Drawing.Point(12, 9);
            this.lblP1pick.Name = "lblP1pick";
            this.lblP1pick.Size = new System.Drawing.Size(128, 36);
            this.lblP1pick.TabIndex = 4;
            this.lblP1pick.Text = "Player 1 pick: ";
            this.lblP1pick.Click += new System.EventHandler(this.lblP1pick_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblP1pick);
            this.Controls.Add(this.lblP2pick);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnAi);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roshambo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAi;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblP2pick;
        private System.Windows.Forms.Label lblP1pick;
    }
}

