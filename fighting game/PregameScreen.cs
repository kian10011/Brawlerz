using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fighting_game
{
    public partial class PregameScreen : Form
    {
        Player current;
        Image character;

        Image door = Properties.Resources.door;
        Image background = Properties.Resources.BlackBG;

        int posBackground = 0;
        int characterX = 0; //position of character
        int characterY = 320;

        int enemyX;
        int enemyY;



        int doorX = 598;
        int doorY = 246;

        bool directionPressed;
        bool left, right;


        Image characteridle;
        Image characterfw;
        Image characterbw;
        Image enemy;

        public PregameScreen(Player mp)
        {
            current = mp;

            InitializeComponent();

            switch (mp.Skin) // set resources according to skin number.
            {
                case 0:

                    characteridle = Properties.Resources.char1Idle;
                    characterfw = Properties.Resources.char1fw;
                    characterbw = Properties.Resources.char1bw;
                    break;



                case 1:

                    characteridle = Properties.Resources.char2Idle;
                    characterfw = Properties.Resources.char2FW;
                    characterbw = Properties.Resources.char2BW;
                    break;

                case 2:

                    characteridle = Properties.Resources.char3Idle;
                    characterfw = Properties.Resources.char3FW;
                    characterbw = Properties.Resources.char3BW;
                    break;


                case 3:

                    characteridle = Properties.Resources.char4Idle;
                    characterfw = Properties.Resources.char4FW;
                    characterbw = Properties.Resources.char4BW;
                    break;
            }

            switch (gameScreen.backgroundLvl) //set the resources according to the static variable backgroundLvl in gameScreen.
            {
                case 1:

                    lbllevel.Text = "LVL.1";
                    enemy = Properties.Resources.enemy1idle;
                    enemyX = 360;
                    enemyY = 90;
                    break;
                case 2:

                    lbllevel.Text = "LVL.2";
                    enemy = Properties.Resources.enemy2walkleft;
                    enemyX = 360;
                    enemyY = 150;
                    break;

                case 3:

                    lbllevel.Text = "LVL.3";
                    enemy = Properties.Resources.enemy3walkleft;
                    enemyX = 360;
                    enemyY = 110;
                    break;
                case 5:

                    lbllevel.Text = "LVL.5";
                    enemy = Properties.Resources.enemy4walkleft;
                    enemyX = 360;
                    enemyY = 130;
                    break;
                case 4:

                    lbllevel.Text = "LVL.4";
                    enemy = Properties.Resources.enemy5walkleft;
                    enemyX = 360;
                    enemyY = 130;
                    break;
                case 6:

                    lbllevel.Text = "LVL.6";
                    enemy = Properties.Resources.enemy6idleleft;
                    enemyX = 360;
                    enemyY = 120;
                    break;
            }
            formSetup();
        }

        private void formSetup()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true); //makes animation smoother
            character = characteridle; //removes flickering and allows smooth animation



            SetUpAnim(); //call methods to animate player and enemy.
            SetUpAnimEnemy();

        }

        private void SetUpAnim()
        {
            ImageAnimator.Animate(character, this.OnFrameChangedHandler); //animate player

        }
        private void SetUpAnimEnemy()
        {
            ImageAnimator.Animate(enemy, this.OnFrameChangedHandler); //animate enemy

        }
        private void OnFrameChangedHandler(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void PregameScreen_Load(object sender, EventArgs e)
        {

        }

        private void PregameScreen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(background, new Point(posBackground, 0)); //draw background
            g.DrawImage(character, new Point(characterX, characterY)); //draw character
            g.DrawImage(door, new Point(doorX, doorY)); //draw door
            g.DrawImage(enemy, new Point(enemyX, enemyY)); //draw enemy
        }

        private void gameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && !directionPressed) //if A key is pressed, return "left"
            {
                MovePlayerAnim("left");

            }
            if (e.KeyCode == Keys.D && !directionPressed)
            {
                MovePlayerAnim("right"); //if D key is pressed, return "Right"
            }

        }

        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.D) //if A or D key is released
            {
                left = false; //set the directions to false and reset player
                right = false;
                directionPressed = false;
                ResetPlayer();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            ImageAnimator.UpdateFrames();  //redraws the image every frame
            movePlayer();


            bool collision = collide(characterX, characterY, character.Width, character.Height, doorX, doorY, door.Width, door.Height); //check for collision between character and door.


            if (collision)
            {
                gameScreen newp = new gameScreen(current); //open gamescreen.
                newp.Show();
                this.Close();

            }

        }
        private void movePlayer()
        {
            if (left) //if left variable is true, move character to left by 5 pixels.
            {
                if (characterX > 0) //characterX must be greater than 0.
                {
                    characterX -= 5;
                }
            }
            if (right) //if right variable is true, move character to right by 5 pixels.
            {
                if (characterX + character.Width < this.ClientSize.Width) //characaterX must not be beyond width of form.
                {
                    characterX += 5;
                }
            }

        }

        private void ResetPlayer()
        {
            if (!directionPressed)
            {
                characterY = 320; //if directionPressed is false, reset y position of character.

            }
            character = characteridle; //set character animation to idle, as it is not moving



            SetUpAnim(); //animate character
        }


        private void MovePlayerAnim(string dir)
        {
            if (dir == "right")
            {
                right = true;
                character = characterfw;
            }
            if (dir == "left")
            {
                left = true;
                character = characterbw;
            }




            directionPressed = true;

            SetUpAnim();
        }

        private bool collide(int charX, int charY, int charWidth, int charHeight, int doorX, int doorY, int doorWidth, int doorHeight) //method to check collisions between the door and the character.
        {
            if (charX + charWidth <= (doorX + 100) || (charX - 100) >= doorX + door.Width || charY + charHeight <= doorY || charY >= doorY + door.Height)
                return false; //checks the bounds of both the character and door, and if there is no collision, return to false

            else
                return true; //otherwise return true.
        }



    }
}
