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
    public partial class SignAd : Form
    {
        public SignAd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-5KVIB8LF\\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True");
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-5KVIB8LF\\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True"))
                {
                    con.Open();

                    string query = @"INSERT INTO [dbo].[Admin]
                        (
                            [FirstName],
                            [LastName],
                            [Password],
                            [DateOfBirth],
                            [Gender],
                             [Email],
                              [UserID]
                             
                        )
                        VALUES
                        (
                            @FirstName,
                            @LastName,
                            @Password,
                            @DateOfBirth,
                            @Gender,
                            @Email,
                            @UserID
                        )";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Use parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Password", textBox3.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);// Assuming the date is a string
                        cmd.Parameters.AddWithValue("@Gender", ComboBox.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                        cmd.Parameters.AddWithValue("@UserID", textBox6.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Create Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm8 = new Form8();
            frm8.Show();
        }
    }
}
