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
    public partial class Form18 : Form
    {
        const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form18()
        {
            InitializeComponent();
        }

        private void LoadAreas()
        {
            con.Open();
            string sql = "Select * from Station";
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

        private void Form18_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
            LoadAreas();
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridView1.Columns["dataGridViewDeleteButton"].Index)
            {
                var data = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show(data.Cells[0].Value.ToString());
                dataGridView1.Columns.Remove("dataGridViewDeleteButton");
                dataGridView1.DataSource = null;

                LoadAreas();
            }
        }
    }
}
