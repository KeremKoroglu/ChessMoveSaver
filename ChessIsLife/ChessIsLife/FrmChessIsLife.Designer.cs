namespace ChessIsLife
{
    partial class FrmChessIsLife
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
            this.GrbGameInfo = new System.Windows.Forms.GroupBox();
            this.CmbResult = new System.Windows.Forms.ComboBox();
            this.ChbDateNull = new System.Windows.Forms.CheckBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.TxtRound = new System.Windows.Forms.TextBox();
            this.GrbBlack = new System.Windows.Forms.GroupBox();
            this.TxtBlackTeam = new System.Windows.Forms.TextBox();
            this.LblBlackTeam = new System.Windows.Forms.Label();
            this.CmbBlackNational = new System.Windows.Forms.ComboBox();
            this.LblBlackNational = new System.Windows.Forms.Label();
            this.TxtBlackName = new System.Windows.Forms.TextBox();
            this.TxtBlackElo = new System.Windows.Forms.TextBox();
            this.LblBlackName = new System.Windows.Forms.Label();
            this.LblBlackElo = new System.Windows.Forms.Label();
            this.LblBlackSurname = new System.Windows.Forms.Label();
            this.TxtBlackSurname = new System.Windows.Forms.TextBox();
            this.LblRound = new System.Windows.Forms.Label();
            this.GrbWhite = new System.Windows.Forms.GroupBox();
            this.TxtWhiteTeam = new System.Windows.Forms.TextBox();
            this.LblWhiteTeam = new System.Windows.Forms.Label();
            this.CmbWhiteNational = new System.Windows.Forms.ComboBox();
            this.LblWhiteNational = new System.Windows.Forms.Label();
            this.TxtWhiteName = new System.Windows.Forms.TextBox();
            this.TxtWhiteElo = new System.Windows.Forms.TextBox();
            this.LblWhiteName = new System.Windows.Forms.Label();
            this.LblWhiteElo = new System.Windows.Forms.Label();
            this.LblWhiteSurname = new System.Windows.Forms.Label();
            this.TxtWhiteSurname = new System.Windows.Forms.TextBox();
            this.LstMoves = new System.Windows.Forms.ListBox();
            this.LblMoves = new System.Windows.Forms.Label();
            this.TxtMove = new System.Windows.Forms.TextBox();
            this.LblMove = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.GrbGameInfo.SuspendLayout();
            this.GrbBlack.SuspendLayout();
            this.GrbWhite.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbGameInfo
            // 
            this.GrbGameInfo.Controls.Add(this.CmbResult);
            this.GrbGameInfo.Controls.Add(this.ChbDateNull);
            this.GrbGameInfo.Controls.Add(this.DtpDate);
            this.GrbGameInfo.Controls.Add(this.LblResult);
            this.GrbGameInfo.Controls.Add(this.LblDate);
            this.GrbGameInfo.Controls.Add(this.TxtRound);
            this.GrbGameInfo.Controls.Add(this.GrbBlack);
            this.GrbGameInfo.Controls.Add(this.LblRound);
            this.GrbGameInfo.Controls.Add(this.GrbWhite);
            this.GrbGameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrbGameInfo.Location = new System.Drawing.Point(12, 12);
            this.GrbGameInfo.Name = "GrbGameInfo";
            this.GrbGameInfo.Size = new System.Drawing.Size(566, 383);
            this.GrbGameInfo.TabIndex = 0;
            this.GrbGameInfo.TabStop = false;
            this.GrbGameInfo.Text = "Game Info";
            // 
            // CmbResult
            // 
            this.CmbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbResult.FormattingEnabled = true;
            this.CmbResult.Items.AddRange(new object[] {
            "1-0",
            "0-1",
            "½-½"});
            this.CmbResult.Location = new System.Drawing.Point(370, 164);
            this.CmbResult.Name = "CmbResult";
            this.CmbResult.Size = new System.Drawing.Size(121, 28);
            this.CmbResult.TabIndex = 8;
            // 
            // ChbDateNull
            // 
            this.ChbDateNull.AutoSize = true;
            this.ChbDateNull.Checked = true;
            this.ChbDateNull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChbDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChbDateNull.Location = new System.Drawing.Point(450, 221);
            this.ChbDateNull.Name = "ChbDateNull";
            this.ChbDateNull.Size = new System.Drawing.Size(52, 20);
            this.ChbDateNull.TabIndex = 10;
            this.ChbDateNull.Text = "Null";
            this.ChbDateNull.UseVisualStyleBackColor = true;
            this.ChbDateNull.CheckedChanged += new System.EventHandler(this.ChbDateNull_CheckedChanged);
            // 
            // DtpDate
            // 
            this.DtpDate.Enabled = false;
            this.DtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpDate.Location = new System.Drawing.Point(174, 215);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(271, 27);
            this.DtpDate.TabIndex = 9;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblResult.Location = new System.Drawing.Point(292, 167);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(72, 20);
            this.LblResult.TabIndex = 6;
            this.LblResult.Text = "Result : ";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDate.Location = new System.Drawing.Point(108, 220);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(60, 20);
            this.LblDate.TabIndex = 12;
            this.LblDate.Text = "Date : ";
            // 
            // TxtRound
            // 
            this.TxtRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRound.Location = new System.Drawing.Point(174, 164);
            this.TxtRound.Name = "TxtRound";
            this.TxtRound.Size = new System.Drawing.Size(100, 27);
            this.TxtRound.TabIndex = 7;
            // 
            // GrbBlack
            // 
            this.GrbBlack.Controls.Add(this.TxtBlackTeam);
            this.GrbBlack.Controls.Add(this.LblBlackTeam);
            this.GrbBlack.Controls.Add(this.CmbBlackNational);
            this.GrbBlack.Controls.Add(this.LblBlackNational);
            this.GrbBlack.Controls.Add(this.TxtBlackName);
            this.GrbBlack.Controls.Add(this.TxtBlackElo);
            this.GrbBlack.Controls.Add(this.LblBlackName);
            this.GrbBlack.Controls.Add(this.LblBlackElo);
            this.GrbBlack.Controls.Add(this.LblBlackSurname);
            this.GrbBlack.Controls.Add(this.TxtBlackSurname);
            this.GrbBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrbBlack.Location = new System.Drawing.Point(6, 243);
            this.GrbBlack.Name = "GrbBlack";
            this.GrbBlack.Size = new System.Drawing.Size(554, 127);
            this.GrbBlack.TabIndex = 11;
            this.GrbBlack.TabStop = false;
            this.GrbBlack.Text = "Black";
            // 
            // TxtBlackTeam
            // 
            this.TxtBlackTeam.Location = new System.Drawing.Point(353, 87);
            this.TxtBlackTeam.Name = "TxtBlackTeam";
            this.TxtBlackTeam.Size = new System.Drawing.Size(100, 27);
            this.TxtBlackTeam.TabIndex = 16;
            // 
            // LblBlackTeam
            // 
            this.LblBlackTeam.AutoSize = true;
            this.LblBlackTeam.Location = new System.Drawing.Point(279, 90);
            this.LblBlackTeam.Name = "LblBlackTeam";
            this.LblBlackTeam.Size = new System.Drawing.Size(66, 20);
            this.LblBlackTeam.TabIndex = 12;
            this.LblBlackTeam.Text = "Team : ";
            // 
            // CmbBlackNational
            // 
            this.CmbBlackNational.FormattingEnabled = true;
            this.CmbBlackNational.Location = new System.Drawing.Point(144, 87);
            this.CmbBlackNational.Name = "CmbBlackNational";
            this.CmbBlackNational.Size = new System.Drawing.Size(121, 28);
            this.CmbBlackNational.TabIndex = 15;
            // 
            // LblBlackNational
            // 
            this.LblBlackNational.AutoSize = true;
            this.LblBlackNational.Location = new System.Drawing.Point(53, 90);
            this.LblBlackNational.Name = "LblBlackNational";
            this.LblBlackNational.Size = new System.Drawing.Size(85, 20);
            this.LblBlackNational.TabIndex = 10;
            this.LblBlackNational.Text = "National : ";
            // 
            // TxtBlackName
            // 
            this.TxtBlackName.Location = new System.Drawing.Point(80, 39);
            this.TxtBlackName.Name = "TxtBlackName";
            this.TxtBlackName.Size = new System.Drawing.Size(100, 27);
            this.TxtBlackName.TabIndex = 12;
            // 
            // TxtBlackElo
            // 
            this.TxtBlackElo.Location = new System.Drawing.Point(444, 39);
            this.TxtBlackElo.Name = "TxtBlackElo";
            this.TxtBlackElo.Size = new System.Drawing.Size(100, 27);
            this.TxtBlackElo.TabIndex = 14;
            // 
            // LblBlackName
            // 
            this.LblBlackName.AutoSize = true;
            this.LblBlackName.Location = new System.Drawing.Point(6, 42);
            this.LblBlackName.Name = "LblBlackName";
            this.LblBlackName.Size = new System.Drawing.Size(68, 20);
            this.LblBlackName.TabIndex = 0;
            this.LblBlackName.Text = "Name : ";
            // 
            // LblBlackElo
            // 
            this.LblBlackElo.AutoSize = true;
            this.LblBlackElo.Location = new System.Drawing.Point(390, 42);
            this.LblBlackElo.Name = "LblBlackElo";
            this.LblBlackElo.Size = new System.Drawing.Size(48, 20);
            this.LblBlackElo.TabIndex = 4;
            this.LblBlackElo.Text = "Elo : ";
            // 
            // LblBlackSurname
            // 
            this.LblBlackSurname.AutoSize = true;
            this.LblBlackSurname.Location = new System.Drawing.Point(186, 42);
            this.LblBlackSurname.Name = "LblBlackSurname";
            this.LblBlackSurname.Size = new System.Drawing.Size(86, 20);
            this.LblBlackSurname.TabIndex = 2;
            this.LblBlackSurname.Text = "Surname :";
            // 
            // TxtBlackSurname
            // 
            this.TxtBlackSurname.Location = new System.Drawing.Point(283, 39);
            this.TxtBlackSurname.Name = "TxtBlackSurname";
            this.TxtBlackSurname.Size = new System.Drawing.Size(100, 27);
            this.TxtBlackSurname.TabIndex = 13;
            // 
            // LblRound
            // 
            this.LblRound.AutoSize = true;
            this.LblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRound.Location = new System.Drawing.Point(96, 167);
            this.LblRound.Name = "LblRound";
            this.LblRound.Size = new System.Drawing.Size(72, 20);
            this.LblRound.TabIndex = 10;
            this.LblRound.Text = "Round : ";
            // 
            // GrbWhite
            // 
            this.GrbWhite.Controls.Add(this.TxtWhiteTeam);
            this.GrbWhite.Controls.Add(this.LblWhiteTeam);
            this.GrbWhite.Controls.Add(this.CmbWhiteNational);
            this.GrbWhite.Controls.Add(this.LblWhiteNational);
            this.GrbWhite.Controls.Add(this.TxtWhiteName);
            this.GrbWhite.Controls.Add(this.TxtWhiteElo);
            this.GrbWhite.Controls.Add(this.LblWhiteName);
            this.GrbWhite.Controls.Add(this.LblWhiteElo);
            this.GrbWhite.Controls.Add(this.LblWhiteSurname);
            this.GrbWhite.Controls.Add(this.TxtWhiteSurname);
            this.GrbWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrbWhite.Location = new System.Drawing.Point(6, 29);
            this.GrbWhite.Name = "GrbWhite";
            this.GrbWhite.Size = new System.Drawing.Size(554, 122);
            this.GrbWhite.TabIndex = 1;
            this.GrbWhite.TabStop = false;
            this.GrbWhite.Text = "White";
            // 
            // TxtWhiteTeam
            // 
            this.TxtWhiteTeam.Location = new System.Drawing.Point(353, 85);
            this.TxtWhiteTeam.Name = "TxtWhiteTeam";
            this.TxtWhiteTeam.Size = new System.Drawing.Size(100, 27);
            this.TxtWhiteTeam.TabIndex = 6;
            // 
            // LblWhiteTeam
            // 
            this.LblWhiteTeam.AutoSize = true;
            this.LblWhiteTeam.Location = new System.Drawing.Point(279, 88);
            this.LblWhiteTeam.Name = "LblWhiteTeam";
            this.LblWhiteTeam.Size = new System.Drawing.Size(66, 20);
            this.LblWhiteTeam.TabIndex = 10;
            this.LblWhiteTeam.Text = "Team : ";
            // 
            // CmbWhiteNational
            // 
            this.CmbWhiteNational.FormattingEnabled = true;
            this.CmbWhiteNational.Location = new System.Drawing.Point(144, 85);
            this.CmbWhiteNational.Name = "CmbWhiteNational";
            this.CmbWhiteNational.Size = new System.Drawing.Size(121, 28);
            this.CmbWhiteNational.TabIndex = 5;
            // 
            // LblWhiteNational
            // 
            this.LblWhiteNational.AutoSize = true;
            this.LblWhiteNational.Location = new System.Drawing.Point(53, 88);
            this.LblWhiteNational.Name = "LblWhiteNational";
            this.LblWhiteNational.Size = new System.Drawing.Size(85, 20);
            this.LblWhiteNational.TabIndex = 8;
            this.LblWhiteNational.Text = "National : ";
            // 
            // TxtWhiteName
            // 
            this.TxtWhiteName.Location = new System.Drawing.Point(80, 34);
            this.TxtWhiteName.Name = "TxtWhiteName";
            this.TxtWhiteName.Size = new System.Drawing.Size(100, 27);
            this.TxtWhiteName.TabIndex = 2;
            this.TxtWhiteName.Tag = "";
            // 
            // TxtWhiteElo
            // 
            this.TxtWhiteElo.Location = new System.Drawing.Point(444, 37);
            this.TxtWhiteElo.Name = "TxtWhiteElo";
            this.TxtWhiteElo.Size = new System.Drawing.Size(100, 27);
            this.TxtWhiteElo.TabIndex = 4;
            // 
            // LblWhiteName
            // 
            this.LblWhiteName.AutoSize = true;
            this.LblWhiteName.Location = new System.Drawing.Point(6, 37);
            this.LblWhiteName.Name = "LblWhiteName";
            this.LblWhiteName.Size = new System.Drawing.Size(68, 20);
            this.LblWhiteName.TabIndex = 0;
            this.LblWhiteName.Text = "Name : ";
            // 
            // LblWhiteElo
            // 
            this.LblWhiteElo.AutoSize = true;
            this.LblWhiteElo.Location = new System.Drawing.Point(390, 40);
            this.LblWhiteElo.Name = "LblWhiteElo";
            this.LblWhiteElo.Size = new System.Drawing.Size(48, 20);
            this.LblWhiteElo.TabIndex = 4;
            this.LblWhiteElo.Text = "Elo : ";
            // 
            // LblWhiteSurname
            // 
            this.LblWhiteSurname.AutoSize = true;
            this.LblWhiteSurname.Location = new System.Drawing.Point(186, 40);
            this.LblWhiteSurname.Name = "LblWhiteSurname";
            this.LblWhiteSurname.Size = new System.Drawing.Size(86, 20);
            this.LblWhiteSurname.TabIndex = 2;
            this.LblWhiteSurname.Text = "Surname :";
            // 
            // TxtWhiteSurname
            // 
            this.TxtWhiteSurname.Location = new System.Drawing.Point(283, 37);
            this.TxtWhiteSurname.Name = "TxtWhiteSurname";
            this.TxtWhiteSurname.Size = new System.Drawing.Size(100, 27);
            this.TxtWhiteSurname.TabIndex = 3;
            // 
            // LstMoves
            // 
            this.LstMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LstMoves.FormattingEnabled = true;
            this.LstMoves.ItemHeight = 25;
            this.LstMoves.Location = new System.Drawing.Point(603, 41);
            this.LstMoves.Name = "LstMoves";
            this.LstMoves.Size = new System.Drawing.Size(353, 354);
            this.LstMoves.TabIndex = 19;
            // 
            // LblMoves
            // 
            this.LblMoves.AutoSize = true;
            this.LblMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMoves.Location = new System.Drawing.Point(598, 12);
            this.LblMoves.Name = "LblMoves";
            this.LblMoves.Size = new System.Drawing.Size(71, 25);
            this.LblMoves.TabIndex = 2;
            this.LblMoves.Text = "Moves";
            // 
            // TxtMove
            // 
            this.TxtMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMove.Location = new System.Drawing.Point(712, 404);
            this.TxtMove.Name = "TxtMove";
            this.TxtMove.Size = new System.Drawing.Size(100, 30);
            this.TxtMove.TabIndex = 17;
            this.TxtMove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMove_KeyDown);
            // 
            // LblMove
            // 
            this.LblMove.AutoSize = true;
            this.LblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMove.Location = new System.Drawing.Point(629, 407);
            this.LblMove.Name = "LblMove";
            this.LblMove.Size = new System.Drawing.Size(77, 25);
            this.LblMove.TabIndex = 4;
            this.LblMove.Text = "Move : ";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(818, 400);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(89, 38);
            this.BtnAdd.TabIndex = 18;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(12, 407);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(91, 40);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnWrite
            // 
            this.BtnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnWrite.Location = new System.Drawing.Point(124, 407);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(91, 40);
            this.BtnWrite.TabIndex = 21;
            this.BtnWrite.Text = "Write";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // FrmChessIsLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 454);
            this.Controls.Add(this.BtnWrite);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblMove);
            this.Controls.Add(this.TxtMove);
            this.Controls.Add(this.LblMoves);
            this.Controls.Add(this.LstMoves);
            this.Controls.Add(this.GrbGameInfo);
            this.Name = "FrmChessIsLife";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess Is Life";
            this.Load += new System.EventHandler(this.FrmChessIsLife_Load);
            this.GrbGameInfo.ResumeLayout(false);
            this.GrbGameInfo.PerformLayout();
            this.GrbBlack.ResumeLayout(false);
            this.GrbBlack.PerformLayout();
            this.GrbWhite.ResumeLayout(false);
            this.GrbWhite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbGameInfo;
        private System.Windows.Forms.TextBox TxtWhiteSurname;
        private System.Windows.Forms.Label LblWhiteSurname;
        private System.Windows.Forms.TextBox TxtWhiteName;
        private System.Windows.Forms.Label LblWhiteName;
        private System.Windows.Forms.TextBox TxtWhiteElo;
        private System.Windows.Forms.Label LblWhiteElo;
        private System.Windows.Forms.GroupBox GrbWhite;
        private System.Windows.Forms.GroupBox GrbBlack;
        private System.Windows.Forms.TextBox TxtBlackName;
        private System.Windows.Forms.TextBox TxtBlackElo;
        private System.Windows.Forms.Label LblBlackName;
        private System.Windows.Forms.Label LblBlackElo;
        private System.Windows.Forms.Label LblBlackSurname;
        private System.Windows.Forms.TextBox TxtBlackSurname;
        private System.Windows.Forms.Label LblBlackNational;
        private System.Windows.Forms.Label LblWhiteNational;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.ComboBox CmbWhiteNational;
        private System.Windows.Forms.ComboBox CmbBlackNational;
        private System.Windows.Forms.TextBox TxtRound;
        private System.Windows.Forms.Label LblRound;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.TextBox TxtBlackTeam;
        private System.Windows.Forms.Label LblBlackTeam;
        private System.Windows.Forms.TextBox TxtWhiteTeam;
        private System.Windows.Forms.Label LblWhiteTeam;
        private System.Windows.Forms.ListBox LstMoves;
        private System.Windows.Forms.Label LblMoves;
        private System.Windows.Forms.TextBox TxtMove;
        private System.Windows.Forms.Label LblMove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.CheckBox ChbDateNull;
        private System.Windows.Forms.ComboBox CmbResult;
    }
}

