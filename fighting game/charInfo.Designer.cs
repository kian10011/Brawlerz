using System.Runtime.CompilerServices;

namespace fighting_game
{
    partial class charInfo
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
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.btnGeneralInfo = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBrawler = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.textboxCharInfo = new System.Windows.Forms.TextBox();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBrawler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.BackColor = System.Drawing.Color.Black;
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(34, 322);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(160, 87);
            this.btnReturnToMainMenu.TabIndex = 6;
            this.btnReturnToMainMenu.Text = "RETURN TO MAIN MENU";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGeneralInfo
            // 
            this.btnGeneralInfo.BackColor = System.Drawing.Color.Black;
            this.btnGeneralInfo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralInfo.ForeColor = System.Drawing.Color.White;
            this.btnGeneralInfo.Location = new System.Drawing.Point(574, 61);
            this.btnGeneralInfo.Name = "btnGeneralInfo";
            this.btnGeneralInfo.Size = new System.Drawing.Size(160, 87);
            this.btnGeneralInfo.TabIndex = 8;
            this.btnGeneralInfo.Text = "ABOUT CHARACTER";
            this.btnGeneralInfo.UseVisualStyleBackColor = false;
            this.btnGeneralInfo.Click += new System.EventHandler(this.btnGeneralInfo_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.Black;
            this.btnStats.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.Location = new System.Drawing.Point(574, 242);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(160, 87);
            this.btnStats.TabIndex = 9;
            this.btnStats.Text = "STATS";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(6, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 31);
            this.lblName.TabIndex = 10;
            // 
            // pictureBrawler
            // 
            this.pictureBrawler.BackColor = System.Drawing.Color.Transparent;
            this.pictureBrawler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBrawler.Location = new System.Drawing.Point(110, 61);
            this.pictureBrawler.Name = "pictureBrawler";
            this.pictureBrawler.Size = new System.Drawing.Size(190, 293);
            this.pictureBrawler.TabIndex = 7;
            this.pictureBrawler.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(34, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 68);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // textboxCharInfo
            // 
            this.textboxCharInfo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textboxCharInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCharInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textboxCharInfo.Location = new System.Drawing.Point(306, 71);
            this.textboxCharInfo.Multiline = true;
            this.textboxCharInfo.Name = "textboxCharInfo";
            this.textboxCharInfo.ReadOnly = true;
            this.textboxCharInfo.Size = new System.Drawing.Size(473, 283);
            this.textboxCharInfo.TabIndex = 13;
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStrength.Location = new System.Drawing.Point(306, 71);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(140, 24);
            this.lblStrength.TabIndex = 14;
            this.lblStrength.Text = "STRENGTH : ";
            // 
            // lblAgility
            // 
            this.lblAgility.AutoSize = true;
            this.lblAgility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAgility.Location = new System.Drawing.Point(306, 202);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(98, 24);
            this.lblAgility.TabIndex = 15;
            this.lblAgility.Text = "AGILITY :";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHealth.Location = new System.Drawing.Point(306, 322);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(104, 24);
            this.lblHealth.TabIndex = 16;
            this.lblHealth.Text = "HEALTH :";
            // 
            // charInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblAgility);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnGeneralInfo);
            this.Controls.Add(this.pictureBrawler);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.textboxCharInfo);
            this.Name = "charInfo";
            this.Text = "charInfo";
            this.Load += new System.EventHandler(this.charInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBrawler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.PictureBox pictureBrawler;
        private System.Windows.Forms.Button btnGeneralInfo;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textboxCharInfo;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblHealth;
    }
    
}