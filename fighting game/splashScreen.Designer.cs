namespace fighting_game
{
    partial class splashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.splashTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 473);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(29, 380);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(735, 38);
            this.progressBar.TabIndex = 1;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // splashTimer
            // 
            this.splashTimer.Enabled = true;
            this.splashTimer.Tick += new System.EventHandler(this.splashTimer_Tick);
            // 
            // pictureTitle
            // 
            this.pictureTitle.BackgroundImage = global::fighting_game.Properties.Resources.gameTitle;
            this.pictureTitle.Location = new System.Drawing.Point(230, 135);
            this.pictureTitle.Name = "pictureTitle";
            this.pictureTitle.Size = new System.Drawing.Size(342, 128);
            this.pictureTitle.TabIndex = 2;
            this.pictureTitle.TabStop = false;
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureTitle);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "splashScreen";
            this.Text = "splashScreen";
            this.Load += new System.EventHandler(this.splashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer splashTimer;
        private System.Windows.Forms.PictureBox pictureTitle;
    }
}