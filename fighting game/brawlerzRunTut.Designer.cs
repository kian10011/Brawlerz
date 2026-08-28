
namespace fighting_game
{
    partial class brawlerzRunTut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(brawlerzRunTut));
            this.textboxHowToPlay = new System.Windows.Forms.TextBox();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxHowToPlay
            // 
            this.textboxHowToPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textboxHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxHowToPlay.ForeColor = System.Drawing.Color.Yellow;
            this.textboxHowToPlay.Location = new System.Drawing.Point(164, 139);
            this.textboxHowToPlay.Multiline = true;
            this.textboxHowToPlay.Name = "textboxHowToPlay";
            this.textboxHowToPlay.ReadOnly = true;
            this.textboxHowToPlay.Size = new System.Drawing.Size(473, 172);
            this.textboxHowToPlay.TabIndex = 29;
            this.textboxHowToPlay.Text = resources.GetString("textboxHowToPlay.Text");
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitGame.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.ForeColor = System.Drawing.Color.Yellow;
            this.btnExitGame.Location = new System.Drawing.Point(12, 338);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(173, 100);
            this.btnExitGame.TabIndex = 31;
            this.btnExitGame.Text = "EXIT";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStartGame.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.Yellow;
            this.btnStartGame.Location = new System.Drawing.Point(606, 338);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(173, 100);
            this.btnStartGame.TabIndex = 32;
            this.btnStartGame.Text = "START";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::fighting_game.Properties.Resources.minigame_BG1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 452);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // brawlerzRunTut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.textboxHowToPlay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "brawlerzRunTut";
            this.Text = "brawlerzRunTut";
            this.Load += new System.EventHandler(this.brawlerzRunTut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxHowToPlay;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}