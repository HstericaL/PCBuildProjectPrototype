using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemModel
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();

            //textBoxPassword Configuration
            textBoxPassword.Text = "";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 14;

            //PictureBox Configuration
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {

                MessageBox.Show("Administrator Logged In!", "Administrator Access");
                Console.WriteLine("User|Admin Logged in");

                this.Hide();

                //Dashboard Form
                var formDashboard = new formDashboard();
                formDashboard.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password wrong!", "Error");
                Console.WriteLine("Username or Password wrong!");
            }
        }
    }
}
