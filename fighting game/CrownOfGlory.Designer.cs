namespace fighting_game
{
    partial class CrownOfGlory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrownOfGlory));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.victoryReturnbtn = new System.Windows.Forms.Button();
            this.victorylbl = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.lblPlayMinigame = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.pictureChibi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChibi)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // victoryReturnbtn
            // 
            this.victoryReturnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.victoryReturnbtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryReturnbtn.ForeColor = System.Drawing.Color.Yellow;
            this.victoryReturnbtn.Location = new System.Drawing.Point(28, 325);
            this.victoryReturnbtn.Name = "victoryReturnbtn";
            this.victoryReturnbtn.Size = new System.Drawing.Size(173, 100);
            this.victoryReturnbtn.TabIndex = 17;
            this.victoryReturnbtn.Text = "RETURN TO MAIN MENU";
            this.victoryReturnbtn.UseVisualStyleBackColor = false;
            this.victoryReturnbtn.Click += new System.EventHandler(this.victoryReturnbtn_Click);
            // 
            // victorylbl
            // 
            this.victorylbl.AutoSize = true;
            this.victorylbl.BackColor = System.Drawing.Color.Transparent;
            this.victorylbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victorylbl.ForeColor = System.Drawing.Color.White;
            this.victorylbl.Location = new System.Drawing.Point(175, 90);
            this.victorylbl.Name = "victorylbl";
            this.victorylbl.Size = new System.Drawing.Size(582, 39);
            this.victorylbl.TabIndex = 18;
            this.victorylbl.Text = "YOU HAVE ACHIEVED THE CROWN OF GLORY!";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Yellow;
            this.lblscore.Location = new System.Drawing.Point(12, 171);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(110, 29);
            this.lblscore.TabIndex = 19;
            this.lblscore.Text = "SCORE:";
            this.lblscore.Click += new System.EventHandler(this.lblscore_Click);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLeaderboard.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard.ForeColor = System.Drawing.Color.Yellow;
            this.btnLeaderboard.Location = new System.Drawing.Point(687, 325);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(173, 100);
            this.btnLeaderboard.TabIndex = 20;
            this.btnLeaderboard.Text = "LEADERBOARD";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // lblPlayMinigame
            // 
            this.lblPlayMinigame.AutoSize = true;
            this.lblPlayMinigame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlayMinigame.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayMinigame.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayMinigame.Location = new System.Drawing.Point(42, 63);
            this.lblPlayMinigame.Name = "lblPlayMinigame";
            this.lblPlayMinigame.Size = new System.Drawing.Size(818, 36);
            this.lblPlayMinigame.TabIndex = 22;
            this.lblPlayMinigame.Text = "HAVING COMPLETED THE GAME, WOULD YOU LIKE TO TRY BRAWLERz RUN?";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNo.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Yellow;
            this.btnNo.Location = new System.Drawing.Point(77, 304);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(173, 100);
            this.btnNo.TabIndex = 23;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYes.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.Yellow;
            this.btnYes.Location = new System.Drawing.Point(669, 304);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(173, 100);
            this.btnYes.TabIndex = 24;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // pictureChibi
            // 
            this.pictureChibi.BackColor = System.Drawing.Color.Transparent;
            this.pictureChibi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureChibi.BackgroundImage")));
            this.pictureChibi.Location = new System.Drawing.Point(321, 154);
            this.pictureChibi.Name = "pictureChibi";
            this.pictureChibi.Size = new System.Drawing.Size(285, 282);
            this.pictureChibi.TabIndex = 25;
            this.pictureChibi.TabStop = false;
            // 
            // CrownOfGlory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 461);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.pictureChibi);
            this.Controls.Add(this.lblPlayMinigame);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.victorylbl);
            this.Controls.Add(this.victoryReturnbtn);
            this.Controls.Add(this.btnLeaderboard);
            this.Name = "CrownOfGlory";
            this.Opacity = 0D;
            this.Text = "CrownOfGlory";
            this.Load += new System.EventHandler(this.CrownOfGlory_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CrownOfGlory_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureChibi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button victoryReturnbtn;
        private System.Windows.Forms.Label victorylbl;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Label lblPlayMinigame;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.PictureBox pictureChibi;
    }
}