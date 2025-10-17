using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntorFinalProjectC_
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             Form3 frm3 = new Form3();
            frm3.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendcode sc = new sendcode();
            this.Hide();
            sc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
             frm1.Show();
        }
    }
}
