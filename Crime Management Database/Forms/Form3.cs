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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_CrimeDatabase
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Police_ID, CNIC, [Name], Designation, Date_of_App, Police_Email from Police"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        textBox2.Text = sdr["Police_ID"].ToString();
                        textBox1.Text = sdr["Name"].ToString();
                        textBox3.Text = sdr["CNIC"].ToString();
                        textBox4.Text = sdr["Designation"].ToString();
                        textBox5.Text = sdr["Police_Email"].ToString();
                    }
                    con.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
