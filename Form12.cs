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

namespace AntorFinalProjectC_
{
    public partial class Form12 : Form
    {
        private string connectionString = @"Data Source=LAPTOP-5KVIB8LF\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True";
        private DataTable originalDataTable;
        public Form12()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM SubjectCourse", sqlCon);
                originalDataTable = new DataTable();
                sqlDa.Fill(originalDataTable);
                dataGridView1.DataSource = originalDataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

             Form9 form9 = new Form9();
            form9.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {








        }

        private void label2_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                // If search term is empty, show the original data
                dataGridView1.DataSource = originalDataTable;
            }
            else
            {
                // Filter the original data based on the subject name
                DataView dv = new DataView(originalDataTable);
                dv.RowFilter = $"Subjects LIKE '%{searchTerm}%'";
                dataGridView1.DataSource = dv.ToTable();
            }
        }
    }
}
