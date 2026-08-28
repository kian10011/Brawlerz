using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fighting_game
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100) // if progressbar value is less than 100, increment value by 2 for every tick.
            {
                progressBar.Value += 2;
                if(progressBar.Value >= 100) //if progressbar is equal or greater than 100, open a new startForm.
                {
                    StartForm newReg = new StartForm();
                    newReg.Show();
                    this.Hide(); 

                }
            }
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
