using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Taskbar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace fighting_game
{
    public partial class prologue2 : Form
    {
        Player current;
        Image background;

        bool pressContinue, skip;


        public static int backgroundNo2 = 1;

        int g = 0;

        string thirdPrologue = "After fighting various opponents, you have finally reached the current holder of the Crown Of Glory, Gertrude."; // set text of third and fourth prologue.
        string fourthPrologue = "You enter Gertrude's fiery castle, found on the outskirts of the Twilight Abyss. You prepare for battle.";
        public prologue2(Player mp)
        {
            current = mp;

            InitializeComponent();
            animBG(); //animate background

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true); //allows smooth animation and no flickering.

            btnNext.Hide(); //hide next buttons
            btnNext2.Hide();

            if (backgroundNo2 == 1) //set the background image depending on the backgroundNo.
            {
                background = Properties.Resources.BlackBG;
            }
            if (backgroundNo2 == 2)
            {
                background = Properties.Resources.prologue_bg4;
            }

            WMP.URL = @"Sounds\boss.mp3"; //set the mp3 file for music player.

            WMP.settings.playCount = 999; //play 999 times
            WMP.Ctlcontrols.play(); //set default status to play
            WMP.Visible = false; //hide player.

        }

        private void prologue2_Load(object sender, EventArgs e)
        {

        }

        private void prologue2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(background, new Point(0, 0)); //draw background
        }

        private void timerTransition_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1; //increase opacity by 0.1 for every tick and once it reaches 1, stop timer
            if (Opacity == 1)
            {
                timerTransition.Stop();
            }
        }

        private void animBG()
        {
            ImageAnimator.Animate(background, this.OnFrameChangedHandler); //animate background
        }
        private void OnFrameChangedHandler(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void timerTransOut_Tick(object sender, EventArgs e)
        {
            if (g > thirdPrologue.Length || g > fourthPrologue.Length) //if g ends up greater than the prologue text
            {
                if (backgroundNo2 == 1)
                {
                    btnNext.Show(); //show next buttons belonging to their respective backgroundNo. 
                }
                if (backgroundNo2 == 2)
                {
                    btnNext2.Show();
                }
                if (pressContinue)
                {
                    Opacity -= 0.1; //if press continue is true, decrease opacity by 0.1 for every tick.

                    if (Opacity == 0) //if opacit reaches 0, stop timer and reopen prologue screen with updated backgroundNo.
                    {
                        timerTransOut.Stop();
                        
                        prologue2 newp = new prologue2(current);
                        newp.Show();
                        this.Close();

                    }

                }

            }
        }

        private void timerPrologue2_Tick(object sender, EventArgs e)
        {
            ImageAnimator.UpdateFrames(); //update frames

            if (backgroundNo2 == 1)
            {
                if (g < thirdPrologue.Length + 1) //if int g is less than the length of the firstprologue text + 1
                {
                    textBoxPrologue1.Text = thirdPrologue.Substring(0, g);  //show text substring from 0 to g, and increase g for every tick. This allows a letter by letter animation.
                    g++;

                }
                if (skip == true)
                {
                    textBoxPrologue1.Text = thirdPrologue; //if skip is true, set int g equal to the length of the firstprologue text, so that all of the text shows instantly.
                    g = thirdPrologue.Length + 1;
                }
            }
            if (backgroundNo2 == 2)
            {
                if (g < fourthPrologue.Length + 1)  //same as above, but with different text and background.
                {
                    textBoxPrologue1.Text = fourthPrologue.Substring(0, g);
                    g++;

                }
                if (skip == true) //skip letter by letter animation
                {
                    textBoxPrologue1.Text = fourthPrologue;
                    g = fourthPrologue.Length + 1;
                }
            }

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            skip = true; //set skip variable to true.
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            PregameScreen newp = new PregameScreen(current); //open pregamescreen
            newp.Show();
            this.Close();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            pressContinue = true; //set presscontinue variable to true.
            if (backgroundNo2 == 1)
            {
                prologue2.backgroundNo2 = 2; //if background is equal to 1, increment it by 1.
            }

        }



    }
}
