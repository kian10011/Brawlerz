using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fighting_game
{
    public partial class CrownOfGlory : Form
    {
        Player current;
        Image background = Properties.Resources.completed_bg;
        Image crown = Properties.Resources.crown;

        SoundPlayer v = new SoundPlayer(Properties.Resources.victory);
        int CrownX = 320;
        int CrownY = -150;

        string fp = "scores.txt";
        Random randomScore = new Random();

        bool popUp;

        StreamWriter sw;
        FileStream fs;
        public CrownOfGlory(Player mp)
        {
            current = mp;
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true); //makes animation smoother

            animBG();
            hideVictory();
            hidePopUp();

        }
        private void saveScore()
        {
            fs = !File.Exists(fp) ? new FileStream(fp, FileMode.Create, FileAccess.Write)
                : new FileStream(fp, FileMode.Append, FileAccess.Write);

            sw = new StreamWriter(fs);

            sw.WriteLine(current.Name + "~" + current.Score + "~" + current.Rounds);
            sw.Close();
            fs.Close();
        }


        private void CrownOfGlory_Load(object sender, EventArgs e)
        {
            v.Play();
        }

        private void CrownOfGlory_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            g.DrawImage(background, new Point(0, 0));
            if (!popUp)
                g.DrawImage(crown, new Point(CrownX, CrownY));

        }

        private void OnFrameChangedHandler(object sender, EventArgs e)
        {
            this.Invalidate();

        }
        private void animBG()
        {
            ImageAnimator.Animate(background, this.OnFrameChangedHandler);
            ImageAnimator.Animate(crown, this.OnFrameChangedHandler);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ImageAnimator.UpdateFrames();

            Opacity += 0.1;
            if (Opacity == 1)
            {
                CrownY += 10;

                if (CrownY == 250)
                {
                    timer1.Stop();
                    showVictory();
                    current.Score += randomScore.Next(0, 10000);
                    lblscore.Text += current.Score.ToString();
                    prologue.backgroundNo = 1;
                    prologue2.backgroundNo2 = 1;
                    gameScreen.backgroundLvl = 1;
                    current.Rounds++;
                    saveScore();
                }
            }
        }
        private void hideVictory()
        {
            lblscore.Hide();
            victoryReturnbtn.Hide();
            victorylbl.Hide();
            btnLeaderboard.Hide();
        }
        private void showVictory()
        {
            lblscore.Show();
            victoryReturnbtn.Show();
            victorylbl.Show();
            btnLeaderboard.Show();
        }

        private void victoryReturnbtn_Click(object sender, EventArgs e)
        {
            showPopUp();
            popUp = true;
            victoryReturnbtn.Hide();
        }

        private void lblscore_Click(object sender, EventArgs e)
        {

        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderBoard newb = new LeaderBoard(current);
            newb.Show();
            this.Close();
        }

        private void showPopUp()
        {

            lblPlayMinigame.Show();
            btnYes.Show();
            btnNo.Show();
            pictureChibi.Show();
          

            victorylbl.Hide();
            btnLeaderboard.Hide();
        }
        private void hidePopUp()
        {

            lblPlayMinigame.Hide();
            btnYes.Hide();
            btnNo.Hide();
            pictureChibi.Hide();
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Menu newm = new Menu(current);
            newm.Show();
            this.Close();
            popUp = false;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            brawlerzRunTut newb = new brawlerzRunTut(current);
            newb.Show();
            this.Close();
            popUp = false;
        }
    }

}
