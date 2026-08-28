using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Media;



namespace fighting_game
{
    public partial class Menu : Form
    {

        int colourCount = 255, colourCountInv = 0;
        bool down = true;
        Player current;


        SoundPlayer btnclick = new SoundPlayer(Properties.Resources.btn__click);
        string fp = "";

        public Menu(Player mp)
        {
            InitializeComponent();
            current = mp;
            lblWelcome.Text = "Welcome " + current.Name;

            lblRounds.Text = "Rounds played: " + current.Rounds + " Rounds";

            lblscore.Text += current.Score;

            fp = "backups/" + current.Name + "backup.bin";
            #region Transparent function
            menuBackground.Controls.Add(pictureBoxTitle); //Make the game title transparent by manually adding the picturebox on top of the menuBackground.
            pictureBoxTitle.Location = new Point(232, 5);
            pictureBoxTitle.BackColor = Color.Transparent; //Set the back color of the picturebox to transparent.

            menuBackground.Controls.Add(spriteImageMenu); //Make the character sprite transparent by manually adding the Image on top of the menuBackground.
            spriteImageMenu.Location = new Point(405, 261);
            spriteImageMenu.BackColor = Color.Transparent; //Set the back color of the Image to transparent.
            #endregion
            #region hide functions
            HideSecond(); //hide settings buttons
            hideControls(); //hide controls buttons
            hideExtras(); // hide extra mode buttons
            IncVolume.Hide();
            DecVolume.Hide();
            lblIncVolume.Hide();
            lblDecVolume.Hide();
            #endregion
            #region WMP settings
            bgMusicPlayer.URL = @"Sounds\s2.mp3";  //import sound file
            bgMusicPlayer.settings.playCount = 999; //play it 999 times
            bgMusicPlayer.Ctlcontrols.play(); //set default value to play.
            bgMusicPlayer.Visible = false; //hide music player.
            #endregion

            textboxHowToPlay.Hide();
            #region import sprite
            if (mp.Skin == 0) //import sprite resources according to the skin value in player class.
            {
                spriteImageMenu.Image = Properties.Resources.char1Idle;
            }
            if (mp.Skin == 1)
            {
                spriteImageMenu.Image = Properties.Resources.char2Idle;
            }
            if (mp.Skin == 2)
            {
                spriteImageMenu.Image = Properties.Resources.char3Idle;
            }
            if (mp.Skin == 3)
            {
                spriteImageMenu.Image = Properties.Resources.char4Idle;
            }
            #endregion
        }



        private void OnFrameChangedHandler(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        #region show / hide extra modes
        private void showExtras()
        {
            btnChooseTraining.Show(); //Method to show extra mode buttons
            btnChooseRun.Show();
            backFromExtras.Show();
        }
        private void hideExtras()
        {
            btnChooseTraining.Hide(); //Method to hide extra mode buttons
            btnChooseRun.Hide();
            backFromExtras.Hide();
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            prologue myGame = new prologue(current); //open a new prologue screen when play button is pressed.


            myGame.Show(); //show prologue screen   
            this.Close();  //close current form

            gameScreen.training = false; //set training mode to false as training mode button has not been pressed.
            btnclick.Play(); 


        }
        #region timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (down)
            {
                colourCount -= 4;
                colourCountInv += 4;
            }
            else
            {
                colourCount += 4;
                colourCountInv -= 4;
            }



            if (colourCount > 251)
                down = true;
            else if (colourCount < 4)
                down = false;


        }
        #endregion

        #region show / hide first set of functions
        private void HideFirst()
        {
            btnPlay.Hide();  //hide main menu buttons
            btnScores.Hide(); 
            btnExtraModes.Hide();
            btnSettings.Hide();
            spriteImageMenu.Hide();

            lblTime.Hide(); //hide main menu labels
            lblWelcome.Hide();
            lblRounds.Hide();
        }
        private void ShowFirst()
        {
            btnPlay.Show(); //show main menu buttons
            btnScores.Show();
            btnExtraModes.Show();
            btnSettings.Show();
            spriteImageMenu.Show();

            lblTime.Show(); //show main menu labels
            lblWelcome.Show();
            lblRounds.Show();
        }
        #endregion

        #region show / hide second set of functions
        private void HideSecond()
        {
            btnControls.Hide();
            btnReturnMenu.Hide(); //hide settings functions
            btnCharInfo.Hide();
            btnSound.Hide();
        }


        private void ShowSecond()
        {
            btnControls.Show();
            btnReturnMenu.Show(); //show settings functions
            btnCharInfo.Show();
            btnSound.Show();
        }
        #endregion

