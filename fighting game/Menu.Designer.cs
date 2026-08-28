
namespace fighting_game
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnScores = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupCurrentPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExtraModes = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnControls = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnCharInfo = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.moveforwardlbl = new System.Windows.Forms.Label();
            this.movebackwardlbl = new System.Windows.Forms.Label();
            this.lightkicklbl = new System.Windows.Forms.Label();
            this.lightpunchlbl = new System.Windows.Forms.Label();
            this.heavykicklbl = new System.Windows.Forms.Label();
            this.heavypunchlbl = new System.Windows.Forms.Label();
            this.pauselbl = new System.Windows.Forms.Label();
            this.interactlbl = new System.Windows.Forms.Label();
            this.backcontrolsbtn = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            this.textboxHowToPlay = new System.Windows.Forms.TextBox();
            this.spriteImageMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.menuBackground = new System.Windows.Forms.PictureBox();
            this.btnChooseTraining = new System.Windows.Forms.Button();
            this.btnChooseRun = new System.Windows.Forms.Button();
            this.backFromExtras = new System.Windows.Forms.Button();
            this.fireballlbl = new System.Windows.Forms.Label();
            this.IncVolume = new System.Windows.Forms.Button();
            this.DecVolume = new System.Windows.Forms.Button();
            this.lblHowToplay = new System.Windows.Forms.Label();
            this.bgMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblIncVolume = new System.Windows.Forms.Label();
            this.lblDecVolume = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteImageMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnScores.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.ForeColor = System.Drawing.Color.Yellow;
            this.btnScores.Location = new System.Drawing.Point(615, 349);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(185, 103);
            this.btnScores.TabIndex = 2;
            this.btnScores.Text = "LEADERBOARD";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(22, 149);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 31);
            this.lblWelcome.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(22, 203);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 31);
            this.lblTime.TabIndex = 4;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.Location = new System.Drawing.Point(22, 261);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(0, 31);
            this.lblRounds.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.optionsToolStripMenuItem.Text = "Choose Character";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storyToolStripMenuItem,
            this.controlsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // storyToolStripMenuItem
            // 
            this.storyToolStripMenuItem.Name = "storyToolStripMenuItem";
            this.storyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.storyToolStripMenuItem.Text = "How to play the game?";
            this.storyToolStripMenuItem.Click += new System.EventHandler(this.storyToolStripMenuItem_Click);
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.controlsToolStripMenuItem.Text = "Controls";
            this.controlsToolStripMenuItem.Click += new System.EventHandler(this.controlsToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupCurrentPlayerToolStripMenuItem,
            this.restoreBackupToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // backupCurrentPlayerToolStripMenuItem
            // 
            this.backupCurrentPlayerToolStripMenuItem.Name = "backupCurrentPlayerToolStripMenuItem";
            this.backupCurrentPlayerToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.backupCurrentPlayerToolStripMenuItem.Text = "Backup Current Player";
            this.backupCurrentPlayerToolStripMenuItem.Click += new System.EventHandler(this.backupCurrentPlayerToolStripMenuItem_Click);
            // 
            // restoreBackupToolStripMenuItem
            // 
            this.restoreBackupToolStripMenuItem.Name = "restoreBackupToolStripMenuItem";
            this.restoreBackupToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.restoreBackupToolStripMenuItem.Text = "Restore Player From Backup";
            this.restoreBackupToolStripMenuItem.Click += new System.EventHandler(this.restoreBackupToolStripMenuItem_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlay.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Gold;
            this.btnPlay.Location = new System.Drawing.Point(0, 347);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(179, 103);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExtraModes
            // 
            this.btnExtraModes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExtraModes.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraModes.ForeColor = System.Drawing.Color.Yellow;
            this.btnExtraModes.Location = new System.Drawing.Point(716, 231);
            this.btnExtraModes.Name = "btnExtraModes";
            this.btnExtraModes.Size = new System.Drawing.Size(84, 100);
            this.btnExtraModes.TabIndex = 8;
            this.btnExtraModes.Text = "Training / Minigame";
            this.btnExtraModes.UseVisualStyleBackColor = false;
            this.btnExtraModes.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSettings.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Yellow;
            this.btnSettings.Location = new System.Drawing.Point(716, 110);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(84, 100);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnControls
            // 
            this.btnControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnControls.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControls.ForeColor = System.Drawing.Color.Gold;
            this.btnControls.Location = new System.Drawing.Point(28, 189);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(239, 103);
            this.btnControls.TabIndex = 11;
            this.btnControls.Text = "CONTROLS";
            this.btnControls.UseVisualStyleBackColor = false;
            this.btnControls.Click += new System.EventHandler(this.btnControls_Click);
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSound.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.ForeColor = System.Drawing.Color.Gold;
            this.btnSound.Location = new System.Drawing.Point(511, 335);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(239, 103);
            this.btnSound.TabIndex = 12;
            this.btnSound.Text = "SOUND";
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnCharInfo
            // 
            this.btnCharInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCharInfo.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharInfo.ForeColor = System.Drawing.Color.Gold;
            this.btnCharInfo.Location = new System.Drawing.Point(511, 203);
            this.btnCharInfo.Name = "btnCharInfo";
            this.btnCharInfo.Size = new System.Drawing.Size(239, 103);
            this.btnCharInfo.TabIndex = 13;
            this.btnCharInfo.Text = "CHARACTER INFO";
            this.btnCharInfo.UseVisualStyleBackColor = false;
            this.btnCharInfo.Click += new System.EventHandler(this.btnCharInfo_Click);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReturnMenu.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.ForeColor = System.Drawing.Color.Gold;
            this.btnReturnMenu.Location = new System.Drawing.Point(28, 335);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(239, 103);
            this.btnReturnMenu.TabIndex = 14;
            this.btnReturnMenu.Text = "RETURN TO MAIN MENU";
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // moveforwardlbl
            // 
            this.moveforwardlbl.AutoSize = true;
            this.moveforwardlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moveforwardlbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveforwardlbl.ForeColor = System.Drawing.Color.Yellow;
            this.moveforwardlbl.Location = new System.Drawing.Point(12, 171);
            this.moveforwardlbl.Name = "moveforwardlbl";
            this.moveforwardlbl.Size = new System.Drawing.Size(272, 39);
            this.moveforwardlbl.TabIndex = 17;
            this.moveforwardlbl.Text = "MOVE FORWARDS - D";
            // 
            // movebackwardlbl
            // 
            this.movebackwardlbl.AutoSize = true;
            this.movebackwardlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movebackwardlbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movebackwardlbl.ForeColor = System.Drawing.Color.Yellow;
            this.movebackwardlbl.Location = new System.Drawing.Point(12, 221);
            this.movebackwardlbl.Name = "movebackwardlbl";
            this.movebackwardlbl.Size = new System.Drawing.Size(292, 39);
            this.movebackwardlbl.TabIndex = 18;
            this.movebackwardlbl.Text = "MOVE BACKWARDS - A";
            // 
            // lightkicklbl
            // 
            this.lightkicklbl.AutoSize = true;
            this.lightkicklbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightkicklbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightkicklbl.ForeColor = System.Drawing.Color.Yellow;
            this.lightkicklbl.Location = new System.Drawing.Point(478, 171);
            this.lightkicklbl.Name = "lightkicklbl";
            this.lightkicklbl.Size = new System.Drawing.Size(186, 39);
            this.lightkicklbl.TabIndex = 19;
            this.lightkicklbl.Text = "LIGHT KICK - I";
            // 
            // lightpunchlbl
            // 
            this.lightpunchlbl.AutoSize = true;
            this.lightpunchlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightpunchlbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightpunchlbl.ForeColor = System.Drawing.Color.Yellow;
            this.lightpunchlbl.Location = new System.Drawing.Point(478, 219);
            this.lightpunchlbl.Name = "lightpunchlbl";
            this.lightpunchlbl.Size = new System.Drawing.Size(220, 39);
            this.lightpunchlbl.TabIndex = 20;
            this.lightpunchlbl.Text = "LIGHT PUNCH - K";
            // 
            // heavykicklbl
            // 
            this.heavykicklbl.AutoSize = true;
            this.heavykicklbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.heavykicklbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heavykicklbl.ForeColor = System.Drawing.Color.Yellow;
            this.heavykicklbl.Location = new System.Drawing.Point(478, 261);
            this.heavykicklbl.Name = "heavykicklbl";
            this.heavykicklbl.Size = new System.Drawing.Size(201, 39);
            this.heavykicklbl.TabIndex = 21;
            this.heavykicklbl.Text = "HEAVY KICK - U";
            // 
            // heavypunchlbl
            // 
            this.heavypunchlbl.AutoSize = true;
            this.heavypunchlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.heavypunchlbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heavypunchlbl.ForeColor = System.Drawing.Color.Yellow;
            this.heavypunchlbl.Location = new System.Drawing.Point(478, 307);
            this.heavypunchlbl.Name = "heavypunchlbl";
            this.heavypunchlbl.Size = new System.Drawing.Size(220, 39);
            this.heavypunchlbl.TabIndex = 22;
            this.heavypunchlbl.Text = "HEAVY PUNCH - J";
            // 
            // pauselbl
            // 
            this.pauselbl.AutoSize = true;
            this.pauselbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pauselbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauselbl.ForeColor = System.Drawing.Color.Yellow;
            this.pauselbl.Location = new System.Drawing.Point(12, 280);
            this.pauselbl.Name = "pauselbl";
            this.pauselbl.Size = new System.Drawing.Size(369, 39);
            this.pauselbl.TabIndex = 23;
            this.pauselbl.Text = "OPTIONS / PAUSE - HOLD ESC";
            // 
            // interactlbl
            // 
            this.interactlbl.AutoSize = true;
            this.interactlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.interactlbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactlbl.ForeColor = System.Drawing.Color.Yellow;
            this.interactlbl.Location = new System.Drawing.Point(13, 335);
            this.interactlbl.Name = "interactlbl";
            this.interactlbl.Size = new System.Drawing.Size(291, 39);
            this.interactlbl.TabIndex = 24;
            this.interactlbl.Text = "INTERACT - LEFT CLICK";
            this.interactlbl.Click += new System.EventHandler(this.interactlbl_Click);
            // 
            // backcontrolsbtn
            // 
            this.backcontrolsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backcontrolsbtn.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backcontrolsbtn.ForeColor = System.Drawing.Color.Yellow;
            this.backcontrolsbtn.Location = new System.Drawing.Point(657, 396);
            this.backcontrolsbtn.Name = "backcontrolsbtn";
            this.backcontrolsbtn.Size = new System.Drawing.Size(143, 56);
            this.backcontrolsbtn.TabIndex = 25;
            this.backcontrolsbtn.Text = "BACK";
            this.backcontrolsbtn.UseVisualStyleBackColor = false;
            this.backcontrolsbtn.Click += new System.EventHandler(this.backcontrolsbtn_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Yellow;
            this.lblscore.Location = new System.Drawing.Point(12, 43);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(136, 20);
            this.lblscore.TabIndex = 26;
            this.lblscore.Text = "TOTAL SCORE:";
            this.lblscore.Click += new System.EventHandler(this.lblscore_Click);
            // 
            // textboxHowToPlay
            // 
            this.textboxHowToPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textboxHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxHowToPlay.ForeColor = System.Drawing.Color.Yellow;
            this.textboxHowToPlay.Location = new System.Drawing.Point(290, 155);
            this.textboxHowToPlay.Multiline = true;
            this.textboxHowToPlay.Name = "textboxHowToPlay";
            this.textboxHowToPlay.ReadOnly = true;
            this.textboxHowToPlay.Size = new System.Drawing.Size(473, 283);
            this.textboxHowToPlay.TabIndex = 27;
            this.textboxHowToPlay.Text = resources.GetString("textboxHowToPlay.Text");
            // 
            // spriteImageMenu
            // 
            this.spriteImageMenu.BackColor = System.Drawing.Color.Transparent;
            this.spriteImageMenu.Location = new System.Drawing.Point(405, 261);
            this.spriteImageMenu.Name = "spriteImageMenu";
            this.spriteImageMenu.Size = new System.Drawing.Size(100, 132);
            this.spriteImageMenu.TabIndex = 15;
            this.spriteImageMenu.TabStop = false;
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitle.BackgroundImage = global::fighting_game.Properties.Resources.gameTitle;
            this.pictureBoxTitle.Location = new System.Drawing.Point(232, 29);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(334, 123);
            this.pictureBoxTitle.TabIndex = 7;
            this.pictureBoxTitle.TabStop = false;
            // 
            // menuBackground
            // 
            this.menuBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBackground.Image = ((System.Drawing.Image)(resources.GetObject("menuBackground.Image")));
            this.menuBackground.Location = new System.Drawing.Point(0, 29);
            this.menuBackground.Name = "menuBackground";
            this.menuBackground.Size = new System.Drawing.Size(800, 423);
            this.menuBackground.TabIndex = 10;
            this.menuBackground.TabStop = false;
            this.menuBackground.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnChooseTraining
            // 
            this.btnChooseTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChooseTraining.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseTraining.ForeColor = System.Drawing.Color.Gold;
            this.btnChooseTraining.Location = new System.Drawing.Point(124, 245);
            this.btnChooseTraining.Name = "btnChooseTraining";
            this.btnChooseTraining.Size = new System.Drawing.Size(239, 103);
            this.btnChooseTraining.TabIndex = 28;
            this.btnChooseTraining.Text = "TRAINING";
            this.btnChooseTraining.UseVisualStyleBackColor = false;
            this.btnChooseTraining.Click += new System.EventHandler(this.btnChooseTraining_Click);
            // 
            // btnChooseRun
            // 
            this.btnChooseRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChooseRun.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseRun.ForeColor = System.Drawing.Color.Gold;
            this.btnChooseRun.Location = new System.Drawing.Point(440, 245);
            this.btnChooseRun.Name = "btnChooseRun";
            this.btnChooseRun.Size = new System.Drawing.Size(239, 103);
            this.btnChooseRun.TabIndex = 29;
            this.btnChooseRun.Text = "BRAWLERz RUN";
            this.btnChooseRun.UseVisualStyleBackColor = false;
            this.btnChooseRun.Click += new System.EventHandler(this.btnChooseRun_Click);
            // 
            // backFromExtras
            // 
            this.backFromExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backFromExtras.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backFromExtras.ForeColor = System.Drawing.Color.Gold;
            this.backFromExtras.Location = new System.Drawing.Point(0, 390);
            this.backFromExtras.Name = "backFromExtras";
            this.backFromExtras.Size = new System.Drawing.Size(191, 60);
            this.backFromExtras.TabIndex = 30;
            this.backFromExtras.Text = "BACK";
            this.backFromExtras.UseVisualStyleBackColor = false;
            this.backFromExtras.Click += new System.EventHandler(this.backFromExtras_Click);
            // 
            // fireballlbl
            // 
            this.fireballlbl.AutoSize = true;
            this.fireballlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fireballlbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireballlbl.ForeColor = System.Drawing.Color.Yellow;
            this.fireballlbl.Location = new System.Drawing.Point(459, 354);
            this.fireballlbl.Name = "fireballlbl";
            this.fireballlbl.Size = new System.Drawing.Size(255, 39);
            this.fireballlbl.TabIndex = 31;
            this.fireballlbl.Text = "SHOOT FIREBALL - R";
            // 
            // IncVolume
            // 
            this.IncVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IncVolume.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncVolume.ForeColor = System.Drawing.Color.Gold;
            this.IncVolume.Location = new System.Drawing.Point(124, 245);
            this.IncVolume.Name = "IncVolume";
            this.IncVolume.Size = new System.Drawing.Size(239, 103);
            this.IncVolume.TabIndex = 33;
            this.IncVolume.Text = "VOLUME ++";
            this.IncVolume.UseVisualStyleBackColor = false;
            this.IncVolume.Click += new System.EventHandler(this.IncVolume_Click);
            // 
            // DecVolume
            // 
            this.DecVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DecVolume.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecVolume.ForeColor = System.Drawing.Color.Gold;
            this.DecVolume.Location = new System.Drawing.Point(440, 248);
            this.DecVolume.Name = "DecVolume";
            this.DecVolume.Size = new System.Drawing.Size(239, 103);
            this.DecVolume.TabIndex = 34;
            this.DecVolume.Text = "VOLUME --";
            this.DecVolume.UseVisualStyleBackColor = false;
            this.DecVolume.Click += new System.EventHandler(this.DecVolume_Click);
            // 
            // lblHowToplay
            // 
            this.lblHowToplay.AutoSize = true;
            this.lblHowToplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHowToplay.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToplay.ForeColor = System.Drawing.Color.Yellow;
            this.lblHowToplay.Location = new System.Drawing.Point(16, 396);
            this.lblHowToplay.Name = "lblHowToplay";
            this.lblHowToplay.Size = new System.Drawing.Size(457, 23);
            this.lblHowToplay.TabIndex = 36;
            this.lblHowToplay.Text = "CLICK HELP ON TASKBAR  FOR INFO ON HOW TO PLAY THE GAME!";
            // 
            // bgMusicPlayer
            // 
            this.bgMusicPlayer.Enabled = true;
            this.bgMusicPlayer.Location = new System.Drawing.Point(466, 357);
            this.bgMusicPlayer.Name = "bgMusicPlayer";
            this.bgMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("bgMusicPlayer.OcxState")));
            this.bgMusicPlayer.Size = new System.Drawing.Size(75, 23);
            this.bgMusicPlayer.TabIndex = 35;
            // 
            // lblIncVolume
            // 
            this.lblIncVolume.AutoSize = true;
            this.lblIncVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIncVolume.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncVolume.ForeColor = System.Drawing.Color.Yellow;
            this.lblIncVolume.Location = new System.Drawing.Point(125, 203);
            this.lblIncVolume.Name = "lblIncVolume";
            this.lblIncVolume.Size = new System.Drawing.Size(142, 23);
            this.lblIncVolume.TabIndex = 37;
            this.lblIncVolume.Text = "INCREASE VOLUME";
            // 
            // lblDecVolume
            // 
            this.lblDecVolume.AutoSize = true;
            this.lblDecVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDecVolume.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecVolume.ForeColor = System.Drawing.Color.Yellow;
            this.lblDecVolume.Location = new System.Drawing.Point(436, 203);
            this.lblDecVolume.Name = "lblDecVolume";
            this.lblDecVolume.Size = new System.Drawing.Size(146, 23);
            this.lblDecVolume.TabIndex = 38;
            this.lblDecVolume.Text = "DECREASE VOLUME";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExtraModes);
            this.Controls.Add(this.lblDecVolume);
            this.Controls.Add(this.lblIncVolume);
            this.Controls.Add(this.heavykicklbl);
            this.Controls.Add(this.heavypunchlbl);
            this.Controls.Add(this.lblHowToplay);
            this.Controls.Add(this.movebackwardlbl);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.DecVolume);
            this.Controls.Add(this.IncVolume);
            this.Controls.Add(this.backcontrolsbtn);
            this.Controls.Add(this.fireballlbl);
            this.Controls.Add(this.backFromExtras);
            this.Controls.Add(this.btnChooseRun);
            this.Controls.Add(this.btnChooseTraining);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.interactlbl);
            this.Controls.Add(this.pauselbl);
            this.Controls.Add(this.moveforwardlbl);
            this.Controls.Add(this.lightpunchlbl);
            this.Controls.Add(this.lightkicklbl);
            this.Controls.Add(this.spriteImageMenu);
            this.Controls.Add(this.btnCharInfo);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnControls);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pictureBoxTitle);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textboxHowToPlay);
            this.Controls.Add(this.menuBackground);
            this.Controls.Add(this.bgMusicPlayer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spriteImageMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgMusicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupCurrentPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreBackupToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.Button btnExtraModes;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox menuBackground;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnCharInfo;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.PictureBox spriteImageMenu;
        private System.Windows.Forms.Label moveforwardlbl;
        private System.Windows.Forms.Label movebackwardlbl;
        private System.Windows.Forms.Label lightkicklbl;
        private System.Windows.Forms.Label lightpunchlbl;
        private System.Windows.Forms.Label heavykicklbl;
        private System.Windows.Forms.Label heavypunchlbl;
        private System.Windows.Forms.Label pauselbl;
        private System.Windows.Forms.Label interactlbl;
        private System.Windows.Forms.Button backcontrolsbtn;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.TextBox textboxHowToPlay;
        private System.Windows.Forms.Button btnChooseTraining;
        private System.Windows.Forms.Button btnChooseRun;
        private System.Windows.Forms.Button backFromExtras;
        private System.Windows.Forms.Label fireballlbl;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button IncVolume;
        private System.Windows.Forms.Button DecVolume;
        private AxWMPLib.AxWindowsMediaPlayer bgMusicPlayer;
        private System.Windows.Forms.Label lblHowToplay;
        private System.Windows.Forms.Label lblIncVolume;
        private System.Windows.Forms.Label lblDecVolume;
    }
}