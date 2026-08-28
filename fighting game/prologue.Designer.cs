namespace fighting_game
{
    partial class prologue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prologue));
            this.timerTransition = new System.Windows.Forms.Timer(this.components);
            this.textBoxPrologue1 = new System.Windows.Forms.TextBox();
            this.timerPrologue = new System.Windows.Forms.Timer(this.components);
            this.timerTransOut = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTransition
            // 
            this.timerTransition.Enabled = true;
            this.timerTransition.Tick += new System.EventHandler(this.timerTransition_Tick);
            // 
            // textBoxPrologue1
            // 
            this.textBoxPrologue1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxPrologue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrologue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxPrologue1.Location = new System.Drawing.Point(0, 311);
            this.textBoxPrologue1.Multiline = true;
            this.textBoxPrologue1.Name = "textBoxPrologue1";
            this.textBoxPrologue1.ReadOnly = true;
            this.textBoxPrologue1.Size = new System.Drawing.Size(798, 137);
            this.textBoxPrologue1.TabIndex = 14;
            // 
            // timerPrologue
            // 
            this.timerPrologue.Enabled = true;
            this.timerPrologue.Interval = 50;
            this.timerPrologue.Tick += new System.EventHandler(this.timerPrologue_Tick);
            // 
            // timerTransOut
            // 
            this.timerTransOut.Enabled = true;
            this.timerTransOut.Tick += new System.EventHandler(this.timerTransOut_Tick);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(680, 265);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 40);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.Black;
            this.btnSkip.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(12, 265);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(108, 40);
            this.btnSkip.TabIndex = 16;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.BackColor = System.Drawing.Color.Black;
            this.btnNext2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext2.ForeColor = System.Drawing.Color.White;
            this.btnNext2.Location = new System.Drawing.Point(680, 265);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(108, 40);
            this.btnNext2.TabIndex = 17;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = false;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(24, 13);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(75, 23);
            this.WMP.TabIndex = 18;
            // 
            // prologue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.textBoxPrologue1);
            this.Controls.Add(this.btnNext2);
            this.Name = "prologue";
            this.Opacity = 0D;
            this.Text = "prologue";
            this.Load += new System.EventHandler(this.prologue_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.prologue_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerTransition;
        private System.Windows.Forms.TextBox textBoxPrologue1;
        private System.Windows.Forms.Timer timerPrologue;
        private System.Windows.Forms.Timer timerTransOut;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnNext2;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
    }
}