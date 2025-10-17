using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AntorFinalProjectC_
{
    public partial class Form6 : Form
    {
        private bool isPasswordEntered = false;

        public Form6()
        {
            InitializeComponent();

            // Attach the MouseClick and TextChanged event handlers for textboxes
            textBox1.MouseClick += TextBox1_MouseClick;
            textBox1.TextChanged += TextBox1_TextChanged;

            textBox2.MouseClick += TextBox2_MouseClick;
            textBox2.TextChanged += TextBox2_TextChanged;
        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Clear the text when textBox1 is clicked
            textBox1.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Set text color to black when the user writes text in textBox1
            if (textBox1.Text.Length > 0)
            {
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            // Clear the text and set the system password character when textBox2 is clicked
            isPasswordEntered = true;
            SetBackgroundText();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Handle the TextChanged event to update the background text and change text color for textBox2
            if (textBox2.Text.Length == 0)
            {
                isPasswordEntered = false;
                SetBackgroundText();
            }
            else
            {
                // Set text color to black when the user writes text in textBox2
                textBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SetBackgroundText()
        {
            // Set the background text for textBox2 based on whether the user has entered a password
            if (isPasswordEntered)
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.Text = "Password";
                textBox2.UseSystemPasswordChar = false;
                // Set the text color to a specific color when the background text is displayed
                textBox2.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from Student where Email = '" + this.textBox1.Text + "' and Password = '" + this.textBox2.Text + "';";
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
                    string userEmail = textBox1.Text;
                    string userPassword = textBox2.Text;
                    Form9 form9 = new Form9(userEmail, userPassword);
                    form9.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }

            sqlcon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Load event code (if any)
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
