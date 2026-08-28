namespace fighting_game
{
    partial class Options
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
            this.panBrawler = new System.Windows.Forms.Panel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.selectCharlbl = new System.Windows.Forms.Label();
            this.char4panel = new System.Windows.Forms.Panel();
            this.char3panel = new System.Windows.Forms.Panel();
            this.char2panel = new System.Windows.Forms.Panel();
            this.char1panel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblCharName = new System.Windows.Forms.Label();
            this.char1panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBrawler
            // 
            this.panBrawler.BackColor = System.Drawing.Color.Transparent;
            this.panBrawler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panBrawler.Location = new System.Drawing.Point(312, 62);
            this.panBrawler.Name = "panBrawler";
            this.panBrawler.Size = new System.Drawing.Size(166, 225);
            this.panBrawler.TabIndex = 4;
            this.panBrawler.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panBrawler.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.panBrawler.Paint += new System.Windows.Forms.PaintEventHandler(this.panBrawler_Paint);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Black;
            this.btnEnter.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(334, 367);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(122, 57);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "ENTER THE GAME!";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click_1);
            // 
            // selectCharlbl
            // 
            this.selectCharlbl.AutoSize = true;
            this.selectCharlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCharlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectCharlbl.Location = new System.Drawing.Point(190, 9);
            this.selectCharlbl.Name = "selectCharlbl";
            this.selectCharlbl.Size = new System.Drawing.Size(422, 20);
            this.selectCharlbl.TabIndex = 6;
            this.selectCharlbl.Text = "DRAG SELECTED CHARACTER TO THE CENTER!";
            // 
            // char4panel
            // 
            this.char4panel.BackColor = System.Drawing.Color.Transparent;
            this.char4panel.BackgroundImage = global::fighting_game.Properties.Resources.char4;
            this.char4panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.char4panel.Location = new System.Drawing.Point(630, 308);
            this.char4panel.Name = "char4panel";
            this.char4panel.Size = new System.Drawing.Size(138, 130);
            this.char4panel.TabIndex = 3;
            this.char4panel.Tag = "3";
            this.char4panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // char3panel
            // 
            this.char3panel.BackColor = System.Drawing.Color.Transparent;
            this.char3panel.BackgroundImage = global::fighting_game.Properties.Resources.char3;
            this.char3panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.char3panel.Location = new System.Drawing.Point(21, 308);
            this.char3panel.Name = "char3panel";
            this.char3panel.Size = new System.Drawing.Size(129, 130);
            this.char3panel.TabIndex = 2;
            this.char3panel.Tag = "2";
            this.char3panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // char2panel
            // 
            this.char2panel.BackColor = System.Drawing.Color.Transparent;
            this.char2panel.BackgroundImage = global::fighting_game.Properties.Resources.char2Idle;
            this.char2panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.char2panel.Location = new System.Drawing.Point(630, 22);
            this.char2panel.Name = "char2panel";
            this.char2panel.Size = new System.Drawing.Size(138, 142);
            this.char2panel.TabIndex = 1;
            this.char2panel.Tag = "1";
            this.char2panel.Paint += new System.Windows.Forms.PaintEventHandler(this.char2panel_Paint);
            this.char2panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // char1panel
            // 
            this.char1panel.BackColor = System.Drawing.Color.Transparent;
            this.char1panel.BackgroundImage = global::fighting_game.Properties.Resources.char1;
            this.char1panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.char1panel.Controls.Add(this.panel9);
            this.char1panel.Location = new System.Drawing.Point(21, 22);
            this.char1panel.Name = "char1panel";
            this.char1panel.Size = new System.Drawing.Size(129, 142);
            this.char1panel.TabIndex = 0;
            this.char1panel.Tag = "0";
            this.char1panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(173, 96);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 1;
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCharName.Location = new System.Drawing.Point(308, 308);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(59, 20);
            this.lblCharName.TabIndex = 7;
            this.lblCharName.Text = "NAME";
            // 
            // Options
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCharName);
            this.Controls.Add(this.selectCharlbl);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.panBrawler);
            this.Controls.Add(this.char4panel);
            this.Controls.Add(this.char3panel);
            this.Controls.Add(this.char2panel);
            this.Controls.Add(this.char1panel);
            this.Name = "Options";
            this.Load += new System.EventHandler(this.Options_Load_1);
            this.char1panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel char1panel;
        private System.Windows.Forms.Panel char2panel;
        private System.Windows.Forms.Panel char3panel;
        private System.Windows.Forms.Panel char4panel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panBrawler;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label selectCharlbl;
        private System.Windows.Forms.Label lblCharName;
    }
}