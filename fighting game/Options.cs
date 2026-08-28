using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace fighting_game
{
    public partial class Options : Form
    {
        Player current;
        int charchange = 0;
        string namechange = "";
        public Options(Player mp)
        {
            InitializeComponent();
            current = mp;
            switch (current.Skin) //set the resource for each skin number, with its name.
            {
                case 0:
                    panBrawler.BackgroundImage = Properties.Resources.char1;
                    lblCharName.Text = "RYUSUKE"; break;
                case 1:
                    panBrawler.BackgroundImage = Properties.Resources.char2Idle;
                    lblCharName.Text = "CAMMIE";
                    break;
                case 2:
                    panBrawler.BackgroundImage = Properties.Resources.char3;
                    lblCharName.Text = "SHUN LI"; break;
                case 3:
                    panBrawler.BackgroundImage = Properties.Resources.char4;
                    lblCharName.Text = "AKUMO"; break;


            }
            panBrawler.BackgroundImageLayout = ImageLayout.Stretch; //set backgroundimage layout of the panBrawler panel to stretched, so that the image of the brawler fits the full panel.
                                                                      
            panBrawler.AllowDrop = true; //allow drop function

        }

        private void saveSkin()
        {

            var originalFile = "userData.txt"; //set file name, so that the system knowa where to change the skin variable.
            var tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader(originalFile))
            using (var sw = new StreamWriter(tempFile))
            {
                string user;
                while ((user = sr.ReadLine()) != null)
                {
                    if (!user.StartsWith(current.Name))  
                        sw.WriteLine(user);
                    else
                    {
                        string[] lineSplit = user.Split('~'); //split data using tilde with the updated skin number.
                        sw.WriteLine(lineSplit[0] + "~" + lineSplit[1] + "~" + current.Skin.ToString());
                    }
                }
            }
            File.Delete(originalFile); //delete old version of file and replace with the new file set in "tempfile".
            File.Move(tempFile, originalFile);
        }
        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Panel source = (Panel)sender;
            charchange = Int32.Parse(((Panel)source).Tag.ToString()); //set charchange to the tag of the panel being dragged.
            DoDragDrop(source.BackgroundImage, DragDropEffects.Copy); //copy the background image of that panel.

        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
                e.Effect = DragDropEffects.Copy; //copy the image of the panel being dragged onto the panBrawler panel.
            else
                e.Effect = DragDropEffects.None;

        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Panel destination = (Panel)sender;
            destination.BackgroundImage = (Bitmap)e.Data.GetData(typeof(Bitmap));  //set the backgroundImage of the panBrawler panel to the copied brawler image.
            current.Skin = charchange; //set the skin variable in the player class to charchange.

            switch (current.Skin) //update the name of the brawler.
            {
                case 0:

                    lblCharName.Text = "RYUSUKE"; break;
                case 1:

                    lblCharName.Text = "CAMMIE";
                    break;
                case 2:

                    lblCharName.Text = "SHUN LI"; break;
                case 3:

                    lblCharName.Text = "AKUMO"; break;


            }
            saveSkin(); //call saveskin method
        }


        private void Options_Load_1(object sender, EventArgs e)
        {

        }

        private void panBrawler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            Menu newm = new Menu(current); //open menu screen.
            newm.Show(); 
            this.Hide();
        }

        private void char2panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



