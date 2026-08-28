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
    public partial class prologue : Form
    {
        Player current;
        Image background;


        bool pressContinue, skip;


        public static int backgroundNo = 1;
        int g = 0;
        string firstPrologue = "Within the dark realms of the land known as the Twilight Abyss, there lay an ancient chronicle, known as the Crown Of Glory. This crown is said to be a symbol of hope, sought by various reigning warriors who recognize its potential as an ancient relic.";
        string secondPrologue = "To achieve this ancient relic, The Crown Of Glory, you must surpass various opponents. Each opponent will increase in difficulty, as you progress to obtain the Crown Of Glory. Defeat Gertrude, the current holder of this ancient relic, to claim yourself as the new holder of the crown!";
       
        public prologue(Player mp)
        {
            InitializeComponent();



            current = mp;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true); //smooth animations and remove flickering

            btnNext.Hide(); //hide next buttons
            btnNext2.Hide();


            if(backgroundNo == 1)
            {
                background = Properties.Resources.prologue_bg1; //set backgrounds of prologue
            }
            if(backgroundNo == 2)
            {
                background = Properties.Resources.prologue_bg2;
            }
            animBG();

            WMP.URL = @"Sounds\aot.mp3"; //set the mp3 file of music player

            WMP.settings.playCount = 999;
            WMP.Ctlcontrols.play();
            WMP.Visible = false;
            WMP.settings.volume = gameSettings.vol;
        }

        private void prologue_Load(object sender, EventArgs e)
        {

        }

        private void timerTransition_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;  //increase opacity for every tick
            if(Opacity == 1)
            {
                timerTransition.Stop(); //stop timer once opacity has reached 100%
            }

           
        }

        private void prologue_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; 
            g.DrawImage(background, new Point(0, 0)); //draw background image with coords 0,0

        }
        private void animBG()
        {
            ImageAnimator.Animate(background, this.OnFrameChangedHandler); //animate background
        }
        private void OnFrameChangedHandler(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void timerPrologue_Tick(object sender, EventArgs e)
        {
            ImageAnimator.UpdateFrames(); //update frames
         
            if (backgroundNo == 1)
            {
                if (g < firstPrologue.Length + 1) //if int g is less than the length of the firstprologue text + 1
                {
                    textBoxPrologue1.Text = firstPrologue.Substring(0, g);  //show text substring from 0 to g, and increase g for every tick. This allows a letter by letter animation.
                    g++;
                    
                    if (skip == true) //if skip is true, set int g equal to the length of the firstprologue text, so that all of the text shows instantly.
                    {
                        textBoxPrologue1.Text = firstPrologue;
                        g = firstPrologue.Length + 1;
                    }
                }
            }
            if (backgroundNo == 2)
            {
                if (g < secondPrologue.Length + 1)
                {
                    textBoxPrologue1.Text = secondPrologue.Substring(0, g); //same as above, but with different text and background.
                    g++;

                }
                if (skip == true)
                {
                    textBoxPrologue1.Text = secondPrologue; //skip letter by letter animation
                    g = secondPrologue.Length + 1;
                }
            }
           


        }

        private void timerTransOut_Tick(object sender, EventArgs e)
        {
            if (g > firstPrologue.Length || g > secondPrologue.Length ) //if int g ends up greater than the prologue text
            {
                if (backgroundNo == 1)
                {
                    btnNext.Show(); //show the next buttons
                }
                if(backgroundNo == 2)
                {
                    btnNext2.Show();
                }
               if(pressContinue)
                {
                    Opacity -= 0.1; //if press continue is true, decrease the opacity by 0.1 for every tick.

                    if (Opacity == 0)
                    {
                        timerTransOut.Stop(); //if opacity is 0, stop the timer.
                        
                       
                            prologue newp = new prologue(current); // open a new prologue scren.
                            newp.Show(); 
                            this.Close();
                        
                       
                        
                    }

                }

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pressContinue = true; //set press continue to true 
            if(backgroundNo == 1)
            {
                prologue.backgroundNo = 2; //set the static variable backgroundNo to 2, so that the screen reopens with the updated backgroundNo.
            }
            
            
           
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            PregameScreen newp = new PregameScreen(current); //open a new pregamescreen.
            newp.Show();
            this.Close();
            
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
             skip = true; //set skip variable to true.
        }
    }
}
