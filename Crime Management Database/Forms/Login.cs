using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_CrimeDatabase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                string message = "Please provide valid information!";
                MessageBox.Show(message);
            }
            else
            {
                Form2 form = new Form2();
                this.Hide();
                form.Show();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\u25CF';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
