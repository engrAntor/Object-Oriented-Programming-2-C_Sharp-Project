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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from Admin where Email = '" + this.textBox1.Text + "' and Password = '" + this.textBox2.Text + "';";
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-5KVIB8LF\SQLEXPRESS;Initial Catalog=Antor;Integrated Security=True");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcom);
            SqlDataAdapter sda = sqlDataAdapter;
            DataSet User = new DataSet();
            sda.Fill(User);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter The User Id");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter The Password");
            }
            else
            {
                if (User.Tables[0].Rows.Count == 1)
                {
                    //MessageBox.Show("Valid User");

                    this.Hide();
                    Form15 frm15 = new Form15();
                    frm15.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();


            SignAd ad = new SignAd();
            ad.Show();
        }
    }
}
