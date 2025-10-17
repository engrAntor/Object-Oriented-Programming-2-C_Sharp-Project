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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AntorFinalProjectC_
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5KVIB8LF\\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True");
            string query = "select * from Student_Details where USERNAME=@user and PASSWORD = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                //  MessageBox.Show("Login Successful", "Success",
                // MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                Form1 frm = new Form1();
                frm.Hide();

                Form2 form2 = new Form2();
                form2.Show();
            }
    }
}
