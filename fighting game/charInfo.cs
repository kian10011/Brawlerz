using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace fighting_game
{ 
    public partial class charInfo : Form
    { Player current;
        public charInfo(Player mp)
        { current = mp;
            InitializeComponent();

            
            if(current.Skin == 0)
            {
                pictureBrawler.BackgroundImage = Properties.Resources.char1Idle;
                lblName.Text = "RYUSUKE";
                textboxCharInfo.Text = " Born in Japan, Ryusuke was orphaned at a young age and left to fend for himself on the streets. His only source of solace and guidance was the martial arts dojo where he trained under the watchful eye of his mentor, Gouken. Throughout his journey, Ryusuke sought balance and control, always wary of the allure of power without restraint. His encounters with various fighters, further shaped his understanding of the world and his place in it. ";
                lblStrength.Text += "4 / 5";
                lblAgility.Text += "2 / 5";
                lblHealth.Text += "3 / 5";
            }
            if (current.Skin == 1)
            {
                pictureBrawler.BackgroundImage = Properties.Resources.char2Idle ;
                lblName.Text = "CAMMIE";
                textboxCharInfo.Text = "Cammie, the mysterious and highly skilled fighter, originated from an elite military unit called \"Shadow Force.\" Cammie's journey transformed into a quest for self-discovery, redemption, and liberation from the chains of manipulation. Through her trials, she not only reclaimed her memories but also emerged as a symbol of resilience and strength.";
                lblStrength.Text += "2 / 5";
                lblAgility.Text += "5 / 5";
                lblHealth.Text += "2 / 5";
            }
            if (current.Skin == 2)
            {
                pictureBrawler.BackgroundImage = Properties.Resources.char3Idle;
                lblName.Text = "SHUN LI";
                textboxCharInfo.Text = "Born into a family with a long and secretive history of safeguarding ancient artifacts, Shun-Li grew up surrounded by tales of mystical powers and ancient martial arts techniques. Her ancestors were said to have been entrusted with protecting a mysterious relic known as the \"Dragon's Essence,\" a powerful artifact said to grant incredible strength to those who mastered its secrets.";
                lblStrength.Text += "2 / 5";
                lblAgility.Text += "4 / 5";
                lblHealth.Text += "3 / 5";
            }
            if (current.Skin == 3)
            {
                pictureBrawler.BackgroundImage = Properties.Resources.char4Idle;
                lblName.Text = "AKUMO";
                textboxCharInfo.Text = "Born Goki Matsuo, Akuma was initially trained in the martial arts by his elder brother, Goutetsu. Akumo was a master of Ansatsuken, a deadly fighting style that embraced both the physical and spiritual aspects of combat. However, Akumo harbored a hidden secret: he practiced the forbidden art of the Satsui no Hado, a power that consumed its users with an insatiable lust for combat and destruction.";
                lblStrength.Text += "4 / 5";
                lblAgility.Text += "1 / 5";
                lblHealth.Text += "4 / 5";
            }
            HideInfo();
            HideStats();
        }

        private void charInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu newmenu = new Menu(current);
            newmenu.Show();
            this.Hide();
        }
        private void ShowInfo()
        {
            btnBack.Show();
            btnStats.Hide();
            btnReturnToMainMenu.Hide();
            pictureBrawler.Location = new Point(110, 61);
            textboxCharInfo.Show();
            btnGeneralInfo.Hide();
        }
        private void HideInfo()
        {
            btnBack.Hide();
            btnStats.Show();
            btnReturnToMainMenu.Show();
            pictureBrawler.Location = new Point(296, 61);
            textboxCharInfo.Hide();
            btnGeneralInfo.Show();

        }
        private void ShowStats()
        {
            btnReturnToMainMenu.Hide();
            btnBack.Show();
            lblStrength.Show();
            pictureBrawler.Location = new Point(110, 61);
            lblAgility.Show();
            lblHealth.Show();
            btnGeneralInfo.Hide();
            btnStats.Hide();
        }
        private void HideStats()
        {
            btnReturnToMainMenu.Show();
            btnBack.Hide();
            lblStrength.Hide();
            lblAgility.Hide();
            lblHealth.Hide();
            btnGeneralInfo.Show();
            btnStats.Show();
        }
        private void btnGeneralInfo_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ShowStats();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            HideStats();
            HideInfo();
        }
    }
}
