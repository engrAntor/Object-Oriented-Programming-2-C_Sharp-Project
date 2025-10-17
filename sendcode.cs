using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AntorFinalProjectC_
{
    public partial class sendcode : Form
    {
        string randomcode;
        public static string to;
        public sendcode()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();

            string randomCode = rand.Next(999000).ToString();
            MailMessage message = new MailMessage();
            to=(textBox1.Text).ToString();
            from = "Your_Gmail";
            pass = "Your_App_Password";
            messageBody = $"Your Reset Code : {randomCode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reset";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Successfully Send");


            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            
            // Rest of your code...
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomcode == (textBox2.Text).ToString())
            {
                to = textBox1.Text;
                this.Hide();
                resetpassword rs = new resetpassword();
               
                rs.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
