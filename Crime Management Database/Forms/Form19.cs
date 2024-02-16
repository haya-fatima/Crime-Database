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
    public partial class Form19 : Form
    {
        const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";
        
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();

        public Form19()
        {
            InitializeComponent();
        }

        private void LoadOfficers()
        {
            con.Open();
            string sql = "Select * from Police";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable d = new DataTable();
            da.Fill(d);
            cm.Dispose();
            con.Close();
            dataGridView1.DataSource = d;
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            LoadOfficers();
            dataGridView1.Columns.Add(deleteButton);
        }

        private void deletepol(string police_id)
        {
            con.Open();
            // TODO: Complete the function DeleteOrder 
            // SQL query to Delete the from the order and order details table
            string sql = "delete from [Police] where police_id=@police_id ; ";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            cm.Parameters.AddWithValue("@police_id", police_id);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
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


                deletepol(data.Cells[0].Value.ToString());



                dataGridView1.Columns.Remove("dataGridViewDeleteButton");
                dataGridView1.DataSource = null;

                LoadOfficers();

                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(deleteButton);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            this.Hide();
            form.Show();
        }
    }
}
