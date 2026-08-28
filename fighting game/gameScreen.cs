using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using fighting_game.Properties;
using System.Security.Cryptography;
using System.Security.Policy;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Diagnostics;
using System.Media;
using System.Drawing.Printing;

namespace fighting_game
{

    public partial class gameScreen : Form
    {
        Player current;
        Image character; //images
        Image enemy;
        Image health;

        Image[] Fireball = new Image[2];
        Image[] Fireballflipped = new Image[2];


        Image enemywalkleft = null;   //enemy images
        Image enemywalkright = null;
        Image enemyattleft = null;
        Image enemyattright = null;


        Rectangle rectHealthBar1, rectHealthBar2;

        int characterX = 151; //position of character
        int characterY = 320;

        int[] FireballX = new int[2];
        int[] FireballY = new int[2];

        bool shotFireball = false;
        bool enemyShotFireball = false;

    
        int enemyX = 700;
        int enemyY = 290;   //position of enemy




        float numf;
        float numff;        //slow down any attacks made


        int bgPosition = -250;
        int bgY = 0;             //to move the background
        int totalFrames = 0;


        int endFrame = 0;
        int powerAction = 0;      //dmg of character

        int totalFramesEnemy = 0;       //counts total frames of enemy




        bool left, right;

        bool directionPressed;

        bool playingAction;   //detects any action being played
        bool enemyAction;
        bool fireballaction;

        bool flipped;       //flips character and enemy animations
        bool charflipped;

        bool enemy6dead;

        bool paused = false;




        public static bool training = false;    //detects it training mode button has been pressed
        public static int backgroundLvl = 1;   //default lvl 1



        Image characteridle = null;       //images of char
        Image characterfw = null;
        Image characterbw = null;
        Image characterHK = null;
        Image characterHP = null;
        Image characterLK = null;
        Image characterLP = null;

        Image characterfwflipped = null;
        Image characterbwflipped = null;        //images of flipped char
        Image characteridleflipped = null;
        Image characterHKflipped = null;
        Image characterHPflipped = null;
        Image characterLKflipped = null;
        Image characterLPflipped = null;
        Image charFireball = null;
        Image charFireballflipped = null;


        Image background = null;

        SoundPlayer hit = new SoundPlayer(Properties.Resources.light_punch);


        string fp = "scores.txt";
        Random randomScore = new Random();

