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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-5KVIB8LF\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True"; // Replace with your actual connection string

            // Assuming ItemName is the text of the selected item
            string itemName = checkedListBox1.SelectedItem.ToString();

            // Assuming IsChecked is based on whether the item is checked or not
            bool isChecked = checkedListBox1.GetItemChecked(checkedListBox1.SelectedIndex);

            // Insert into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO offeredCourses (Sname) VALUES (@Sname)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Sname", itemName);
                   // cmd.Parameters.AddWithValue("@Subject_serial", isChecked);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Checkbox item added successfully to the database.");
                    }
                    else
                    {
                        Console.WriteLine("Error adding checkbox item to the database.");
                    }

                    int index = checkedListBox1.SelectedIndex;
                    int count = checkedListBox1.Items.Count;

                    for (int x = 0; x < count; x++)
                    {
                        if (index != x)
                        {
                            checkedListBox1.SetItemCheckState(x, CheckState.Unchecked);
                        }
                    }
                }
            }
        }

       

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-5KVIB8LF\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True"; // Replace with your actual connection string

            // Assuming ItemName is the text of the selected item
            string itemName = checkedListBox3.SelectedItem.ToString();

            // Assuming IsChecked is based on whether the item is checked or not
            bool isChecked = checkedListBox3.GetItemChecked(checkedListBox3.SelectedIndex);

            // Insert into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO offeredCourses (Sname) VALUES (@Sname)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Sname", itemName);
                    //cmd.Parameters.AddWithValue("@sections", isChecked);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Checkbox item added successfully to the database.");
                    }
                    else
                    {
                        Console.WriteLine("Error adding checkbox item to the database.");
                    }

                    int index = checkedListBox3.SelectedIndex;
                    int count = checkedListBox3.Items.Count;

                    for (int x = 0; x < count; x++)
                    {
                        if (index != x)
                        {
                            checkedListBox3.SetItemCheckState(x, CheckState.Unchecked);
                        }
                    }
                }
            }
        }

        private void checkedListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-5KVIB8LF\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True"; // Replace with your actual connection string

            // Assuming ItemName is the text of the selected item
            string itemName = checkedListBox2.SelectedItem.ToString();

            // Assuming IsChecked is based on whether the item is checked or not
            bool isChecked = checkedListBox2.GetItemChecked(checkedListBox2.SelectedIndex);

            // Insert into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO offeredCourses (Sname) VALUES (@Sname)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Sname", itemName);
                   // cmd.Parameters.AddWithValue("@sections", isChecked);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Checkbox item added successfully to the database.");
                    }
                    else
                    {
                        Console.WriteLine("Error adding checkbox item to the database.");
                    }

                    int index = checkedListBox2.SelectedIndex;
                    int count = checkedListBox2.Items.Count;

                    for (int x = 0; x < count; x++)
                    {
                        if (index != x)
                        {
                            checkedListBox2.SetItemCheckState(x, CheckState.Unchecked);
                        }
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();


            Form9 form9 = new Form9();
            form9.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Registration is Confirmed");
        }
    }
}
