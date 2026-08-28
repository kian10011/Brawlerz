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
    public partial class brawlerzRunTut : Form
    { Player current;    //variables
       
        public brawlerzRunTut(Player mp)
        {
            current = mp;
            InitializeComponent();
            showTutorial(); //show tutorial set of buttons.
        }

        private void brawlerzRunTut_Load(object sender, EventArgs e)
        {
           
        }

        private void showTutorial()
        {
            textboxHowToPlay.Show(); //show the tutorial set of functions.
            btnStartGame.Show();
            btnExitGame.Show();
           
        }
      
     

      

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            brawlerzRun newb = new brawlerzRun(current); //if start game is pressed, open a new brawlerzRun screen.
            newb.Show();
            this.Close();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Menu newm = new Menu(current); //if exit game is pressed, open a new mainmenu screen.
            newm.Show();
            this.Close();
        }
    }
}
