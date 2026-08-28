using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace fighting_game
{
    public partial class LeaderBoard : Form
    {
        Player current;        //variables
        string fp = "scores.txt";

        public LeaderBoard(Player mp)
        {
            InitializeComponent();
            current = mp;

            bgMusicPlayer.URL = @"Sounds\s4.wav";  //import sound file
            bgMusicPlayer.settings.playCount = 999; //play it 999 times
            bgMusicPlayer.Ctlcontrols.play(); //set default value to play.
            bgMusicPlayer.settings.volume = gameSettings.vol;




            ReadScores();  //call  method
        }
        private void ReadScores()
        {
            try
            {
                if (File.Exists(fp))
                {
                    string[] userScores = File.ReadLines(fp).ToArray();         //If file exists, then the score will be added to the table

                    if (userScores.Length > 0)
                    {   
                        lblScores.Visible = false;        //remove scores label
                        tableScores.Visible = true;       //show score table

                        foreach (string s in userScores)
                        { 
                            string[] splitUserScores = s.Split('~');   //split each section of score using tilde

                            if (string.IsNullOrWhiteSpace(s))
                                continue;

                            tableScores.Rows.Add(splitUserScores[0], splitUserScores[1], splitUserScores[2]);
                        }
                    }
                }
                else
                    MessageBox.Show("No scores can be found.", "Please play a game!", MessageBoxButtons.OK, MessageBoxIcon.Information);  //error message
            }
            catch(Exception e)
            {
                MessageBox.Show("There has been an error!  \n" + e.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);  //error message

            }
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu newmenu = new Menu(current);
            newmenu.Show();
            this.Close();
           
        }

        private void lblScores_Click(object sender, EventArgs e)
        {

        }

        private void tableScores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
