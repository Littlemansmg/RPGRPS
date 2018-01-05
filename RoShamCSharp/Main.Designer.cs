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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.aiGame = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTab1p2pick = new System.Windows.Forms.Label();
            this.picTab1p2 = new System.Windows.Forms.PictureBox();
            this.btnAi = new System.Windows.Forms.Button();
            this.lblTab1Win = new System.Windows.Forms.Label();
            this.picTab1p1 = new System.Windows.Forms.PictureBox();
            this.lblTab1p1pick = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.playerGame = new System.Windows.Forms.TabPage();
            this.cboPlayer2 = new System.Windows.Forms.ComboBox();
            this.cboPlayer1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTab2p2pick = new System.Windows.Forms.Label();
            this.picTab2p2 = new System.Windows.Forms.PictureBox();
            this.btnGame = new System.Windows.Forms.Button();
            this.lblTab2Win = new System.Windows.Forms.Label();
            this.picTab2p1 = new System.Windows.Forms.PictureBox();
            this.lblTab2p1pick = new System.Windows.Forms.Label();
            this.battleGame = new System.Windows.Forms.TabPage();
            this.aiGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1p1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.playerGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab2p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab2p1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(477, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // aiGame
            // 
            this.aiGame.Controls.Add(this.pictureBox1);
            this.aiGame.Controls.Add(this.lblTab1p2pick);
            this.aiGame.Controls.Add(this.picTab1p2);
            this.aiGame.Controls.Add(this.btnAi);
            this.aiGame.Controls.Add(this.lblTab1Win);
            this.aiGame.Controls.Add(this.picTab1p1);
            this.aiGame.Controls.Add(this.lblTab1p1pick);
            this.aiGame.Location = new System.Drawing.Point(4, 22);
            this.aiGame.Name = "aiGame";
            this.aiGame.Padding = new System.Windows.Forms.Padding(3);
            this.aiGame.Size = new System.Drawing.Size(546, 349);
            this.aiGame.TabIndex = 0;
            this.aiGame.Text = "Ai Game";
            this.aiGame.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RoShamCSharp.Properties.Resources.vs;
            this.pictureBox1.Location = new System.Drawing.Point(223, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblTab1p2pick
            // 
            this.lblTab1p2pick.Location = new System.Drawing.Point(322, 14);
            this.lblTab1p2pick.Name = "lblTab1p2pick";
            this.lblTab1p2pick.Size = new System.Drawing.Size(128, 36);
            this.lblTab1p2pick.TabIndex = 3;
            this.lblTab1p2pick.Text = "Player 2 pick: ";
            // 
            // picTab1p2
            // 
            this.picTab1p2.Location = new System.Drawing.Point(325, 53);
            this.picTab1p2.Name = "picTab1p2";
            this.picTab1p2.Size = new System.Drawing.Size(215, 120);
            this.picTab1p2.TabIndex = 6;
            this.picTab1p2.TabStop = false;
            // 
            // btnAi
            // 
            this.btnAi.Location = new System.Drawing.Point(223, 280);
            this.btnAi.Name = "btnAi";
            this.btnAi.Size = new System.Drawing.Size(89, 23);
            this.btnAi.TabIndex = 1;
            this.btnAi.Text = "Run Ai game";
            this.btnAi.UseVisualStyleBackColor = true;
            this.btnAi.Click += new System.EventHandler(this.btnAi_Click);
            // 
            // lblTab1Win
            // 
            this.lblTab1Win.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab1Win.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab1Win.Location = new System.Drawing.Point(207, 225);
            this.lblTab1Win.Name = "lblTab1Win";
            this.lblTab1Win.Size = new System.Drawing.Size(128, 36);
            this.lblTab1Win.TabIndex = 2;
            this.lblTab1Win.Text = "888";
            this.lblTab1Win.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTab1Win.Visible = false;
            // 
            // picTab1p1
            // 
            this.picTab1p1.Location = new System.Drawing.Point(6, 53);
            this.picTab1p1.Name = "picTab1p1";
            this.picTab1p1.Size = new System.Drawing.Size(215, 120);
            this.picTab1p1.TabIndex = 5;
            this.picTab1p1.TabStop = false;
            // 
            // lblTab1p1pick
            // 
            this.lblTab1p1pick.Location = new System.Drawing.Point(6, 14);
            this.lblTab1p1pick.Name = "lblTab1p1pick";
            this.lblTab1p1pick.Size = new System.Drawing.Size(128, 36);
            this.lblTab1p1pick.TabIndex = 4;
            this.lblTab1p1pick.Text = "Player 1 pick: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.aiGame);
            this.tabControl1.Controls.Add(this.playerGame);
            this.tabControl1.Controls.Add(this.battleGame);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 375);
            this.tabControl1.TabIndex = 7;
            // 
            // playerGame
            // 
            this.playerGame.Controls.Add(this.cboPlayer2);
            this.playerGame.Controls.Add(this.cboPlayer1);
            this.playerGame.Controls.Add(this.pictureBox2);
            this.playerGame.Controls.Add(this.lblTab2p2pick);
            this.playerGame.Controls.Add(this.picTab2p2);
            this.playerGame.Controls.Add(this.btnGame);
            this.playerGame.Controls.Add(this.lblTab2Win);
            this.playerGame.Controls.Add(this.picTab2p1);
            this.playerGame.Controls.Add(this.lblTab2p1pick);
            this.playerGame.Location = new System.Drawing.Point(4, 22);
            this.playerGame.Name = "playerGame";
            this.playerGame.Padding = new System.Windows.Forms.Padding(3);
            this.playerGame.Size = new System.Drawing.Size(546, 349);
            this.playerGame.TabIndex = 1;
            this.playerGame.Text = "1/2 Player Game";
            this.playerGame.UseVisualStyleBackColor = true;
            // 
            // cboPlayer2
            // 
            this.cboPlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayer2.FormattingEnabled = true;
            this.cboPlayer2.Items.AddRange(new object[] {
            "Pick Your Fighter",
            "AI",
            "Rock",
            "Paper",
            "Scissors"});
            this.cboPlayer2.Location = new System.Drawing.Point(402, 11);
            this.cboPlayer2.Name = "cboPlayer2";
            this.cboPlayer2.Size = new System.Drawing.Size(121, 21);
            this.cboPlayer2.TabIndex = 16;
            // 
            // cboPlayer1
            // 
            this.cboPlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayer1.FormattingEnabled = true;
            this.cboPlayer1.Items.AddRange(new object[] {
            "Pick Your Fighter",
            "Rock",
            "Paper",
            "Scissors"});
            this.cboPlayer1.Location = new System.Drawing.Point(86, 11);
            this.cboPlayer1.Name = "cboPlayer1";
            this.cboPlayer1.Size = new System.Drawing.Size(121, 21);
            this.cboPlayer1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RoShamCSharp.Properties.Resources.vs;
            this.pictureBox2.Location = new System.Drawing.Point(223, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lblTab2p2pick
            // 
            this.lblTab2p2pick.Location = new System.Drawing.Point(322, 14);
            this.lblTab2p2pick.Name = "lblTab2p2pick";
            this.lblTab2p2pick.Size = new System.Drawing.Size(74, 18);
            this.lblTab2p2pick.TabIndex = 10;
            this.lblTab2p2pick.Text = "Player 2 pick: ";
            // 
            // picTab2p2
            // 
            this.picTab2p2.Location = new System.Drawing.Point(325, 53);
            this.picTab2p2.Name = "picTab2p2";
            this.picTab2p2.Size = new System.Drawing.Size(215, 120);
            this.picTab2p2.TabIndex = 13;
            this.picTab2p2.TabStop = false;
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(223, 280);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(89, 23);
            this.btnGame.TabIndex = 8;
            this.btnGame.Text = "Run game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // lblTab2Win
            // 
            this.lblTab2Win.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab2Win.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab2Win.Location = new System.Drawing.Point(207, 225);
            this.lblTab2Win.Name = "lblTab2Win";
            this.lblTab2Win.Size = new System.Drawing.Size(128, 36);
            this.lblTab2Win.TabIndex = 9;
            this.lblTab2Win.Text = "888";
            this.lblTab2Win.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTab2Win.Visible = false;
            // 
            // picTab2p1
            // 
            this.picTab2p1.Location = new System.Drawing.Point(6, 53);
            this.picTab2p1.Name = "picTab2p1";
            this.picTab2p1.Size = new System.Drawing.Size(215, 120);
            this.picTab2p1.TabIndex = 12;
            this.picTab2p1.TabStop = false;
            // 
            // lblTab2p1pick
            // 
            this.lblTab2p1pick.Location = new System.Drawing.Point(6, 14);
            this.lblTab2p1pick.Name = "lblTab2p1pick";
            this.lblTab2p1pick.Size = new System.Drawing.Size(74, 18);
            this.lblTab2p1pick.TabIndex = 11;
            this.lblTab2p1pick.Text = "Player 1 pick: ";
            // 
            // battleGame
            // 
            this.battleGame.Location = new System.Drawing.Point(4, 22);
            this.battleGame.Name = "battleGame";
            this.battleGame.Padding = new System.Windows.Forms.Padding(3);
            this.battleGame.Size = new System.Drawing.Size(546, 349);
            this.battleGame.TabIndex = 2;
            this.battleGame.Text = "Battle Game";
            this.battleGame.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(578, 428);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roshambo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.aiGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1p1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.playerGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab2p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab2p1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabPage aiGame;
        private System.Windows.Forms.Label lblTab1p2pick;
        protected System.Windows.Forms.PictureBox picTab1p2;
        private System.Windows.Forms.Button btnAi;
        private System.Windows.Forms.Label lblTab1Win;
        protected System.Windows.Forms.PictureBox picTab1p1;
        private System.Windows.Forms.Label lblTab1p1pick;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage playerGame;
        private System.Windows.Forms.TabPage battleGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTab2p2pick;
        protected System.Windows.Forms.PictureBox picTab2p2;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Label lblTab2Win;
        protected System.Windows.Forms.PictureBox picTab2p1;
        private System.Windows.Forms.Label lblTab2p1pick;
        private System.Windows.Forms.ComboBox cboPlayer1;
        private System.Windows.Forms.ComboBox cboPlayer2;
    }
}

