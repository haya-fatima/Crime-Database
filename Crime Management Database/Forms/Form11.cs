using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Forms_CrimeDatabase.Form4;
using static System.Collections.Specialized.BitVector32;

namespace Forms_CrimeDatabase
{
    public partial class Form11 : Form
    {
        const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into Victim values (@vicid, @crimeid, @cnic, @nam,  @gender, @height, @eyecol, @skincol)";
            con.Open();
            cm = new SqlCommand(sql, con);
            // Specify the value for the parameters.

            cm.Parameters.AddWithValue("@vicid", Convert.ToInt32(textBox2.Text));
            cm.Parameters.AddWithValue("@crimeid", Convert.ToInt32(comboBox1.Text));
            cm.Parameters.AddWithValue("@cnic", Convert.ToDouble(textBox7.Text));
            cm.Parameters.AddWithValue("@nam", textBox3.Text);
            cm.Parameters.AddWithValue("@gender", 1);
            cm.Parameters.AddWithValue("@height", Convert.ToInt32(textBox4.Text));
            cm.Parameters.AddWithValue("@eyecol", textBox5.Text);
            cm.Parameters.AddWithValue("@skincol", textBox6.Text);
            cm.ExecuteNonQuery();
            con.Close();
            string message = "The person has been added successfully";
            MessageBox.Show(message);
        }
    }
}
