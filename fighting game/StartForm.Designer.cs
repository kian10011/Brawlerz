namespace fighting_game
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.RegisterButton = new System.Windows.Forms.Button();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(100, 261);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(228, 79);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "REGISTER";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.Loginbutton.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Loginbutton.Location = new System.Drawing.Point(477, 261);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(228, 79);
            this.Loginbutton.TabIndex = 1;
            this.Loginbutton.Text = "LOGIN";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::fighting_game.Properties.Resources.gameTitle;
            this.pictureBox1.Location = new System.Drawing.Point(220, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 123);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(90, 371);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 3;
            this.WMP.Enter += new System.EventHandler(this.WMP_Enter);
            // 
            // StartForm
            // 
            this.BackgroundImage = global::fighting_game.Properties.Resources.d25s3h1_7c669e93_277d_47b8_a3aa_d97aea5abd96;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.RegisterButton);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
    }
}

