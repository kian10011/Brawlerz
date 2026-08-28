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

namespace fighting_game
{
    public partial class LOGIN : Form
    {
        bool userFound;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btn_ConfLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxUser.Text) && !string.IsNullOrEmpty(tbxPass.Text))
            {
                if (File.Exists("userData.txt"))
                {
                    string[] users = File.ReadLines("userData.txt").ToArray();

                    for (int i = 0; i < users.Length; i++)
                    {
                        string[] userNameAndPassword = users[i].Split('~');

                        if (tbxUser.Text == userNameAndPassword[0] && tbxPass.Text == userNameAndPassword[1])
                        {
                            userFound = true;
                            Player myPlayer = new Player();
                            myPlayer.Name = tbxUser.Text;
                            myPlayer.Score = 0;
                            myPlayer.Skin = Int32.Parse(userNameAndPassword[2]);
                            myPlayer.Time = 0;
                            myPlayer.Rounds = 0;
                            Options m= new Options(myPlayer);
                            m.Show();
                            this.Close();
                            break;



                        }
                    }

                    if (!userFound)
                        MessageBox.Show("User not found.", "Enter the correct username and password.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No users have been registered.", "please enter a user before playing.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Textboxes cannot be empty.", "\nPlease fill the textboxes and try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            REGISTER m = new REGISTER();
            m.Show();



        }
    }
}
