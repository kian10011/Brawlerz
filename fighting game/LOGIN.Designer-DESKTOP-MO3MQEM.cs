namespace fighting_game
{
    partial class LOGIN
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
            this.btn_ConfLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ConfLogin
            // 
            this.btn_ConfLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ConfLogin.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfLogin.ForeColor = System.Drawing.Color.White;
            this.btn_ConfLogin.Location = new System.Drawing.Point(517, 305);
            this.btn_ConfLogin.Name = "btn_ConfLogin";
            this.btn_ConfLogin.Size = new System.Drawing.Size(271, 118);
            this.btn_ConfLogin.TabIndex = 0;
            this.btn_ConfLogin.Text = "LOGIN!";
            this.btn_ConfLogin.UseVisualStyleBackColor = false;
            this.btn_ConfLogin.Click += new System.EventHandler(this.btn_ConfLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Password:";
            // 
            // tbxUser
            // 
            this.tbxUser.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(12, 137);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(456, 36);
            this.tbxUser.TabIndex = 3;
            // 
            // tbxPass
            // 
            this.tbxPass.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.Location = new System.Drawing.Point(12, 263);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(456, 36);
            this.tbxPass.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::fighting_game.Properties.Resources.coollogo_com_165314877;
            this.pictureBox1.Location = new System.Drawing.Point(463, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 129);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfRegister
            // 
            this.btnConfRegister.BackColor = System.Drawing.Color.Black;
            this.btnConfRegister.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfRegister.ForeColor = System.Drawing.Color.White;
            this.btnConfRegister.Location = new System.Drawing.Point(517, 150);
            this.btnConfRegister.Name = "btnConfRegister";
            this.btnConfRegister.Size = new System.Drawing.Size(271, 123);
            this.btnConfRegister.TabIndex = 6;
            this.btnConfRegister.Text = "REGISTER!";
            this.btnConfRegister.UseVisualStyleBackColor = false;
            this.btnConfRegister.Click += new System.EventHandler(this.btnConfRegister_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fighting_game.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfRegister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConfLogin);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConfLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfRegister;
    }
}