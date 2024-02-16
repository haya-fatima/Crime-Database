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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_CrimeDatabase
{
    public partial class Form12 : Form
    {
        const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into is_a_witness values (@CNIC, @Case_ID)";
            con.Open();
            cm = new SqlCommand(sql, con);
            // Specify the value for the parameters.

            cm.Parameters.AddWithValue("@CNIC", Convert.ToInt64(textBox2.Text));
            cm.Parameters.AddWithValue("@Case_ID", Convert.ToInt32(comboBox1.Text));
            
            cm.ExecuteNonQuery();
            con.Close();
            string message = "The person has been added successfully";
            MessageBox.Show(message);
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
