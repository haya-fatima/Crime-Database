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

namespace Forms_CrimeDatabase
{
    public partial class Form15 : Form
    {
        const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();

        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            var accusedid = Convert.ToDouble(textBox3.Text);
            var firid = Convert.ToInt32(textBox8.Text);
            var name = textBox1.Text;
            var height = Convert.ToInt32(textBox4.Text);
            var eyecol = textBox5.Text;
            var skincol = textBox6.Text;
            //(Accused_ID, FIR_ID, [Name], Height, Eye_Color, Skin_Color)
            string sql = "insert into Accused values (@Accused_ID, @FIR_ID, @nam, @gender, @Height, @Eye_Color, @Skin_Color)";
            con.Open();
            cm = new SqlCommand(sql, con);
            // Specify the value for the parameters.

            cm.Parameters.AddWithValue("@Accused_ID", accusedid);
            cm.Parameters.AddWithValue("@FIR_ID", firid);
            cm.Parameters.AddWithValue("@nam", name);
            cm.Parameters.AddWithValue("@gender", 1);
            cm.Parameters.AddWithValue("@Height", height);
            cm.Parameters.AddWithValue("@Eye_color", eyecol);
            cm.Parameters.AddWithValue("@Skin_color", skincol);
            cm.ExecuteNonQuery();
            con.Close();
            string message = "The item was added succesfully";
            MessageBox.Show(message);

        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
