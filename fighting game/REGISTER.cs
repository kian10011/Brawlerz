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
using System.Media;

namespace fighting_game
{
    public partial class REGISTER : Form
    {
        char letters = '~';
        bool valid = false;
        string fp = @"userData.txt";
        FileStream fs;
        StreamWriter sw;
        public REGISTER()
        {
            InitializeComponent();

        }

        private void REGISTER_Load(object sender, EventArgs e)
        {

        }
        private void btnReg_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(tbxUser1.Text) && !string.IsNullOrEmpty(tbxPass1.Text) && !string.IsNullOrEmpty(tbxConfPass.Text)) //checks if the textboxes are empty
            {
                if (tbxPass1.Text == tbxConfPass.Text) //check if password is the same as confirm password
                {
                    if (tbxPass1.Text.Length > 5)
                    {
                        bool containsRestrictedLetter = tbxPass1.Text.IndexOf(letters) >= 0; //since tilde is a restricted character, this checks if the password textbox contains any tildes.
                        if (containsRestrictedLetter == true)
                        {
                            MessageBox.Show("Your password must not include the character '~'. ", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error); //if true, show error message.
                        }
                        else
                        {
                            if (tbxPass1.Text.Any(char.IsUpper) == true) //if the password contains an uppercase letter
                            {
                                if (checkUsername()) //if username does not already exist
                                {
                                    valid = true;  //if everything is valid, set valid to true.
                                }
                                else
                                    MessageBox.Show("This user already exists. Change your username. ", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //if checkUsername is false, show error message
                            }
                            else
                                MessageBox.Show("Your password must contain a capital letter. ", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //if password does not contain capital letter, show error message
                        }
                    }

                    else
                        MessageBox.Show("Your password must contain more than 5 characters.", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //if password contains less than 5 characters, show error message
                }
                else
                    MessageBox.Show("Passwords do not match.", " Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //if tbxPass1 and tbxConfPass do not contain the same data, show error message.

            }
            else
                MessageBox.Show("Not all fields have been completed.", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //if not all textboxes are filled, show error message

            try
            {


                if (valid) 
                {
                    fs = new FileStream(fp, FileMode.Append, FileAccess.Write); //if  valid, write to the existing userData file
                    sw = new StreamWriter(fs);


                    sw.WriteLine(tbxUser1.Text + "~" + tbxPass1.Text + "~0" + "~0"); //split the pieces of data using tildes and set the default value to 0.
                    sw.Close();
                    fs.Close();

                    MessageBox.Show("User has been added succesfully.", "Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information); //message

                    this.Close();
                    LOGIN myLogin = new LOGIN(); //open login screen
                    myLogin.Show();

                }
            }
            catch
            {
                new FileStream(fp, FileMode.Create, FileAccess.Write);  //if file does not exist, create it.
                sw = new StreamWriter(fs);


                sw.WriteLine(tbxUser1.Text + "~" + tbxPass1.Text + "~0" + "~0" + "~0"); //separate data
                sw.Close();
                fs.Close();

            }

        }

        private bool checkUsername()
        {

            string[] users = File.ReadLines("userData.txt").ToArray(); //turns the data inside userData.txt into an array

            for (int i = 0; i < users.Length; i++) //check through array and split using tilde.
            {
                string[] userNameAndPassword = users[i].Split('~');

                if (tbxUser1.Text == userNameAndPassword[0]) //if username entered by user in register screen matches a data already inside the textfile, return false.
                {
                    return false;
                }


            }

            return true;

        }

        private void btnSendLog_Click(object sender, EventArgs e)
        {
            LOGIN newL = new LOGIN(); //open login screen.
            newL.Show();
            this.Hide();
        }

        private void tbxUser1_TextChanged(object sender, EventArgs e)
        {

        }

        private void REGISTER_Load_1(object sender, EventArgs e)
        {

        }
    }
}
