using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanabishi
{
    public partial class frmHanabishi : Form
    {
        public frmHanabishi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmHanabishi_Load(object sender, EventArgs e)
        {
            
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text == "Semaphore" && txtPassword.Text == "Group1")
            {
                
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                txtPassword.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btnShowpassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                // Show password
                txtPassword.PasswordChar = '\0';
                txtUsername.ForeColor = Color.Black;
            }
            else
            {
                // Hide password
                txtPassword.PasswordChar = '*';
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // You can remove this if not needed
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            // You can remove this if not needed
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            // You can remove this if not needed
        }

        private void lblHanabishi_Click(object sender, EventArgs e)
        {

        }
    }
}
