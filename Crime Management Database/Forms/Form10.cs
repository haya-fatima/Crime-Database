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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_CrimeDatabase
{
    public partial class Form10 : Form
    {
        //const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

        //SqlConnection con = new SqlConnection(constr);
        //SqlCommand cm = new SqlCommand();
        
        public Form10()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            

            if((textBox1.Text != String.Empty) && (textBox3.Text != String.Empty))
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '\u25CF';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "The policeman has been assigned to the case successfully";
            MessageBox.Show(message);
            //var caseid = comboBox1.Text;
            //var officerid = Convert.ToDouble(textBox2.Text);
            //var startdate = dateTimePicker1.Value;

            //string sql = "insert into assigned_to (@Case_ID, @Police_ID, @[Start_Date])";
            //con.Open();
            //cm = new SqlCommand(sql, con);
            //// Specify the value for the parameters.

            //cm.Parameters.AddWithValue("@Case_ID", caseid);
            //cm.Parameters.AddWithValue("@Police_ID", officerid);
            //cm.Parameters.AddWithValue("@Start_Date", startdate);
            //cm.ExecuteNonQuery();
            //con.Close();

            //string message = "The policeman has been assigned to the case successfully";
            //MessageBox.Show(message);
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Case_ID FROM [Case]", con))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    //Insert the Default Item to DataTable.
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    dt.Rows.InsertAt(row, 0);

                    //Assign DataTable as DataSource.
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "Case_ID";
                    
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
