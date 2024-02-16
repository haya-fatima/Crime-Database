using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_CrimeDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form6 form = new Form6();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            this.Hide();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form8 form = new Form8();
            this.Hide();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form5 form = new Form5();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form9 form = new Form9();
            this.Hide();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Form10 form = new Form10();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
