using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_sheet_4_Question_01
{
    public partial class Form1 : Form
    {
        public int firstInt;
        public int secondInt;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + "" + 7);
        }

        private void txt1_Click(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + ""+1);
        }

        private void txt2_Click(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + "" + 2);
        }

        private void txt3_Click(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + "" + 3);
        }

        private void txt4_Click(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + "" + 4);
        }

        private void txt5_Click(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + "" + 5);
        }

        private void txt6_Click(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + "" + 6);
        }

        private void txt8_Click(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + "" + 8);
        }

        private void txt9_Click(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + "" + 9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtBox.Text = (txtBox.Text + "" + 0);
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            firstInt = 0;
            secondInt = 0;
        }

        private void txtPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox.Text))
                {
                    firstInt = 0;
                    secondInt = 0;
                }
                else
                {
                    firstInt = firstInt + Convert.ToInt32(txtBox.Text);
                }
                txtBox.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void txtMinus_Click(object sender, EventArgs e)
        {
            
            try
            {
                firstInt = firstInt - Convert.ToInt32(txtBox.Text);
                txtBox.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox.Text))
                {
                    firstInt = 0;
                    secondInt = 0;
                }
                else
                {
                    firstInt = Convert.ToInt32(txtBox.Text);
                }
                txtBox.Text = "";
                button1.Visible = false;
                txtSub.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void txtDivide_Click(object sender, EventArgs e)
        {
            try
            {
                firstInt = firstInt / Convert.ToInt32(txtBox.Text);
                txtBox.Text = "";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Can't divide by zero");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox.Text))
                {
                    firstInt = 0;
                    secondInt = 0;
                }
                else
                {
                    firstInt = Convert.ToInt32(txtBox.Text);
                }
                button2.Visible = false;
                txtDiv.Visible = true;
                txtBox.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void txtMulti_Click(object sender, EventArgs e)
        {
            try
            {
                firstInt = firstInt * Convert.ToInt32(txtBox.Text);
                txtBox.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox.Text))
                {
                    firstInt = 0;
                    secondInt = 0;
                }
                else
                {
                    firstInt = Convert.ToInt32(txtBox.Text);
                }
                txtBox.Text = "";
                button3.Visible = false;
                txtMul.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void txtSum_Click(object sender, EventArgs e)
        {
            try
            {
                secondInt = Convert.ToInt32(txtBox.Text);
                int sum = firstInt + secondInt;
                txtBox.Text = ($"{sum}");
                txtDiv.Visible = false;
                txtMul.Visible = false;
                txtSub.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void txtSub_Click(object sender, EventArgs e)
        {
            try
            {
                secondInt = Convert.ToInt32(txtBox.Text);
                int sub = firstInt - secondInt;
                txtBox.Text = ($"{sub}");
                txtDiv.Visible = false;
                txtMul.Visible = false;
                txtSub.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void txtDiv_Click(object sender, EventArgs e)
        {
            try
            {
                secondInt = Convert.ToInt32(txtBox.Text);
                int div = firstInt / secondInt;
                txtBox.Text = ($"{div}");
                txtDiv.Visible = false;
                txtMul.Visible = false;
                txtSub.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Can't divide by zero");
            }
        }

        private void txtMul_Click(object sender, EventArgs e)
        {
            try
            {
                secondInt = Convert.ToInt32(txtBox.Text);
                int mul = firstInt * secondInt;
                txtBox.Text = ($"{mul}");
                txtDiv.Visible = false;
                txtMul.Visible = false;
                txtSub.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }
    }
}
