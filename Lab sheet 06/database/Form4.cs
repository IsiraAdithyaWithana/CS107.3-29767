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

namespace database
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isira\Desktop\database\database\Database1.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string Query2 = "SELECT * FROM Employee;";

            SqlDataAdapter adapter = new SqlDataAdapter(Query2, sqlConnection);
            DataSet set = new DataSet();

            adapter.Fill(set, "Employee");
            dataGridView1.DataSource = set.Tables["Employee"];
        }
    }
}
