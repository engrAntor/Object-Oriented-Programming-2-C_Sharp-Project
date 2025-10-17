using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AntorFinalProjectC_
{
    public partial class Form9 : Form
    {
        private string userEmail;
        private string userPassword;

        public Form9(string email, string password) : this()
        {
            userEmail = email;
            userPassword = password;

        }

        public Form9()
        {
            InitializeComponent();
        }

        private void courseAndResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // StudentRegistration sr = new 
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-5KVIB8LF\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create and configure the labels to display user information
                Label[] labels = { userid, fname, lname, gen, dob , email };

                // Retrieve user information from the Student table
                string selectQuery = "SELECT UserID, FirstName, LastName, Gender, DateOfBirth , Email FROM Student WHERE Email = @Email AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    // Add parameters or conditions if necessary
                    SqlParameter unitsParam = cmd.Parameters.AddWithValue("@Email", userEmail);
                    if (userEmail == null)
                    {
                        unitsParam.Value = DBNull.Value;
                    }
                    SqlParameter pass = cmd.Parameters.AddWithValue("@Password", userPassword);
                    if (userPassword == null)
                    {
                        pass.Value = DBNull.Value;
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display user information
                            for (int i = 0; i < labels.Length; i++)
                            {
                                labels[i].Text = $"{reader[i]}";
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
        }
    }
}
