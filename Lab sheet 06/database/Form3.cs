using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace database
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isira\Desktop\database\database\Database1.mdf;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = searchTextBox.Text;

            sqlConnection.Open();

            string query = $"SELECT e.Username, e.Name, e.DOB, e.Password, c.Username, c.ContactNo, c.Email, c.Address " +
                           $"FROM Employee e " +
                           $"INNER JOIN Contact c ON e.Username = c.Username " +
                           $"WHERE c.Username = '{username}'";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            sqlConnection.Close();

            if(dataTable.Rows.Count > 0) 
            {
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Employee Not Found.");
            }
            sqlConnection.Close();
        }
        private DataTable GetDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            sqlConnection.Open();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                adapter.Fill(dataTable);
            }

            sqlConnection.Close();

            return dataTable;
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Get the current row selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the data from the selected row in Contact table
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string username  = selectedRow.Cells["Username"].Value.ToString();
                string contactNo = selectedRow.Cells["ContactNo"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string dob = selectedRow.Cells["DOB"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();

                // Open the connection to the database
                sqlConnection.Open();

                // Update the record in the database Contact table
                string updateQuery = $"UPDATE Contact SET ContactNo = '{contactNo}', Email = '{email}', Address = '{address}' WHERE Username = '{username}'";
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                int rowsAffected = updateCommand.ExecuteNonQuery();

                // Update the record in the database Emplyee table
                string updateQuery1 = $"UPDATE Employee SET Name = '{name}', DOB = '{dob}', Password = '{password}' WHERE Username = '{username}'";
                SqlCommand updateCommand1 = new SqlCommand(updateQuery1, sqlConnection);
                int rowsAffected1 = updateCommand1.ExecuteNonQuery();

                // Close the connection to the database
                sqlConnection.Close();

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update record.");
                }

                // Refresh the DataGridView to reflect the changes
                button2_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }
    }
}
