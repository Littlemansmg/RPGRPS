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
            this.lblTab1Tie = new System.Windows.Forms.Label();
            this.lblTab1Win2 = new System.Windows.Forms.Label();
            this.lblTab1Win1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTab1p2pick = new System.Windows.Forms.Label();
            this.picTab1p2 = new System.Windows.Forms.PictureBox();
            this.btnAi = new System.Windows.Forms.Button();
            this.lblTab1Win = new System.Windows.Forms.Label();
            this.picTab1p1 = new System.Windows.Forms.PictureBox();
            this.lblTab1p1pick = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.playerGame = new System.Windows.Forms.TabPage();
            this.lblTab2Tie = new System.Windows.Forms.Label();
            this.lblTab2Win2 = new System.Windows.Forms.Label();
            this.lblTab2Win1 = new System.Windows.Forms.Label();
            this.cboPlayer2 = new System.Windows.Forms.ComboBox();
            this.cboTab2P1Pick = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTab2p2pick = new System.Windows.Forms.Label();
            this.picTab2p2 = new System.Windows.Forms.PictureBox();
            this.btnGame = new System.Windows.Forms.Button();
            this.lblTab2Win = new System.Windows.Forms.Label();
            this.picTab2p1 = new System.Windows.Forms.PictureBox();
            this.lblTab2p1pick = new System.Windows.Forms.Label();
            this.battleGame = new System.Windows.Forms.TabPage();
            this.btnBattle = new System.Windows.Forms.Button();
            this.cboTab3P1Pick = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTab3p2pick = new System.Windows.Forms.Label();
            this.picTab3p2 = new System.Windows.Forms.PictureBox();
            this.picTab3p1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpMove = new System.Windows.Forms.GroupBox();
            this.rdoTackle = new System.Windows.Forms.RadioButton();
            this.rdoDefend = new System.Windows.Forms.RadioButton();
            this.rdoHeal = new System.Windows.Forms.RadioButton();
            this.rdoLolRip = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblP1Health = new System.Windows.Forms.Label();
            this.lblP2Health = new System.Windows.Forms.Label();
            this.lblTab3win = new System.Windows.Forms.Label();
            this.aiGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1p1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.playerGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab2p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab2p1)).BeginInit();
            this.battleGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab3p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab3p1)).BeginInit();
            this.grpMove.SuspendLayout();
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
            this.aiGame.Controls.Add(this.lblTab1Tie);
            this.aiGame.Controls.Add(this.lblTab1Win2);
            this.aiGame.Controls.Add(this.lblTab1Win1);
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
            // lblTab1Tie
            // 
            this.lblTab1Tie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab1Tie.Location = new System.Drawing.Point(223, 156);
            this.lblTab1Tie.Name = "lblTab1Tie";
            this.lblTab1Tie.Size = new System.Drawing.Size(100, 36);
            this.lblTab1Tie.TabIndex = 10;
            // 
            // lblTab1Win2
            // 
            this.lblTab1Win2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab1Win2.Location = new System.Drawing.Point(325, 176);
            this.lblTab1Win2.Name = "lblTab1Win2";
            this.lblTab1Win2.Size = new System.Drawing.Size(128, 36);
            this.lblTab1Win2.TabIndex = 9;
            // 
            // lblTab1Win1
            // 
            this.lblTab1Win1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab1Win1.Location = new System.Drawing.Point(6, 176);
            this.lblTab1Win1.Name = "lblTab1Win1";
            this.lblTab1Win1.Size = new System.Drawing.Size(128, 36);
            this.lblTab1Win1.TabIndex = 8;
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
            this.lblTab1p2pick.Size = new System.Drawing.Size(131, 36);
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
            this.btnAi.Text = "Run Ai Game";
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
            this.playerGame.Controls.Add(this.lblTab2Tie);
            this.playerGame.Controls.Add(this.lblTab2Win2);
            this.playerGame.Controls.Add(this.lblTab2Win1);
            this.playerGame.Controls.Add(this.cboPlayer2);
            this.playerGame.Controls.Add(this.cboTab2P1Pick);
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
            // lblTab2Tie
            // 
            this.lblTab2Tie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab2Tie.Location = new System.Drawing.Point(223, 156);
            this.lblTab2Tie.Name = "lblTab2Tie";
            this.lblTab2Tie.Size = new System.Drawing.Size(100, 36);
            this.lblTab2Tie.TabIndex = 19;
            // 
            // lblTab2Win2
            // 
            this.lblTab2Win2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab2Win2.Location = new System.Drawing.Point(325, 176);
            this.lblTab2Win2.Name = "lblTab2Win2";
            this.lblTab2Win2.Size = new System.Drawing.Size(128, 36);
            this.lblTab2Win2.TabIndex = 18;
            // 
            // lblTab2Win1
            // 
            this.lblTab2Win1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab2Win1.Location = new System.Drawing.Point(6, 176);
            this.lblTab2Win1.Name = "lblTab2Win1";
            this.lblTab2Win1.Size = new System.Drawing.Size(128, 36);
            this.lblTab2Win1.TabIndex = 17;
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
            // cboTab2P1Pick
            // 
            this.cboTab2P1Pick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTab2P1Pick.FormattingEnabled = true;
            this.cboTab2P1Pick.Items.AddRange(new object[] {
            "Pick Your Fighter",
            "Rock",
            "Paper",
            "Scissors"});
            this.cboTab2P1Pick.Location = new System.Drawing.Point(86, 11);
            this.cboTab2P1Pick.Name = "cboTab2P1Pick";
            this.cboTab2P1Pick.Size = new System.Drawing.Size(121, 21);
            this.cboTab2P1Pick.TabIndex = 15;
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
            this.btnGame.Text = "Run Game";
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
            this.battleGame.Controls.Add(this.lblTab3win);
            this.battleGame.Controls.Add(this.lblP2Health);
            this.battleGame.Controls.Add(this.grpMove);
            this.battleGame.Controls.Add(this.btnBattle);
            this.battleGame.Controls.Add(this.cboTab3P1Pick);
            this.battleGame.Controls.Add(this.pictureBox3);
            this.battleGame.Controls.Add(this.lblTab3p2pick);
            this.battleGame.Controls.Add(this.picTab3p2);
            this.battleGame.Controls.Add(this.picTab3p1);
            this.battleGame.Controls.Add(this.label6);
            this.battleGame.Location = new System.Drawing.Point(4, 22);
            this.battleGame.Name = "battleGame";
            this.battleGame.Padding = new System.Windows.Forms.Padding(3);
            this.battleGame.Size = new System.Drawing.Size(546, 349);
            this.battleGame.TabIndex = 2;
            this.battleGame.Text = "Battle Game";
            this.battleGame.UseVisualStyleBackColor = true;
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(240, 218);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(75, 23);
            this.btnBattle.TabIndex = 28;
            this.btnBattle.Text = "Start Battle";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // cboTab3P1Pick
            // 
            this.cboTab3P1Pick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTab3P1Pick.FormattingEnabled = true;
            this.cboTab3P1Pick.Items.AddRange(new object[] {
            "Pick Your Fighter",
            "Rock",
            "Paper",
            "Scissors"});
            this.cboTab3P1Pick.Location = new System.Drawing.Point(86, 11);
            this.cboTab3P1Pick.Name = "cboTab3P1Pick";
            this.cboTab3P1Pick.Size = new System.Drawing.Size(121, 21);
            this.cboTab3P1Pick.TabIndex = 27;
            this.cboTab3P1Pick.SelectedIndexChanged += new System.EventHandler(this.cboTab3P1Pick_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RoShamCSharp.Properties.Resources.vs;
            this.pictureBox3.Location = new System.Drawing.Point(223, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // lblTab3p2pick
            // 
            this.lblTab3p2pick.Location = new System.Drawing.Point(322, 14);
            this.lblTab3p2pick.Name = "lblTab3p2pick";
            this.lblTab3p2pick.Size = new System.Drawing.Size(155, 18);
            this.lblTab3p2pick.TabIndex = 22;
            this.lblTab3p2pick.Text = "Player 2 pick: ";
            // 
            // picTab3p2
            // 
            this.picTab3p2.Location = new System.Drawing.Point(325, 53);
            this.picTab3p2.Name = "picTab3p2";
            this.picTab3p2.Size = new System.Drawing.Size(215, 120);
            this.picTab3p2.TabIndex = 25;
            this.picTab3p2.TabStop = false;
            // 
            // picTab3p1
            // 
            this.picTab3p1.Location = new System.Drawing.Point(6, 53);
            this.picTab3p1.Name = "picTab3p1";
            this.picTab3p1.Size = new System.Drawing.Size(215, 120);
            this.picTab3p1.TabIndex = 24;
            this.picTab3p1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Player 1 pick: ";
            // 
            // grpMove
            // 
            this.grpMove.Controls.Add(this.lblP1Health);
            this.grpMove.Controls.Add(this.btnConfirm);
            this.grpMove.Controls.Add(this.rdoLolRip);
            this.grpMove.Controls.Add(this.rdoHeal);
            this.grpMove.Controls.Add(this.rdoDefend);
            this.grpMove.Controls.Add(this.rdoTackle);
            this.grpMove.Location = new System.Drawing.Point(9, 179);
            this.grpMove.Name = "grpMove";
            this.grpMove.Size = new System.Drawing.Size(212, 143);
            this.grpMove.TabIndex = 29;
            this.grpMove.TabStop = false;
            this.grpMove.Text = "Pick Your Move";
            this.grpMove.Visible = false;
            // 
            // rdoTackle
            // 
            this.rdoTackle.AutoSize = true;
            this.rdoTackle.Location = new System.Drawing.Point(7, 20);
            this.rdoTackle.Name = "rdoTackle";
            this.rdoTackle.Size = new System.Drawing.Size(58, 17);
            this.rdoTackle.TabIndex = 0;
            this.rdoTackle.TabStop = true;
            this.rdoTackle.Text = "Tackle";
            this.rdoTackle.UseVisualStyleBackColor = true;
            // 
            // rdoDefend
            // 
            this.rdoDefend.AutoSize = true;
            this.rdoDefend.Location = new System.Drawing.Point(7, 43);
            this.rdoDefend.Name = "rdoDefend";
            this.rdoDefend.Size = new System.Drawing.Size(60, 17);
            this.rdoDefend.TabIndex = 1;
            this.rdoDefend.TabStop = true;
            this.rdoDefend.Text = "Defend";
            this.rdoDefend.UseVisualStyleBackColor = true;
            // 
            // rdoHeal
            // 
            this.rdoHeal.AutoSize = true;
            this.rdoHeal.Location = new System.Drawing.Point(6, 66);
            this.rdoHeal.Name = "rdoHeal";
            this.rdoHeal.Size = new System.Drawing.Size(47, 17);
            this.rdoHeal.TabIndex = 2;
            this.rdoHeal.TabStop = true;
            this.rdoHeal.Text = "Heal";
            this.rdoHeal.UseVisualStyleBackColor = true;
            // 
            // rdoLolRip
            // 
            this.rdoLolRip.AutoSize = true;
            this.rdoLolRip.Location = new System.Drawing.Point(6, 89);
            this.rdoLolRip.Name = "rdoLolRip";
            this.rdoLolRip.Size = new System.Drawing.Size(64, 17);
            this.rdoLolRip.TabIndex = 3;
            this.rdoLolRip.TabStop = true;
            this.rdoLolRip.Text = "Give Up";
            this.rdoLolRip.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(16, 112);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 30;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblP1Health
            // 
            this.lblP1Health.Location = new System.Drawing.Point(113, 39);
            this.lblP1Health.Name = "lblP1Health";
            this.lblP1Health.Size = new System.Drawing.Size(75, 21);
            this.lblP1Health.TabIndex = 31;
            this.lblP1Health.Text = "Health: ";
            // 
            // lblP2Health
            // 
            this.lblP2Health.Location = new System.Drawing.Point(388, 218);
            this.lblP2Health.Name = "lblP2Health";
            this.lblP2Health.Size = new System.Drawing.Size(75, 21);
            this.lblP2Health.TabIndex = 32;
            this.lblP2Health.Text = "Health: ";
            this.lblP2Health.Visible = false;
            // 
            // lblTab3win
            // 
            this.lblTab3win.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTab3win.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab3win.Location = new System.Drawing.Point(219, 245);
            this.lblTab3win.Name = "lblTab3win";
            this.lblTab3win.Size = new System.Drawing.Size(117, 40);
            this.lblTab3win.TabIndex = 33;
            this.lblTab3win.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(578, 428);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
            this.battleGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab3p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTab3p1)).EndInit();
            this.grpMove.ResumeLayout(false);
            this.grpMove.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboTab2P1Pick;
        private System.Windows.Forms.ComboBox cboPlayer2;
        private System.Windows.Forms.Label lblTab1Win2;
        private System.Windows.Forms.Label lblTab1Win1;
        private System.Windows.Forms.Label lblTab1Tie;
        private System.Windows.Forms.Label lblTab2Tie;
        private System.Windows.Forms.Label lblTab2Win2;
        private System.Windows.Forms.Label lblTab2Win1;
        private System.Windows.Forms.ComboBox cboTab3P1Pick;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTab3p2pick;
        protected System.Windows.Forms.PictureBox picTab3p2;
        protected System.Windows.Forms.PictureBox picTab3p1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.GroupBox grpMove;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rdoLolRip;
        private System.Windows.Forms.RadioButton rdoHeal;
        private System.Windows.Forms.RadioButton rdoDefend;
        private System.Windows.Forms.RadioButton rdoTackle;
        private System.Windows.Forms.Label lblP1Health;
        private System.Windows.Forms.Label lblP2Health;
        private System.Windows.Forms.Label lblTab3win;
    }
}

