using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace fighting_game
{
    public partial class LOGIN : Form
    {
        bool userFound;
        SoundPlayer theme = new SoundPlayer(Properties.Resources.Login_Theme);



        public LOGIN()
        {
            InitializeComponent();
            
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            theme.Play();
        }
       
       
        private void btn_ConfLogin_Click(object sender, EventArgs e) //when login button is pressed
        {
            if (!string.IsNullOrEmpty(tbxUser.Text) && !string.IsNullOrEmpty(tbxPass.Text)) //checks if username and password textboxes are empty
            {
                try //try block
                {
                    string[] users = File.ReadLines("userData.txt").ToArray(); //converts the data inside textfile into array.

                    for (int i = 0; i < users.Length; i++)
                    {
                        string[] userNameAndPassword = users[i].Split('~'); //split data using tildes.

                        if (tbxUser.Text == userNameAndPassword[0] && tbxPass.Text == userNameAndPassword[1]) //if username and password match with the data registered in file
                        {
                            MessageBox.Show("Success!", "You are now logged in.", MessageBoxButtons.OK, MessageBoxIcon.Information); //messagae
                            userFound = true;
                            Player myPlayer = new Player(); //instantiate a new player object.
                            myPlayer.Name = tbxUser.Text; //set the name, score and skin chosen by user.
                            myPlayer.Score = 0;
                            myPlayer.Skin = Int32.Parse(userNameAndPassword[2]);
                            myPlayer.Rounds = 0; //default rounds of 0
                            Options character = new Options(myPlayer); 
                            
                            
                            character.Show(); //open character selection screen
                            this.Close();

                            StartForm obj = (StartForm)Application.OpenForms["StartForm"]; //Closes the startForm as it is still open in the background. This is to stop the background music from continually playing.
                            obj.Close();

                            break;



                        }
                        
                    }

                    if (!userFound)
                        MessageBox.Show("User not found.", "Enter the correct username and password.", MessageBoxButtons.OK, MessageBoxIcon.Information); //if username or password is incorrect
                }
                catch
                {
                    MessageBox.Show("Userdata file not found.", "Create a Userdata file to store your user.", MessageBoxButtons.OK, MessageBoxIcon.Information); //if trying fails, show error message.
                }
               

            }
            else
                MessageBox.Show("Textboxes cannot be empty.", "\nPlease fill the textboxes and try again!", MessageBoxButtons.OK, MessageBoxIcon.Information); //if textboxes are empty


        }

       
        private void btnSendReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            REGISTER m = new REGISTER();   //open new register screen
            m.Show();
        }

        private void tbxPass_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
