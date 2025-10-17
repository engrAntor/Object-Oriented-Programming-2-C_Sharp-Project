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
    public partial class resetpassword : Form
    {
        public resetpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            string Email = sendcode.to;
            if (textBox1.Text == password) {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5KVIB8LF\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True");
                //string q = "update[Student] set [Password] = '"+ password + "'where [Email] = '"+Email + "'"];

                string q = "UPDATE [Student] SET [Password] = '" + password + "' WHERE [Email] = '" + Email + "'";

                SqlCommand cmd = new SqlCommand(q, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Password Successfully Changed");
            }
            
            
            else 
            {
                MessageBox.Show("New Password and Confirm Password not Match");
            }
            


        }
    }
}

