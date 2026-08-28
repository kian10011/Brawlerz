using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace fighting_game
{
    public partial class Menu : Form
    {
        int colourCount = 255, colourCountInv = 0;
        bool down = true;
        Player current;
        string fp = "";




        public Menu(Player mp)
        {
            InitializeComponent();
            current = mp;
            lblWelcome.Text = "Welcome " + current.Name;
            lblTime.Text = "Time spent:" + current.Time + "Minutes";
            lblRounds.Text = "Rounds played:" + current.Rounds + "Rounds";
            fp = "backups/" + current.Name + "backup.bin";
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fighting_game myGame = new fighting_game(current);
           // myGame.Show();
            //this.Close();
                

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (down)
            {
                colourCount -= 4;
                colourCountInv += 4;
            }
            else
            {
                colourCount += 4;
                colourCountInv -= 4;
            }

           

            if (colourCount > 251)
                down = true;
            else if (colourCount < 4)
                down = false;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options myOptions = new Options(current);
            myOptions.Show();
            this.Close();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN myLogin = new LOGIN();
            myLogin.Show();
            this.Hide();
        }

        private void backupCurrentPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string overwrite = "You are about to overwrite your existing backup, are you sure you still want to conitnue?";

            DialogResult dialogResult = MessageBox.Show(overwrite, "BEWARE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show("Backup  was completed succesfully. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Backup  was cancelled. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void restoreBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string restore = "You are about to load your existing backup and lose your current progress. Would you stil like to continue?";

            DialogResult dialogResult = MessageBox.Show(restore, "BEWARE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Restoration was completed succesfully. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Restoration was cancelled. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
           // btnScores myScores = new btnScores(current);
           // myScores.Show();
           // this.Close();
        }
    }
}
