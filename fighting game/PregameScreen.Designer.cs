
namespace fighting_game
{
    partial class PregameScreen
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbllevel = new System.Windows.Forms.Label();
            this.nextEnemylbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.BackColor = System.Drawing.Color.Black;
            this.lbllevel.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllevel.ForeColor = System.Drawing.Color.Purple;
            this.lbllevel.Location = new System.Drawing.Point(588, 147);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(0, 80);
            this.lbllevel.TabIndex = 0;
            // 
            // nextEnemylbl
            // 
            this.nextEnemylbl.AutoSize = true;
            this.nextEnemylbl.BackColor = System.Drawing.Color.Transparent;
            this.nextEnemylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextEnemylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nextEnemylbl.Location = new System.Drawing.Point(114, 147);
            this.nextEnemylbl.Name = "nextEnemylbl";
            this.nextEnemylbl.Size = new System.Drawing.Size(154, 24);
            this.nextEnemylbl.TabIndex = 7;
            this.nextEnemylbl.Text = "Next opponent:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Move towards the door to start brawling!";
            // 
            // PregameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextEnemylbl);
            this.Controls.Add(this.lbllevel);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "PregameScreen";
            this.Text = "PregameScreen";
            this.Load += new System.EventHandler(this.PregameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PregameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.Label nextEnemylbl;
        private System.Windows.Forms.Label label1;
    }
}