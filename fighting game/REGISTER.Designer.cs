namespace fighting_game
{
    partial class REGISTER
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
            this.tbxUser1 = new System.Windows.Forms.TextBox();
            this.tbxPass1 = new System.Windows.Forms.TextBox();
            this.tbxConfPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSendLog = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUser1
            // 
            this.tbxUser1.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser1.Location = new System.Drawing.Point(23, 84);
            this.tbxUser1.Name = "tbxUser1";
            this.tbxUser1.Size = new System.Drawing.Size(307, 36);
            this.tbxUser1.TabIndex = 0;
            this.tbxUser1.TextChanged += new System.EventHandler(this.tbxUser1_TextChanged);
            // 
            // tbxPass1
            // 
            this.tbxPass1.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass1.Location = new System.Drawing.Point(23, 168);
            this.tbxPass1.Name = "tbxPass1";
            this.tbxPass1.PasswordChar = '*';
            this.tbxPass1.Size = new System.Drawing.Size(307, 36);
            this.tbxPass1.TabIndex = 1;
            this.tbxPass1.UseSystemPasswordChar = true;
            // 
            // tbxConfPass
            // 
            this.tbxConfPass.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfPass.Location = new System.Drawing.Point(23, 252);
            this.tbxConfPass.Name = "tbxConfPass";
            this.tbxConfPass.PasswordChar = '*';
            this.tbxConfPass.Size = new System.Drawing.Size(307, 36);
            this.tbxConfPass.TabIndex = 2;
            this.tbxConfPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "ENTER USERNAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "CREATE A PASSWORD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "CONFIRM PASSWORD:";
            // 
            // btnSendLog
            // 
            this.btnSendLog.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendLog.Location = new System.Drawing.Point(578, 202);
            this.btnSendLog.Name = "btnSendLog";
            this.btnSendLog.Size = new System.Drawing.Size(192, 100);
            this.btnSendLog.TabIndex = 7;
            this.btnSendLog.Text = "ALREADY AN EXISTING USER? LOGIN!";
            this.btnSendLog.UseVisualStyleBackColor = true;
            this.btnSendLog.Click += new System.EventHandler(this.btnSendLog_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(578, 339);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(192, 99);
            this.btnReg.TabIndex = 8;
            this.btnReg.Text = "REGISTER!";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // REGISTER
            // 
            this.BackgroundImage = global::fighting_game.Properties.Resources.d25s3h1_7c669e93_277d_47b8_a3aa_d97aea5abd96;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnSendLog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxConfPass);
            this.Controls.Add(this.tbxPass1);
            this.Controls.Add(this.tbxUser1);
            this.Name = "REGISTER";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.REGISTER_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.TextBox tbxConf;
        private System.Windows.Forms.Button btnConfRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxUser1;
        private System.Windows.Forms.TextBox tbxPass1;
        private System.Windows.Forms.TextBox tbxConfPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendLog;
        private System.Windows.Forms.Button btnReg;
    }
}