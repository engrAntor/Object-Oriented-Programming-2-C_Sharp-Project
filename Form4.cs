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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();

            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-5KVIB8LF\\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True");
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-5KVIB8LF\\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True"))
                {
                    con.Open();

                    string query = @"INSERT INTO [dbo].[Student]
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