        #region toolstrip functions

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);   //close program
            btnclick.Play();
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options myChar = new Options(current); //open a new options screen
            myChar.Show(); //show screen
            this.Close(); //close current screen
            btnclick.Play();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartForm newForm = new StartForm(); //open a ne startform screen.
            newForm.Show();
            this.Close();
            btnclick.Play();
        }

        private void backupCurrentPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string overwrite = "You are about to overwrite your existing backup, are you sure you still want to conitnue?";

            DialogResult dialogResult = MessageBox.Show(overwrite, "BEWARE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) //if yes button has been pressed in messagebox
            {
                serialize(); //serialize data
                MessageBox.Show("Backup  was completed successfully. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); //show message
            }
            else if (dialogResult == DialogResult.No) //if no button has been pressed in messagebox
            {
                MessageBox.Show("Backup  was cancelled. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); //show message
            }
            btnclick.Play();
        }

        private void restoreBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string restore = "You are about to load your existing backup and lose your current progress. Would you stil like to continue?";

            DialogResult dialogResult = MessageBox.Show(restore, "BEWARE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) //if yes button has been pressed in message box.
            {
                deserialize(); //deserialize data.
                MessageBox.Show("Restoration was completed succesfully. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);//show message


            }
            else if (dialogResult == DialogResult.No) //if no button has been pressed in message box.
            {
                MessageBox.Show("Restoration was cancelled. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); //show message
            }
            btnclick.Play();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnclick.Play();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnclick.Play();
        }

        private void storyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textboxHowToPlay.Show(); //show how to play textbox.
            HideFirst(); //hide main menu functions.
            btnReturnMenu.Show(); //show a button that allows user to return to main menu.
            btnclick.Play();
        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideFirst(); //hide main menu set of functions.
            showControls(); //show control functions.
            btnclick.Play();
        }

        #endregion 


        private void btnScores_Click(object sender, EventArgs e)
        {
            LeaderBoard myScores = new LeaderBoard(current); //open a new leaderboard screen

            myScores.Show();
            this.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideFirst(); //hide main menu functions and show settings functions.

            ShowSecond();
            spriteImageMenu.Hide(); //hide character sprite

            btnclick.Play();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnControls_Click(object sender, EventArgs e)
        {
            HideSecond(); //hide settings functions and show controls functions

            showControls();
            btnclick.Play();

        }

        #region show / hide set of controls
        private void showControls()
        {

            moveforwardlbl.Show();
            movebackwardlbl.Show();
            lightkicklbl.Show();
            heavykicklbl.Show();
            lightpunchlbl.Show();
            heavypunchlbl.Show();
            interactlbl.Show();
            pauselbl.Show();
            backcontrolsbtn.Show();
            fireballlbl.Show();
            lblHowToplay.Show();
        }
        private void hideControls()
        {

            moveforwardlbl.Hide();
            movebackwardlbl.Hide();
            lightkicklbl.Hide();
            heavykicklbl.Hide();
            lightpunchlbl.Hide();
            heavypunchlbl.Hide();
            interactlbl.Hide();
            pauselbl.Hide();
            backcontrolsbtn.Hide();
            fireballlbl.Hide();
            lblHowToplay.Hide();

        }
        #endregion 
        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            HideSecond(); //hide settings functions and show main menu functions

            ShowFirst();
            spriteImageMenu.Show();
            textboxHowToPlay.Hide();
            btnclick.Play();
        }

        private void backcontrolsbtn_Click(object sender, EventArgs e)
        {

            hideControls(); //hide controls functions and show settings functions.
            ShowSecond();
            btnclick.Play();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {

            HideFirst(); //hide main menu buttons
            showExtras(); //show extra modes
            btnclick.Play();
        }

        #region serialize / deserialize
        private void serialize()
        {
            if (File.Exists(fp)) //delete the data previously held and replace with current data. (backup)
                File.Delete(fp);

            Stream st = File.OpenWrite(fp);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(st, current);

            st.Flush();
            st.Close();
            st.Dispose();
        }

        private void deserialize()
        {
            if (File.Exists(fp)) //if file exists, restore from system and set as current data. (restore backup)
            {
                BinaryFormatter bf = new BinaryFormatter();

                FileStream fs = File.Open(fp, FileMode.Open);

                object obj = bf.Deserialize(fs);

                current = (Player)obj;

                fs.Flush();
                fs.Close();
                fs.Dispose();

            }

        }
        #endregion


        private void btnCharInfo_Click(object sender, EventArgs e)
        {

            charInfo c = new charInfo(current); //open charinfo screen.
            c.Show();
            this.Close();
            btnclick.Play();

        }



        private void lblscore_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseTraining_Click(object sender, EventArgs e)
        {
            gameScreen.training = true; //if training mode has been pressed, set static variable training in gamescreen to true.

            gameScreen myGame = new gameScreen(current); //open new gamescreen.
            myGame.Show();
            this.Close();
            btnclick.Play();

        }

        private void btnChooseRun_Click(object sender, EventArgs e)
        {

            brawlerzRunTut newb = new brawlerzRunTut(current); //if brawlerzRun button has been pressed, open the brawlerzRunTut screen.
            newb.Show();
            this.Close();
            btnclick.Play();
        }

        private void backFromExtras_Click(object sender, EventArgs e)
        {
            IncVolume.Hide();
            DecVolume.Hide();  //hide volume buttons, extra mode buttons and show the main menu buttons.
            hideExtras();
            lblIncVolume.Hide();
            lblDecVolume.Hide();
            ShowFirst();
            btnclick.Play();

        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            HideSecond(); //hide settings buttons.
            backFromExtras.Show();
            IncVolume.Show(); //show sound buttons
            DecVolume.Show();
            lblIncVolume.Show();
            lblDecVolume.Show();
            btnclick.Play();
        }

        #region volume functions
        private void IncreaseVolume()
        {
            if (bgMusicPlayer.settings.volume < 90) //if volume of music player is less than 90
            {
                gameSettings.vol += 10; //add 10 to volume.
                bgMusicPlayer.settings.volume = gameSettings.vol;
            }
        }
        private void DecreaseVolume()
        {
            if (bgMusicPlayer.settings.volume > 1) //if volume of music player is greater than 1
            {
                gameSettings.vol -= gameSettings.vol / 2;
                bgMusicPlayer.settings.volume = gameSettings.vol; //subtract half of the volume from volume.
            }
        }

        private void IncVolume_Click(object sender, EventArgs e)
        {
            IncreaseVolume(); //call increase volume method
        }

        private void interactlbl_Click(object sender, EventArgs e)
        {

        }

        private void DecVolume_Click(object sender, EventArgs e)
        {
            DecreaseVolume();//call decrease volume method
        } 

        #endregion


    }
}
