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
    public partial class Form2 : Form
    {
        string Name;
        string UserName;
        string Email;
        public Form2(string name, string userName, string email)
        {
            InitializeComponent();
            Name = name;
            UserName = userName;
            Email = email;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text = Name;
            lblUsername.Text = UserName;
            lblEmail.Text = Email;
        }
    }
}
