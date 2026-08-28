
namespace fighting_game
{
    partial class LeaderBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderBoard));
            this.btnMenu = new System.Windows.Forms.Button();
            this.tableScores = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblScores = new System.Windows.Forms.Label();
            this.bgMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.tableScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenu.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Yellow;
            this.btnMenu.Location = new System.Drawing.Point(12, 383);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(219, 70);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "MAIN MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // tableScores
            // 
            this.tableScores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Score,
            this.Rounds});
            this.tableScores.GridColor = System.Drawing.Color.Black;
            this.tableScores.Location = new System.Drawing.Point(93, 12);
            this.tableScores.Name = "tableScores";
            this.tableScores.Size = new System.Drawing.Size(644, 348);
            this.tableScores.TabIndex = 1;
            this.tableScores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableScores_CellContentClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 200;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.Width = 200;
            // 
            // Rounds
            // 
            this.Rounds.HeaderText = "Rounds";
            this.Rounds.Name = "Rounds";
            this.Rounds.ReadOnly = true;
            this.Rounds.Width = 200;
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblScores.Location = new System.Drawing.Point(248, 177);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(322, 25);
            this.lblScores.TabIndex = 2;
            this.lblScores.Text = "No scores have been found...";
            this.lblScores.Click += new System.EventHandler(this.lblScores_Click);
            // 
            // bgMusicPlayer
            // 
            this.bgMusicPlayer.Enabled = true;
            this.bgMusicPlayer.Location = new System.Drawing.Point(385, 221);
            this.bgMusicPlayer.Name = "bgMusicPlayer";
            this.bgMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bgMusicPlayer.OcxState")));
            this.bgMusicPlayer.Size = new System.Drawing.Size(75, 23);
            this.bgMusicPlayer.TabIndex = 21;
            this.bgMusicPlayer.Visible = false;
            // 
            // LeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fighting_game.Properties.Resources.leaderboardbg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 465);
            this.Controls.Add(this.bgMusicPlayer);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.tableScores);
            this.Controls.Add(this.btnMenu);
            this.Name = "LeaderBoard";
            this.Text = "LeaderBoard";
            this.Load += new System.EventHandler(this.LeaderBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMusicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView tableScores;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rounds;
        private AxWMPLib.AxWindowsMediaPlayer bgMusicPlayer;
    }
}