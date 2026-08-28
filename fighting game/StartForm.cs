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
    public partial class StartForm : Form
    {
     
        public StartForm()
        {
            InitializeComponent();
            WMP.URL = @"Sounds\s3.mp3";
            WMP.settings.playCount = 999;
            WMP.Ctlcontrols.play();
            WMP.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            REGISTER m = new REGISTER();
            m.Show();

        }

        private void Loginbutton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN newLogin= new LOGIN();
            newLogin.Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void WMP_Enter(object sender, EventArgs e)
        {

        }
    }
}
