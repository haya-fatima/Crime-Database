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
    public partial class Form20 : Form
    {
        const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form20()
        {
            InitializeComponent();
        }
        private void LoadVictims()
        {
            con.Open();
            string sql = "Select * from Victim";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable d = new DataTable();
            da.Fill(d);
            cm.Dispose();
            con.Close();
            dataGridView1.DataSource = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            this.Hide();
            form.Show();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;

            LoadVictims();
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
