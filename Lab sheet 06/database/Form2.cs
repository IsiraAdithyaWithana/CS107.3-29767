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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isira\Desktop\database\database\Database1.mdf;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            emailTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string dob = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string email = emailTextBox.Text;
            string contact = contactTextBox.Text;
            string address = addressTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string Query1 = $"INSERT INTO Employee(Username,Name,DOB,Password) VALUES('{username}','{name}','{dob}','{password}');";
            SqlCommand cmd1 = new SqlCommand(Query1, sqlConnection);

            string Query2 = $"INSERT INTO Contact(Username,ContactNo,Email,Address) VALUES('{username}','{contact}','{email}','{address}')";
            SqlCommand cmd2 = new SqlCommand(Query2, sqlConnection); //Connection 2
                try
                {
                    sqlConnection.Open();
                    cmd1.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Registration successfull !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlConnection.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("errors:" + sqlEx.Message, "Registration Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
