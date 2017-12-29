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
            this.p1Pic = new System.Windows.Forms.PictureBox();
            this.p2Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(385, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAi
            // 
            this.btnAi.Location = new System.Drawing.Point(198, 346);
            this.btnAi.Name = "btnAi";
            this.btnAi.Size = new System.Drawing.Size(89, 23);
            this.btnAi.TabIndex = 1;
            this.btnAi.Text = "Run AI game";
            this.btnAi.UseVisualStyleBackColor = true;
            this.btnAi.Click += new System.EventHandler(this.btnAi_Click);
            // 
            // lblWin
            // 
            this.lblWin.Location = new System.Drawing.Point(172, 209);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(128, 36);
            this.lblWin.TabIndex = 2;
            this.lblWin.Text = "88888888888888888888";
            // 
            // lblP2pick
            // 
            this.lblP2pick.Location = new System.Drawing.Point(246, 9);
            this.lblP2pick.Name = "lblP2pick";
            this.lblP2pick.Size = new System.Drawing.Size(128, 36);
            this.lblP2pick.TabIndex = 3;
            this.lblP2pick.Text = "Player 2 pick: ";
            // 
            // lblP1pick
            // 
            this.lblP1pick.Location = new System.Drawing.Point(25, 9);
            this.lblP1pick.Name = "lblP1pick";
            this.lblP1pick.Size = new System.Drawing.Size(128, 36);
            this.lblP1pick.TabIndex = 4;
            this.lblP1pick.Text = "Player 1 pick: ";
            // 
            // p1Pic
            // 
            this.p1Pic.Location = new System.Drawing.Point(12, 48);
            this.p1Pic.Name = "p1Pic";
            this.p1Pic.Size = new System.Drawing.Size(215, 120);
            this.p1Pic.TabIndex = 5;
            this.p1Pic.TabStop = false;
            // 
            // p2Pic
            // 
            this.p2Pic.Location = new System.Drawing.Point(249, 48);
            this.p2Pic.Name = "p2Pic";
            this.p2Pic.Size = new System.Drawing.Size(215, 120);
            this.p2Pic.TabIndex = 6;
            this.p2Pic.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 397);
            this.Controls.Add(this.p2Pic);
            this.Controls.Add(this.p1Pic);
            this.Controls.Add(this.lblP1pick);
            this.Controls.Add(this.lblP2pick);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnAi);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roshambo";
            ((System.ComponentModel.ISupportInitialize)(this.p1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAi;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblP2pick;
        private System.Windows.Forms.Label lblP1pick;
        protected System.Windows.Forms.PictureBox p1Pic;
        protected System.Windows.Forms.PictureBox p2Pic;
    }
}