        StreamWriter sw;
        FileStream fs;
        public gameScreen(Player mp)
        {
            current = mp;
            


            InitializeComponent();
            WMP.settings.volume = gameSettings.vol;

            #region import_resources
            if (training)
            {
                background = Properties.Resources.trainingBG;

                enemywalkleft = Properties.Resources.enemy1walkleft;
                enemywalkright = Properties.Resources.enemy1walkright;
                enemyattleft = Properties.Resources.enemy1attack;
                enemyattright = Properties.Resources.enemy1attackright;///if training mode is true
                lblEnemyHealth.Text = "";
            }

            if (!training)
            {
                switch (backgroundLvl)
                {
                    case 1:
                        background = Properties.Resources.backgroundlvl1;
                        enemywalkleft = Properties.Resources.enemy1walkleft;   //if backgroundlvl is 1 and training is false
                        enemywalkright = Properties.Resources.enemy1walkright;
                        enemyattleft = Properties.Resources.enemy1attack;
                        enemyattright = Properties.Resources.enemy1attackright;
                        WMP.URL = @"Sounds\lvl1.mp3";
                        lblEnemyHealth.Text = "Gull";
                        break;

                    case 2:

                        background = Properties.Resources.backgroundlvl2;
                        enemywalkleft = Properties.Resources.enemy2walkleft;   //if backgroundlvl is 1 and training is false
                        enemywalkright = Properties.Resources.enemy2walkright;
                        enemyattleft = Properties.Resources.enemy2attack;
                        enemyattright = Properties.Resources.enemy2attackright;
                        WMP.URL = @"Sounds\lvl2.mp3";
                        lblEnemyHealth.Text = "Chizumi";
                        break;

                    case 3:


                        background = Properties.Resources.backgroundlvl3;
                        enemywalkleft = Properties.Resources.enemy3walkleft;   //if backgroundlvl is 1 and training is false
                        enemywalkright = Properties.Resources.enemy3walkright;
                        enemyattleft = Properties.Resources.enemy3attackleft;
                        enemyattright = Properties.Resources.enemy3attackright;
                        WMP.URL = @"Sounds\lvl3.mp3";
                        lblEnemyHealth.Text = "Diaz";
                        break;

                    case 5:

                        background = Properties.Resources.backgroundlvl4;
                        enemywalkleft = Properties.Resources.enemy4walkleft;
                        enemywalkright = Properties.Resources.enemy4walkright;
                        enemyattleft = Properties.Resources.enemy4fireballleft;
                        enemyattright = Properties.Resources.enemy4fireballright;
                        WMP.URL = @"Sounds\lvl5.mp3";
                        lblEnemyHealth.Text = "Lei Feng";

                        Fireball[1] = Properties.Resources.fireball4flipped;
                        Fireballflipped[1] = Properties.Resources.fireball4;
                        break;

                    case 4:


                        background = Properties.Resources.backgroundlvl5;
                        enemywalkleft = Properties.Resources.enemy5walkleft;   //if backgroundlvl is 1 and training is false
                        enemywalkright = Properties.Resources.enemy5walkright;
                        enemyattleft = Properties.Resources.enemy5attackleft;
                        enemyattright = Properties.Resources.enemy5attackright;
                        WMP.URL = @"Sounds\lvl4.mp3";
                        lblEnemyHealth.Text = "Nekro";
                        break;

                    case 6:

                        //gameTimer.Enabled = false;
                        //bossTimer.Enabled = true;

                        background = Properties.Resources.backgroundlvl6;
                        enemywalkright = Properties.Resources.enemy6walkright;
                        enemywalkleft = Properties.Resources.enemy6walkleft;
                        enemyattleft = Properties.Resources.enemy6fireballleft;
                        enemyattright = Properties.Resources.enemy6fireballright;
                        WMP.URL = @"Sounds\lvl6.mp3";
                        lblEnemyHealth.Text = "Gertrude";




                        Fireball[1] = Properties.Resources.fireball2flipped;
                        Fireballflipped[1] = Properties.Resources.fireball2;
                        break;

                }


            }

            switch (mp.Skin)
            {
                case 0:
                    characteridle = Properties.Resources.char1Idle;    //upload skin sprites
                    characterfw = Properties.Resources.char1fw;
                    characterbw = Properties.Resources.char1bw;
                    characterHK = Properties.Resources.char1HK;
                    characterHP = Properties.Resources.char1HP;
                    characterLK = Properties.Resources.char1LK;
                    characterLP = Properties.Resources.char1LP;
                    characterfwflipped = Properties.Resources.char1fwflipped;
                    characterbwflipped = Properties.Resources.char1bwflipped;
                    characteridleflipped = Properties.Resources.char1Idleflipped;
                    characterHKflipped = Properties.Resources.char1HKflipped;
                    characterHPflipped = Properties.Resources.char1HPflipped;
                    characterLKflipped = Properties.Resources.char1LKflipped;
                    characterLPflipped = Properties.Resources.char1LPflipped;
                    charFireball = Properties.Resources.char1fireball;
                    charFireballflipped = Properties.Resources.char1fireballflipped;

                    Fireball[0] = Properties.Resources.fireball1;
                    Fireballflipped[0] = Properties.Resources.fireball1flipped;
                    break;


                case 1:

                    characteridle = Properties.Resources.char2Idle;
                    characterfw = Properties.Resources.char2FW;
                    characterbw = Properties.Resources.char2BW;
                    characterHK = Properties.Resources.char2HK;
                    characterHP = Properties.Resources.char2HP;
                    characterLK = Properties.Resources.char2LK;
                    characterLP = Properties.Resources.char2LP;
                    characterfwflipped = Properties.Resources.char2FWflipped;
                    characterbwflipped = Properties.Resources.char2BWflipped;
                    characteridleflipped = Properties.Resources.char2Idleflipped;
                    characterHKflipped = Properties.Resources.char2HKflipped;
                    characterHPflipped = Properties.Resources.char2HPflipped;
                    characterLKflipped = Properties.Resources.char2LKflipped;
                    characterLPflipped = Properties.Resources.char2LPflipped;
                    charFireball = Properties.Resources.char2fireball;
                    charFireballflipped = Properties.Resources.char2fireballflipped;

                    Fireball[0] = Properties.Resources.fireball3;
                    Fireballflipped[0] = Properties.Resources.fireball3flipped;
                    break;


                case 2:

                    characteridle = Properties.Resources.char3Idle;
                    characterfw = Properties.Resources.char3FW;
                    characterbw = Properties.Resources.char3BW;
                    characterHK = Properties.Resources.char3HK;
                    characterHP = Properties.Resources.char3HP;
                    characterLK = Properties.Resources.char3LK;
                    characterLP = Properties.Resources.char3LP;
                    characterfwflipped = Properties.Resources.char3FWflipped;
                    characterbwflipped = Properties.Resources.char3BWflipped;
                    characteridleflipped = Properties.Resources.char3Idleflipped;
                    characterHKflipped = Properties.Resources.char3HKflipped;
                    characterHPflipped = Properties.Resources.char3HPflipped;
                    characterLKflipped = Properties.Resources.char3LKflipped;
                    characterLPflipped = Properties.Resources.char3LPflipped;
                    charFireball = Properties.Resources.char3fireball;
                    charFireballflipped = Properties.Resources.char3fireballflipped;

                    Fireball[0] = Properties.Resources.fireball2;
                    Fireballflipped[0] = Properties.Resources.fireball3flipped;
                    break;

                case 3:

                    characteridle = Properties.Resources.char4Idle;
                    characterfw = Properties.Resources.char4FW;
                    characterbw = Properties.Resources.char4BW;
                    characterHK = Properties.Resources.char4HK;
                    characterHP = Properties.Resources.char4HP;
                    characterLK = Properties.Resources.char4LK;
                    characterLP = Properties.Resources.char4LP;
                    characterfwflipped = Properties.Resources.char4FWflipped;
                    characterbwflipped = Properties.Resources.char4BWflipped;
                    characteridleflipped = Properties.Resources.char4Idleflipped;
                    characterHKflipped = Properties.Resources.char4HKflipped;
                    characterHPflipped = Properties.Resources.char4HPflipped;
                    characterLKflipped = Properties.Resources.char4LKflipped;
                    characterLPflipped = Properties.Resources.char4LPflipped;
                    characterLPflipped = Properties.Resources.char4LPflipped;
                    charFireball = Properties.Resources.char4fireball;
                    charFireballflipped = Properties.Resources.char4fireballflipped;

                    Fireball[0] = Properties.Resources.fireball4;
                    Fireballflipped[0] = Properties.Resources.fireball4flipped;
                    break;
            }
            #endregion

            health = Properties.Resources.healthbar;
            rectHealthBar1 = new Rectangle(489, 33, 299, 32);
            rectHealthBar2 = new Rectangle(12, 33, 299, 32);

            lblPlayerHealth.Text = current.Name;

            WMP.settings.playCount = 999;
            WMP.Ctlcontrols.play();
            WMP.Visible = false;

           

            positionCorrect(); //correct position of sprites
            formSetup(); //setup the form
            hidepause();
            hideDefeat();  //hide the pause, victory and defeat set of function.
            hideVictory();
        }
        private void saveScore()
        {
            fs = !File.Exists(fp) ? new FileStream(fp, FileMode.Create, FileAccess.Write) //if file does not exist create a new file.
                : new FileStream(fp, FileMode.Append, FileAccess.Write);

            sw = new StreamWriter(fs);

            sw.WriteLine(current.Name + "~" + current.Score + "~" + current.Rounds); //separate each piece of data with tilde.
            sw.Close();
            fs.Close();
        }
        #region gametimer
        private void gameTimer_Tick(object sender, EventArgs e)  //timer for game
        {

            this.Invalidate();
            ImageAnimator.UpdateFrames();  //redraws the image every frame
            movePlayer(); //Method allows the movement of player.
            moveBg(); //methods allows the scrolling of map.



            if (!training)

            {
                if ((Collision(characterX, characterY, character.Width, character.Height, enemyX, enemyY, enemy.Width, enemy.Height)) && !enemyAction)  //if collision detected
                {

                    if (enemyX > characterX)
                    {
                        if (backgroundLvl == 6)
                        {
                            characterX -= 10;
                        }

                        enemyAttleft();       //if enemyX is greater than enemyY, attack left
                    }
                    if (enemyX < characterX)   //attack right if enemy X is less than enemyY
                    {
                        if (backgroundLvl == 6)
                        {
                            characterX += 10;
                        }
                        enemyAttright();
                    }
                    if (backgroundLvl == 1)   //dmg multiplier
                    {
                        rectHealthBar2.Width -= 10;
                    }
                    if (backgroundLvl == 2)
                    {
                        rectHealthBar2.Width -= 12;
                    }
                    if (backgroundLvl == 3)
                    {

                        rectHealthBar2.Width -= 13;

                        if (rectHealthBar1.Width < 50)  //if health goes below 50, deal more damage
                        {
                            rectHealthBar2.Width -= 25;
                        }
                    }
                    if (backgroundLvl == 4)
                    {
                        rectHealthBar2.Width -= 20;
                    }

                }

                if ((Collision(characterX, characterY, character.Width, character.Height, enemyX, enemyY, enemy.Width, enemy.Height)) && playingAction && !shotFireball && !fireballaction)
                {

                    rectHealthBar1.Width -= powerAction;    //if collision detected, deal dmg to enemy depending on the powerAction of move

                }

                if (!Collision(characterX, characterY, character.Width, character.Height, enemyX, enemyY, enemy.Width, enemy.Height))  // if no collision detected
                {
                    if (enemyX > characterX && !enemyAction)  //if enemyX is greater than characterX and if enemy is not attacking, walk left
                    {
                        if (backgroundLvl != 5 || backgroundLvl != 6)
                        {
                            enemyX -= 2;
                            enemy = enemywalkleft;
                        }

                        flipped = false;
                        charflipped = false;


                    }
                    if (enemyX < characterX && !enemyAction)  //if enemyX is less than characterX and if enemy is not attacking, walk right
                    {
                        if (backgroundLvl != 5 && backgroundLvl != 6)
                        {
                            enemyX += 2;
                            enemy = enemywalkright;
                        }

                        flipped = true;    //set flipped variables to true
                        charflipped = true;



                    }
                }
                if (backgroundLvl == 3)
                {
                    if (rectHealthBar1.Width < 250) //if health of enemy3 decreases to a certain point, change the attack sprite of enemy.
                    {
                        enemyattleft = Properties.Resources.enemy3attackleftult;
                        enemyattright = Properties.Resources.enemy3attackrightult;

                    }
                }
                if (backgroundLvl == 5 || backgroundLvl == 6) //if background is 5 or 6
                {

                    if (enemyX <= characterX + 500 && !enemyShotFireball && !flipped && !enemyAction)
                    {

                        enemyAttleft();                      //if enemy is within a range of character, and if enemy is not already shooting a fireball, attack left
                    }
                    if (flipped)
                    {
                        if (enemyX >
                            characterX - 500 && !enemyShotFireball && !enemyAction)  //if enemy is within a range of character, and if enemy is not already shooting a fireball, attack right
                        {
                            enemyAttright();
                        }
                    }
                    if (enemyX > characterX + 500 && !flipped)
                    {

                        enemyX -= 2;                       //if character is not within range of enemy, walk left
                        enemy = enemywalkleft;
                    }
                    if (flipped)
                    {
                        if (enemyX < characterX - 500)      //if character is not within range of enemy, walk right
                        {
                            enemyX += 2;
                            enemy = enemywalkright;
                        }
                    }

                    if (!enemyShotFireball && (numff + 3) > totalFramesEnemy)   //after fireball animation of enemy plays, produce fireball
                    {
                        enemyFireball();   //call the enemy fireball method.

                    }
                    if (enemyShotFireball)     //if fireball shot, then move fireball towards character
                    {
                        if (flipped)
                        {
                            FireballX[1] += 20; //move enemy fireball to the right if flipped
                        }
                        else
                            FireballX[1] -= 20; //move enemy fireball to the left if not flipped.
                    }

                    if (FireballCollisionPlayer()) //fireball dmg
                    {
                        rectHealthBar2.Width -= 3; //reduces width of character if fireball collides with player    
                        if (charflipped)
                        {
                            characterX += 5; //if character is flipped, knockback the character to the right
                        }
                        else
                        {
                            characterX -= 5; //if character is not flipped, knockback the character to the left.
                        }

                    }

                    if ((FireballX[1] > (this.ClientSize.Width)) || ((FireballX[1] < 0))) //if fireball goes beyond form, set shotfireball to false
                    {
                        enemyShotFireball = false;
                        FireballX[1] = -1000;


                    }
                }


                if (FireballCollisionEnemy())   //if fireball collides with enemy, push them back
                {
                    rectHealthBar1.Width -= powerAction;
                    hit.Play();
                    //deal damage to the enemy, by the powerAction set for fireball.

                    if (backgroundLvl != 4 && backgroundLvl != 5 && backgroundLvl != 6) //if not level 4, 5 or 6, knoeckback the enemy, if player fireball makes contact with enemy.
                    {
                        if (flipped)
                        {
                            enemyX -= 3;
                        }
                        else
                        {
                            enemyX += 3;
                        }
                    }
                }


                if (enemyAction)
                {
                    if (numff < totalFramesEnemy)
                    {
                        numff += 0.5f;      //slow down animation to prevent any glitches
                    }
                }
                if (numff == totalFramesEnemy) //once enemy  attack animation finishes, reset enemy
                {
                    ResetEnemy();


                }
            }
            if (playingAction)
            {
                if (numf < totalFrames) //slow down animation
                {
                    numf += 0.5f;
                }
            }
            if (numf == totalFrames)
            {
                ResetPlayer();   //stop playing action once total frames have been reached
            }




            if (rectHealthBar1.Width < 1)   //if enemy health bar depletes
            {
                if (backgroundLvl != 6) //if its not level 6
                {
                    gameTimer.Stop(); //stop timer
                    rectHealthBar1.Width = 0; //set the width of enemy healthbar to 0.
                    showVictory(); //show victory set of funtions.
                    current.Score += randomScore.Next(0, 10000); //Produce a random score.
                    lblscore.Text += current.Score.ToString(); // convert the score into a string and display in score label.
                    backgroundLvl++; //increment backgroundlvl by one.
                    current.Rounds++; //increment rounds by one.
                }
                else
                {
                    enemy6dead = true;
                    charflipped = false;
                    rectHealthBar1.Width = 0;

                    Opacity -= 0.02;
                    if (Opacity == 0)
                    {

                        CrownOfGlory newC = new CrownOfGlory(current);
                        newC.Show();
                        this.Close();       //open crownofglory 
                    }
                }

            }
            if (rectHealthBar2.Width < 1) //if player health bar depletes
            {
                gameTimer.Stop(); //stop timer  
                rectHealthBar2.Width = 0; //set the width of player healthbar to 0
                showDefeat(); // show ddefeat set of functions.
                backgroundLvl = 1; // reset the background levl to 1
                current.Rounds++; //increment rounds by one.    
                WMP.Ctlcontrols.stop();
            }

            if (shotFireball) //if player fireball is being shot
            {

                if (charflipped)
                {
                    FireballX[0] -= 20; //if flipped, move fireball to the left.
                }
                else
                    FireballX[0] += 20; //if not flipped, move fireball to the right.

            }

            if ((FireballX[0] > (this.ClientSize.Width)) || ((FireballX[0] < 0)))
            {
                shotFireball = false;


            }
            if (!shotFireball && (numf + 3) > endFrame && powerAction == 3 && !directionPressed)
            {
                fireball();
                fireballaction = false;
            }

        }
        #endregion

