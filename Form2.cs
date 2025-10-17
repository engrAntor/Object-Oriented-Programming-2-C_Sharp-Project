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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AntorFinalProjectC_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    PASS.UseSystemPasswordChar = false;
                    break;
                default:
                    PASS.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void USER_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (USER.Text != "" && PASS.Text != "")
             {
                 SqlConnection con = new SqlConnection("Data Source=LAPTOP-5KVIB8LF\\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True");
                 string query = "select * from Student_Details where Email ID = @email_id and PASSWORD = @password";
                 SqlCommand cmd = new SqlCommand(query, con);
                 cmd.Parameters.AddWithValue("@email_id", USER.Text);
                 cmd.Parameters.AddWithValue("@password", PASS.Text);
                 con.Open();
                 SqlDataReader dr = cmd.ExecuteReader();
                 if (dr.HasRows == true)
                 {
                      MessageBox.Show("Login Successful", "Success",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                     Form1 frm = new Form1();
                     frm.Hide();

                     Form2 form2 = new Form2();
                     form2.Show();
                 }
                 else
                 {
                     MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                 }
                 con.Close();
             }
             else
             {
                 MessageBox.Show("Enter Fields", "Failed", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
             }*/
            string sql = "select * from Student where Email = '" + this.USER.Text + "' and Password = '" + this.PASS.Text + "';";
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-5KVIB8LF\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcom);
            SqlDataAdapter sda = sqlDataAdapter;
            DataSet User = new DataSet();
            sda.Fill(User);
            if (USER.Text == "")
            {
                MessageBox.Show("Enter The User Id");
            }
            else if (PASS.Text == "")
            {
                MessageBox.Show("Enter The Password");
            }
            else
            {
                if (User.Tables[0].Rows.Count == 1)
                {
                    //MessageBox.Show("Valid User");


                    this.Hide();

                   Form9 form9 = new Form9();
                    form9.Show();
                    
                  
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
            sqlcon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm1 = new Form1();
            frm1.Show();    
        
        }
    }


    }

