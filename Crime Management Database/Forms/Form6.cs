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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "The case has been updated successfully";
            MessageBox.Show(message);
        }
    }
}
