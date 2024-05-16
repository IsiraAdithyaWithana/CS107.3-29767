using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employeeD = new Employee();

            employeeD.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contact contactD = new Contact();
            contactD.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display displayD = new Display();
            displayD.Show();
            
        }
    }
}
