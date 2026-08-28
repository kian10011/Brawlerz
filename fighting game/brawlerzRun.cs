using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fighting_game
{

    public partial class brawlerzRun : Form
    { //variables
        Player current;   
        bool jump = false;
        int gravity = 12; //pushed char down
        int score = 0;
        int jumpspd; //pushes char up
        int charY;

        int obstaclespd = 10;

        bool paused = false;



        int pos; //position of obstacles
        bool gameOver = false;

        Random rand = new Random();
        public brawlerzRun(Player mp)
        {
            current = mp;
            InitializeComponent();

            bgMusicPlayer.URL = @"Sounds\chill.wav";  //import sound file
            bgMusicPlayer.settings.playCount = 999; //play it 999 times
            bgMusicPlayer.Ctlcontrols.play(); //set default value to play.
            bgMusicPlayer.settings.volume = gameSettings.vol;


            pictureBox1.Controls.Add(pictureBoxChar);    //allows a transparent image on top of a picturebox, in this case, the character background is made transparent.   

            pictureBoxChar.Location = new Point(65, charY); //location of character

            pictureBoxChar.BackColor = Color.Transparent; //set the background of the character to be transparent.


            resetGame();   //call reset game
            hidePause(); //hide pause set of controls
            #region skin

            if (current.Skin == 0) //Checks skin number in player class and imports the correct image / gif to be the character.
            {
                pictureBoxChar.Image = Properties.Resources.chibiChar1;
                charY = 350;
                pictureBoxChar.Location = new System.Drawing.Point(65, charY);
            }
            if (current.Skin == 1)
            {
                pictureBoxChar.Image = Properties.Resources.chibiChar2;
                charY = 356;
                pictureBoxChar.Location = new System.Drawing.Point(65, charY);
            }
            if (current.Skin == 2)
            {
                charY = 366;
                pictureBoxChar.Image = Properties.Resources.chibiChar3;
                pictureBoxChar.Location = new System.Drawing.Point(65, charY);
            }
            if (current.Skin == 3)
            {
                charY = 346;
                pictureBoxChar.Image = Properties.Resources.chibiChar4;
                pictureBoxChar.Location = new System.Drawing.Point(65, charY);
            }
            #endregion
        }

        private void brawlerzRun_Load(object sender, EventArgs e) //play background music of screen looped.
        {

        }
        private void resetGame() //reset game method
        {
            gravity = 12;   //reset all variables
            jump = false;  
            jumpspd = 0;
            score = 0;
            obstaclespd = 10;
            gameOver = false;

            pictureBoxChar.Top = charY; //set the top of char picturebox to the Y position of char.

            foreach (Control x in this.Controls)  //for each of the pictureboxes tagged "obstacle"
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    if (x.Name == "obst1")
                    {
                        pos = this.ClientSize.Width + rand.Next(600, 900) + (x.Width * 10);  //randomise the position of obst1 outside of the screen.
                    }
                    if (x.Name == "obst2")
                    {
                        pos = this.ClientSize.Width + rand.Next(900, 1200) + (x.Width * 10); //randomise the position of obst2 outside of the screen.
                    }
                    x.Left = pos;   //set the left side of each obst to the position given.

                }
            }

            timer1.Start();  //start game timer.


        }


        private void brawlerzRun_KeyUp(object sender, KeyEventArgs e)
        {
            if (jump == true) //if jump is already true, and space bar is release, set jump to false.
            {
                jump = false;
            }
            if (e.KeyCode == Keys.R && gameOver == true)  //reset game if R is pressed and game over is true.
            {
                resetGame();
            }

        }

        private void brawlerzRun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jump == false) //if jump is already false, and space bar is pressed, set the jump to true.
            {
                jump = true;
            }

            if (e.KeyCode == Keys.Escape && !paused)
            {
                paused = true;
                timer1.Stop();

                showPause();
            }

            else if (e.KeyCode == Keys.Escape && paused)
            {
                paused = false;
                timer1.Start();

                hidePause();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxChar.Top += jumpspd;  //add the jumpspeed to the top of the char picturebox to move its position up.
            lblscore.Text = "SCORE: " + score;

            if (jump && gravity < 0) //if jumpins is true and gravity is less than 0, set the jumping to false.
            {
                jump = false;
            }
            if (jump) //if jumping is true, set the jumpspeed to a negative value, and decrement the gravity by one every tick.
            {
                jumpspd = -13;
                gravity -= 1;
            }
            else //otherwise, set the jumpspeed to 13.
            {
                jumpspd = 13;
            }

            if (pictureBoxChar.Top > 349 && jump == false) //if the top of the char picturebox is greater than 349, and jumping is false, set gravity to 12, and reassign the position of the character.
            {
                gravity = 12;
                pictureBoxChar.Top = charY;
                jumpspd = 0;  //set jumpspd to 0, to stop it from going upwards.

            }

            foreach (Control x in this.Controls) //for each picturebox tagged as obstacle
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstaclespd; //move the obstacle to the left, in the speed of its obstaclespd.

                    if (x.Left < -80)
                    {
                        if (x.Name == "obst1")
                        {
                            x.Left = this.ClientSize.Width + rand.Next(600, 900) + (x.Width * 15);  //randomise the position of obst1 outside of the screen.
                        }
                        if (x.Name == "obst2")
                        {
                            x.Left = this.ClientSize.Width + rand.Next(900, 1200) + (x.Width * 15); //randomise the position of obst2 outside of the screen.
                        }
                        //if the obstacle goes beyond the form, respawn the obstacle in the right side of the screen, outside of the form.
                        score++;
                    }

                    if (pictureBoxChar.Bounds.IntersectsWith(x.Bounds))  //if any of the obstacles collide with the character, then stop timer, and set gaemover to true.
                    {
                        timer1.Stop();
                        lblscore.Text += "                PRESS R TO PLAY AGAIN!";
                        gameOver = true;
                    }
                }

            }
            if (pictureBoxChar.Top >= 380 && !jump) //if char is greater or equal to 380 and not jumping, then reset the gravity to 12.
            {
                gravity = 12;
                pictureBoxChar.Top = ground.Top - pictureBoxChar.Height; // Reposition the character so that it is on top of the ground picturebox.
                jumpspd = 0;

            }
            if (score >= 10) //increase the speed of the obstacles if the user reaches a score of 10.
            {
                obstaclespd = 15;
            }



        }
        private void showPause()
        {
            resumebtn.Show(); //show buttons
            exitbtn.Show();
        }

        private void hidePause()
        {
            resumebtn.Hide(); //hide buttons
            exitbtn.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void resumebtn_Click(object sender, EventArgs e)
        {
            timer1.Start();  //start timer if resume is pressed.
            hidePause();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu(current); //Open a new menu screen if exit button is pressed.
            newMenu.Show();
            this.Close();
            
        }

       
    }

}

