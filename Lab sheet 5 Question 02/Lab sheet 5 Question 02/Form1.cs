using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_sheet_5_Question_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstName.Text) && string.IsNullOrEmpty(txtLastName.Text) && string.IsNullOrEmpty(txtDOB.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPass.Text) && string.IsNullOrEmpty(txtCPass.Text))
            {
                MessageBox.Show("Please fill all the fields before signup.");
            }
            else
            {
                if (txtPass.Text == txtCPass.Text)
                {
                    string Name = txtFirstName.Text + txtLastName.Text;
                    string UserName = txtUsername.Text;
                    string Email = txtEmail.Text;

                    Form2 form2 = new Form2(Name,UserName,Email);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Passwords are not same. Please match the passwords");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDOB.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPass.Text = "";
            txtCPass.Text = "";
        }
    }
}
