namespace fighting_game
{
    partial class brawlerzRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(brawlerzRun));
            this.lblscore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resumebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.obst2 = new System.Windows.Forms.PictureBox();
            this.obst1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxChar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bgMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.obst2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obst1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Transparent;
            this.lblscore.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(12, 9);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(78, 29);
            this.lblscore.TabIndex = 3;
            this.lblscore.Text = "score: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resumebtn
            // 
            this.resumebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resumebtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumebtn.ForeColor = System.Drawing.Color.Yellow;
            this.resumebtn.Location = new System.Drawing.Point(312, 98);
            this.resumebtn.Name = "resumebtn";
            this.resumebtn.Size = new System.Drawing.Size(173, 100);
            this.resumebtn.TabIndex = 11;
            this.resumebtn.Text = "RESUME";
            this.resumebtn.UseVisualStyleBackColor = false;
            this.resumebtn.Click += new System.EventHandler(this.resumebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.Yellow;
            this.exitbtn.Location = new System.Drawing.Point(312, 251);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(173, 100);
            this.exitbtn.TabIndex = 13;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // obst2
            // 
            this.obst2.BackColor = System.Drawing.Color.Transparent;
            this.obst2.BackgroundImage = global::fighting_game.Properties.Resources.deviantart_tree_removebg_preview;
            this.obst2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obst2.Location = new System.Drawing.Point(708, 372);
            this.obst2.Name = "obst2";
            this.obst2.Size = new System.Drawing.Size(32, 54);
            this.obst2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obst2.TabIndex = 5;
            this.obst2.TabStop = false;
            this.obst2.Tag = "obstacle";
            // 
            // obst1
            // 
            this.obst1.BackColor = System.Drawing.Color.Transparent;
            this.obst1.BackgroundImage = global::fighting_game.Properties.Resources.barrel;
            this.obst1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obst1.Location = new System.Drawing.Point(503, 397);
            this.obst1.Name = "obst1";
            this.obst1.Size = new System.Drawing.Size(38, 29);
            this.obst1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obst1.TabIndex = 4;
            this.obst1.TabStop = false;
            this.obst1.Tag = "obstacle";
            // 
            // pictureBoxChar
            // 
            this.pictureBoxChar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChar.Image = global::fighting_game.Properties.Resources.chibiChar4;
            this.pictureBoxChar.Location = new System.Drawing.Point(48, 346);
            this.pictureBoxChar.Name = "pictureBoxChar";
            this.pictureBoxChar.Size = new System.Drawing.Size(76, 80);
            this.pictureBoxChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxChar.TabIndex = 1;
            this.pictureBoxChar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::fighting_game.Properties.Resources.minigame_BG1;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 452);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ground
            // 
            this.ground.Location = new System.Drawing.Point(-5, 424);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(804, 29);
            this.ground.TabIndex = 6;
            this.ground.TabStop = false;
            // 
            // bgMusicPlayer
            // 
            this.bgMusicPlayer.Enabled = true;
            this.bgMusicPlayer.Location = new System.Drawing.Point(640, 328);
            this.bgMusicPlayer.Name = "bgMusicPlayer";
            this.bgMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bgMusicPlayer.OcxState")));
            this.bgMusicPlayer.Size = new System.Drawing.Size(75, 23);
            this.bgMusicPlayer.TabIndex = 20;
            this.bgMusicPlayer.Visible = false;
            // 
            // brawlerzRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bgMusicPlayer);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.resumebtn);
            this.Controls.Add(this.obst2);
            this.Controls.Add(this.obst1);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.pictureBoxChar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ground);
            this.Name = "brawlerzRun";
            this.Text = "brawlerzRun";
            this.Load += new System.EventHandler(this.brawlerzRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brawlerzRun_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.brawlerzRun_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.obst2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obst1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMusicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxChar;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.PictureBox obst1;
        private System.Windows.Forms.PictureBox obst2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Button resumebtn;
        private System.Windows.Forms.Button exitbtn;
        private AxWMPLib.AxWindowsMediaPlayer bgMusicPlayer;
    }
}