        private void formSetup()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true); //makes animation smoother
            character = characteridle;

            enemy = enemywalkleft;


            SetUpAnimEnemyWalkLeft();              //initialize all animations
            SetUpAnimEnemyWalkRight();

            SetUpAnimEnemyAttackleft();
            SetUpAnimEnemyAttackright();


            SetUpAnim();
            SetUpAnimBg();

        }
        private void enemyAttleft()
        {
            if (backgroundLvl == 6)
            {
                enemyY = 320;
            }
            enemy = enemyattleft;
            SetUpAnimEnemyAttackleft();

            enemyAction = true;   //set enemyAction to true when enemy is attacking
            hit.Play();

        }
        private void enemyAttright()
        {
            if (backgroundLvl == 6)
            {
                enemyY = 320;
            }
            enemy = enemyattright;
            SetUpAnimEnemyAttackright();

            hit.Play();
            enemyAction = true; //set enemyAction to true when enemy is attacking

        }
        #region AnimationSetups
        private void SetUpAnim()
        {
            ImageAnimator.Animate(character, this.OnFrameChangedHandler);
            FrameDimension dim = new FrameDimension(character.FrameDimensionsList[0]);
            totalFrames = character.GetFrameCount(dim);
            endFrame = totalFrames - 3;//setup the animation for char

        }
        private void SetUpAnimEnemyWalkLeft()
        {
            ImageAnimator.Animate(enemywalkleft, this.OnFrameChangedHandler);


            //setup animation for enemy

        }

        private void SetUpAnimEnemyWalkRight()
        {
            ImageAnimator.Animate(enemywalkright, this.OnFrameChangedHandler);
            //setup animation for enemy

        }
        private void SetUpAnimEnemyAttackleft()
        {
            ImageAnimator.Animate(enemyattleft, this.OnFrameChangedHandler);
            FrameDimension dimen = new FrameDimension(enemy.FrameDimensionsList[0]);
            totalFramesEnemy = enemy.GetFrameCount(dimen);
            //setup animation for enemy

        }
        private void SetUpAnimEnemyAttackright()
        {
            ImageAnimator.Animate(enemyattright, this.OnFrameChangedHandler);
            FrameDimension dimen = new FrameDimension(enemy.FrameDimensionsList[0]);
            totalFramesEnemy = enemy.GetFrameCount(dimen);
            //setup animation for enemy

        }

        private void SetUpAnimBg()
        {
            ImageAnimator.Animate(background, this.OnFrameChangedHandler);

        }

        private void OnFrameChangedHandler(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion

        #region draw function
        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(background, new Point(bgPosition, bgY)); //draws the background
            g.DrawImage(character, new Point(characterX, characterY));   //draws the character

            if (!training && !enemy6dead)
            {
                g.DrawImage(enemy, new Point(enemyX, enemyY));
                g.DrawImage(health, rectHealthBar1);     //paint healthbars
                g.DrawImage(health, rectHealthBar2);
            }


            if (shotFireball)
            {
                if (charflipped)
                {
                    g.DrawImage(Fireballflipped[0], new Point(FireballX[0], characterY));
                }                                                                               //draws the fireballs from the character's y position
                else
                    g.DrawImage(Fireball[0], new Point(FireballX[0], characterY));
            }
            if (enemyShotFireball)
            {
                if (flipped)
                {
                    g.DrawImage(Fireballflipped[1], new Point(FireballX[1], characterY));
                }                                                                            //draws the fireballs from the enemy's y position
                else
                    g.DrawImage(Fireball[1], new Point(FireballX[1], enemyY));
            }

        }

        #endregion

        #region keyup/keydown functions
        private void gameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && !directionPressed && !shotFireball && !paused) //if A key is pressed, return "left"
            {
                MovePlayerAnim("left");

            }
            if (e.KeyCode == Keys.D && !directionPressed && !paused)
            {
                MovePlayerAnim("right"); //if D key is pressed, return "Right"
            }

            if (e.KeyCode == Keys.Escape && !paused)
            {
                paused = true;
                gameTimer.Stop();

                showpause();
            }
            
            else if (e.KeyCode == Keys.Escape && paused)
            {
                paused = false;
                gameTimer.Start();

                hidepause();
            }


        }

        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.D && !shotFireball)
            {
                left = false;
                right = false;
                directionPressed = false;
                ResetPlayer();
            }
            if (e.KeyCode == Keys.U && !playingAction && !left && !right)
            {
                SetCharAction("heavykick", 2);
                playPunchSound();


            }
            if (e.KeyCode == Keys.J && !playingAction && !left && !right)
            {
                SetCharAction("heavypunch", 2);
                playPunchSound();

            }
            if (e.KeyCode == Keys.I && !playingAction && !left && !right)
            {
                SetCharAction("lightkick", 1);
                playPunchSound();


            }
            if (e.KeyCode == Keys.K && !playingAction && !left && !right)
            {
                SetCharAction("lightpunch", 1);
                playPunchSound();


            }

          

            if (e.KeyCode == Keys.Space && !playingAction)
            {
                if (charflipped)
                {
                    characterX += 10;
                }
                else
                    characterX -= 10;
            }
            if (e.KeyCode == Keys.R && !playingAction && !left && !right && !shotFireball)
            {

                SetCharAction("fireball", 3);
                fireballaction = true;

            }
        }
        #endregion

        #region CharAction functions
        private void SetCharAction(string attacks, int dmg)
        {

            switch (attacks)
            {
                case "heavykick":        //if key to input heavykick has been pressed, set the character image to the heavykick action.


                    if (current.Skin == 0)          //set the positions for each skin when doing heavykick
                    {

                        characterY = 315;

                        if (charflipped == true)
                        {
                            character = characterHKflipped;
                        }
                        else
                            character = characterHK;

                    }
                    if (current.Skin == 1)
                    {
                        characterY = 325;

                        if (charflipped == true)
                        {
                            character = characterHKflipped;
                        }
                        else
                            character = characterHK;

                    }
                    if (current.Skin == 2)
                    {
                        characterY = 280;

                        if (charflipped == true)
                        {
                            character = characterHKflipped;
                        }
                        else
                            character = characterHK;
                    }
                    else

                    {
                        if (charflipped == true)
                        {
                            character = characterHKflipped;
                        }
                        else
                            character = characterHK;
                    }

                    break;


                case "heavypunch": //if key to input heavypunch has been pressed, set the character image to the heavypunch action.

                    if (current.Skin == 0)
                    {
                        characterY = 315;

                        if (charflipped == true)
                        {
                            character = characterHPflipped;
                        }
                        else
                            character = characterHP;

                    }
                    if (current.Skin == 1)
                    {
                        characterY = 330;

                        if (charflipped == true)
                        {
                            character = characterHPflipped;
                        }
                        else
                            character = characterHP;
                    }
                    else
                    {
                        if (charflipped == true)
                        {
                            character = characterHPflipped;
                        }
                        else
                            character = characterHP;
                    }
                    break;


                case "lightkick": //if key to input lightkick has been pressed, set the character image to the lightkick action.



                    if (charflipped == true)
                    {
                        character = characterLKflipped;
                    }
                    else
                        character = characterLK;
                    break;


                case "lightpunch": //if key to input lightpunch has been pressed, set the character image to the lightpunch action.



                    if (charflipped == true)
                    {
                        character = characterLPflipped;
                    }
                    else
                        character = characterLP;
                    break;

                case "fireball": //if key to input fireball has been pressed, set the character image to the fireball action.

                    if (charflipped == true)
                    {
                        character = charFireballflipped;
                    }
                    else
                        character = charFireball;
                    break;
            }

            powerAction = dmg;  //set powerAction equal to the damage.
            SetUpAnim(); //animate
            playingAction = true; //set playingAction to true because character is doing an action.

        }
        #endregion

        #region Reset Sprites
        private void ResetPlayer()
        {
            if (!directionPressed)
            {
                positionCorrect();

            }
            if (flipped)
            {
                character = characteridleflipped;
            }
            else
            {
                character = characteridle;
            }

            numf = 0;
            playingAction = false;


            SetUpAnim();
        }
        private void ResetEnemy()
        {
            enemy = enemywalkleft;
            numff = 0;
            enemyAction = false;

            if(backgroundLvl == 6)
            {
                enemyY = 340;
            }


        }
        #endregion

        private void gameScreen_Load(object sender, EventArgs e)
        {

        }

        #region MovePlayer & Background functions
        private void MovePlayerAnim(string dir)
        {
            switch (dir)
            {
                case "right": //set right to true if the string direction is "right"

                    right = true;

                    if (flipped)
                    {
                        character = characterbwflipped;
                    }
                    else
                    {
                        character = characterfw;
                    }
                    break;
                case "left": //set left to true if the string direction is "left"

                    left = true;

                    if (flipped)
                    {
                        character = characterfwflipped;
                    }
                    else
                    {
                        character = characterbw;
                    }
                    break;
            }

            directionPressed = true; //set directionPressed to true because character is moving.
            playingAction = false;  //no actions are made yet, so set to false.
            SetUpAnim(); //animate
        }

        private void movePlayer()
        {

            if (left) //move character according to the boolean variables left and right
            {
                if (characterX > 0)
                {
                    characterX -= 5;
                }
            }
            if (right)
            {
                if (characterX + character.Width < this.ClientSize.Width)
                {
                    characterX += 5;
                }
            }

        }
        private void moveBg() //move background to allow character and enemy to move beyond the form.
        {
            if (right == true || left == true)
            {
                if (bgPosition < 0 && characterX < 100)
                {
                    bgPosition += 5;
                    enemyX += 5;


                }
                if (bgPosition + background.Width > this.ClientSize.Width + 10 && characterX > 700)
                {
                    bgPosition -= 5;
                    enemyX -= 5;


                }
            }

        }
        #endregion

        #region correct Positions
        private void positionCorrect()
        {
            switch (current.Skin)
            {
                case 0:

                    characterY = 320;
                    break;
                case 1:

                    characterY = 330;
                    break;

                case 2:

                    characterY = 320;
                    break;
                case 3:

                    characterY = 320;
                    break;
            }

            switch (backgroundLvl)
            {
                case 2:

                    enemyY = 320;
                    bgY = -129;
                    break;
                case 3:

                    enemyY = 320;
                    break;
                case 4:

                    enemyY = 320;
                    break;
                case 5:

                    enemyY = 330;
                    break;
                case 6:

                    enemyY = 340;
                    break;
            }

        }
        #endregion

        #region Collision functions
        private bool Collision(int charX, int charY, int charWidth, int charHeight, int enemyX, int enemyY, int enemyWidth, int enemyHeight)
        {
            if (charX + charWidth <= enemyX || charX >= enemyX + enemyWidth || charY + charHeight <= enemyY || charY >= enemyY + enemyHeight)
                return false;  //if bounds dont collide with each other, return false.


            else //else return true.
                return true;
        }
        private bool FireballCollisionEnemy()
        {
            bool collide = Collision(enemyX, enemyY, enemy.Width, enemy.Height, FireballX[0], FireballY[0], Fireball[0].Width, Fireball[0].Height);

            if (collide) //if bounds of player fireball collides with bounds of enemy, return true.
            {
                return true;
            }
            else //else, return false.
                return false;

        }

        private bool FireballCollisionPlayer()
        {
            bool collide = Collision(characterX, characterY, character.Width, character.Height, FireballX[1], FireballY[1], Fireball[1].Width, Fireball[1].Height);

            if (collide) //if enemy fireball bounds collide with bounds of character, return true.
            {
                return true;
            }
            else //else, return false.
                return false;

        }
        #endregion

        private void resumebtn_Click(object sender, EventArgs e)
        {
            gameTimer.Start(); //start timer
            hidepause();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu(current); //open a new menu screen.
            newMenu.Show();
            this.Close();

            prologue.backgroundNo = 1; //Reset the background numbers of each prologue screen to the default value if user exits.
            prologue2.backgroundNo2 = 1;

        }

        private void showpause()
        {
            resumebtn.Show();
            exitbtn.Show();

           
        }
        private void hidepause()
        {
            resumebtn.Hide();
            exitbtn.Hide();

            
        }

        private void defeatReturnbtn_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu(current); //open a new main menu screen
            newMenu.Show();
            this.Close();
            saveScore();

            prologue.backgroundNo = 1; //Reset the background numbers of each prologue screen to the default value if user loses.
            prologue2.backgroundNo2 = 1;
        }
        private void victoryReturnbtn_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu(current); //open new main menu screen
            newMenu.Show();
            this.Close();
            saveScore();

            prologue.backgroundNo = 1;
            prologue2.backgroundNo2 = 1; //Reset the background numbers of each prologue screen to the default value if user returns to main menu.


            backgroundLvl = 1;
        }
        private void victoryContinuebtn_Click(object sender, EventArgs e)
        {


            if (backgroundLvl == 6)
            {

                prologue2 newp = new prologue2(current); //if it is level 6, open prologue 2 screen.
                newp.Show();
                this.Close();
            }
            else
            {
                PregameScreen newpregame = new PregameScreen(current); //otherwise, open a pregame screen.
                newpregame.Show();
                this.Close();
            }
        }

        private void showDefeat()
        {
            defeatReturnbtn.Show(); //show defeat set of functions.
            defeatlbl.Show();
            lblscore.Hide();
        }
        private void hideDefeat()
        {
            defeatReturnbtn.Hide(); //hide defeat set of functions.
            defeatlbl.Hide();
            lblscore.Hide();
        }

        private void showVictory()
        {
            victoryReturnbtn.Show(); //show victory set of functions.
            victorylbl.Show();
            victoryContinuebtn.Show();
            lblscore.Show();

        }
        private void hideVictory()
        {
            victoryReturnbtn.Hide(); //hide victory set of functions.
            victorylbl.Hide();
            victoryContinuebtn.Hide();
            lblscore.Hide();
        }

        private void lblscore_Click(object sender, EventArgs e)
        {

        }

        private void WMP_Enter(object sender, EventArgs e)
        {

        }

        private void playPunchSound()
        {
            if (Collision(characterX, characterY, character.Width, character.Height, enemyX, enemyY, enemy.Width, enemy.Height))
            {
                hit.Play();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region fireball functions

        private void fireball()
        {
            FireballX[0] = characterX;      //set fireball X and Y to the character X and Y, so that they release from the character's position.
            FireballY[0] = characterY;
            shotFireball = true;  //fireball shot is true

            if (charflipped)
            {
                ImageAnimator.Animate(Fireballflipped[0], this.OnFrameChangedHandler);  //animate fireballs
            }
            else
                ImageAnimator.Animate(Fireball[0], this.OnFrameChangedHandler);

        }

        private void enemyFireball()
        {
            FireballX[1] = enemyX;   //set the fireball X and Y to the enemey X and Y, so that they release from the enemy's position.
            FireballY[1] = enemyY;
            enemyShotFireball = true; //enemy fireball shot is true

            if (flipped)
            {
                ImageAnimator.Animate(Fireballflipped[1], this.OnFrameChangedHandler); //animate fireballs
            }
            else
                ImageAnimator.Animate(Fireball[1], this.OnFrameChangedHandler);

        }
        #endregion
    }





}
