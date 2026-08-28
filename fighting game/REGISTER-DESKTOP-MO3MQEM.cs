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

        private void btnConfRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxUser.Text) && !string.IsNullOrEmpty(tbxPass.Text) && !string.IsNullOrEmpty(tbxConf.Text))
            {
                if (tbxPass.Text == tbxConf.Text)
                {
                    if (tbxPass.Text.Length > 5)
                    {
                        bool containsRestrictedLetter = tbxPass.Text.IndexOf(letters) >= 0;
                        if (containsRestrictedLetter == true)
                        {
                            MessageBox.Show("Your password must not include the character '~'. ", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (tbxPass.Text.Any(char.IsUpper) == true)
                            {
                               
                                
                                    valid = true;
                            }
                            else
                                MessageBox.Show("Your password must contain a capital letter. ", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                        MessageBox.Show("Your password must contain more than 5 chracter.", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                     else
                            MessageBox.Show("Passwords do not match.", " Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Not all fields have been completed.", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (valid)
            {
                fs = !File.Exists(fp) ? new FileStream(fp, FileMode.Create, FileAccess.Write)
                    : new FileStream(fp, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine(tbxUser.Text + "~" + tbxPass.Text + "~0" + "~0");
                sw.Close();
                fs.Close();

                MessageBox.Show("User has been added succesfully.", "Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                LOGIN myLogin = new LOGIN();
                myLogin.Show();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN newLogin = new LOGIN();
            newLogin.Show();
        }
    }   
}
