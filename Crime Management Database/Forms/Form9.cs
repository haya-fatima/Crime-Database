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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form21 form = new Form21();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form19 form = new Form19();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form20 form = new Form20();
            this.Hide();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form17 form = new Form17();
            this.Hide();
            form.Show();
        }
    }
}
