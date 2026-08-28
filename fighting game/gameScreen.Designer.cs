namespace fighting_game
{
    partial class gameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameScreen));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.resumebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.defeatlbl = new System.Windows.Forms.Label();
            this.defeatReturnbtn = new System.Windows.Forms.Button();
            this.victorylbl = new System.Windows.Forms.Label();
            this.victoryReturnbtn = new System.Windows.Forms.Button();
            this.victoryContinuebtn = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // resumebtn
            // 
            this.resumebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resumebtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumebtn.ForeColor = System.Drawing.Color.Yellow;
            this.resumebtn.Location = new System.Drawing.Point(345, 117);
            this.resumebtn.Name = "resumebtn";
            this.resumebtn.Size = new System.Drawing.Size(173, 100);
            this.resumebtn.TabIndex = 10;
            this.resumebtn.Text = "RESUME";
            this.resumebtn.UseVisualStyleBackColor = false;
            this.resumebtn.Click += new System.EventHandler(this.resumebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitbtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.Yellow;
            this.exitbtn.Location = new System.Drawing.Point(345, 272);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(173, 100);
            this.exitbtn.TabIndex = 12;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // defeatlbl
            // 
            this.defeatlbl.AutoSize = true;
            this.defeatlbl.BackColor = System.Drawing.Color.Transparent;
            this.defeatlbl.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defeatlbl.ForeColor = System.Drawing.Color.Black;
            this.defeatlbl.Location = new System.Drawing.Point(286, 79);
            this.defeatlbl.Name = "defeatlbl";
            this.defeatlbl.Size = new System.Drawing.Size(246, 80);
            this.defeatlbl.TabIndex = 13;
            this.defeatlbl.Text = "DEFEAT...";
            // 
            // defeatReturnbtn
            // 
            this.defeatReturnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.defeatReturnbtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defeatReturnbtn.ForeColor = System.Drawing.Color.Yellow;
            this.defeatReturnbtn.Location = new System.Drawing.Point(35, 286);
            this.defeatReturnbtn.Name = "defeatReturnbtn";
            this.defeatReturnbtn.Size = new System.Drawing.Size(173, 100);
            this.defeatReturnbtn.TabIndex = 14;
            this.defeatReturnbtn.Text = "return to main menu";
            this.defeatReturnbtn.UseVisualStyleBackColor = false;
            this.defeatReturnbtn.Click += new System.EventHandler(this.defeatReturnbtn_Click);
            // 
            // victorylbl
            // 
            this.victorylbl.AutoSize = true;
            this.victorylbl.BackColor = System.Drawing.Color.Transparent;
            this.victorylbl.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victorylbl.ForeColor = System.Drawing.Color.White;
            this.victorylbl.Location = new System.Drawing.Point(286, 79);
            this.victorylbl.Name = "victorylbl";
            this.victorylbl.Size = new System.Drawing.Size(273, 80);
            this.victorylbl.TabIndex = 15;
            this.victorylbl.Text = "VICTORY!";
            // 
            // victoryReturnbtn
            // 
            this.victoryReturnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.victoryReturnbtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryReturnbtn.ForeColor = System.Drawing.Color.Yellow;
            this.victoryReturnbtn.Location = new System.Drawing.Point(35, 286);
            this.victoryReturnbtn.Name = "victoryReturnbtn";
            this.victoryReturnbtn.Size = new System.Drawing.Size(173, 100);
            this.victoryReturnbtn.TabIndex = 16;
            this.victoryReturnbtn.Text = "RETURN TO MAIN MENU";
            this.victoryReturnbtn.UseVisualStyleBackColor = false;
            this.victoryReturnbtn.Click += new System.EventHandler(this.victoryReturnbtn_Click);
            // 
            // victoryContinuebtn
            // 
            this.victoryContinuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.victoryContinuebtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryContinuebtn.ForeColor = System.Drawing.Color.Yellow;
            this.victoryContinuebtn.Location = new System.Drawing.Point(574, 286);
            this.victoryContinuebtn.Name = "victoryContinuebtn";
            this.victoryContinuebtn.Size = new System.Drawing.Size(173, 100);
            this.victoryContinuebtn.TabIndex = 17;
            this.victoryContinuebtn.Text = "CONTINUE TO NEXT LEVEL";
            this.victoryContinuebtn.UseVisualStyleBackColor = false;
            this.victoryContinuebtn.Click += new System.EventHandler(this.victoryContinuebtn_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Yellow;
            this.lblscore.Location = new System.Drawing.Point(267, 188);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(110, 29);
            this.lblscore.TabIndex = 18;
            this.lblscore.Text = "SCORE:";
            this.lblscore.Click += new System.EventHandler(this.lblscore_Click);
            // 
            // WMP
            
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(2, 415);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 19;
            this.WMP.Enter += new System.EventHandler(this.WMP_Enter);
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.Color.MintCream;
            this.lblPlayerHealth.Location = new System.Drawing.Point(10, 9);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(67, 26);
            this.lblPlayerHealth.TabIndex = 20;
            this.lblPlayerHealth.Text = "Player";
            this.lblPlayerHealth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyHealth.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealth.ForeColor = System.Drawing.Color.MintCream;
            this.lblEnemyHealth.Location = new System.Drawing.Point(492, 9);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(67, 26);
            this.lblEnemyHealth.TabIndex = 21;
            this.lblEnemyHealth.Text = "Enemy";
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnemyHealth);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.victoryContinuebtn);
            this.Controls.Add(this.victoryReturnbtn);
            this.Controls.Add(this.defeatReturnbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.resumebtn);
            this.Controls.Add(this.victorylbl);
            this.Controls.Add(this.defeatlbl);
            this.Name = "gameScreen";
            this.Text = "gameScreen";
            this.Load += new System.EventHandler(this.gameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button resumebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label defeatlbl;
        private System.Windows.Forms.Button defeatReturnbtn;
        private System.Windows.Forms.Label victorylbl;
        private System.Windows.Forms.Button victoryReturnbtn;
        private System.Windows.Forms.Button victoryContinuebtn;
        private System.Windows.Forms.Label lblscore;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblEnemyHealth;
    }
}