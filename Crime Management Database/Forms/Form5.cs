using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms_CrimeDatabase
{
    public partial class Form5 : Form
    {
        //const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

        //SqlConnection con = new SqlConnection(constr);
        //SqlCommand cm = new SqlCommand();


        //public class Case
        //{
        //    public int firid;
        //    public string victims;
        //    public string suspect;

        //    public int c_id;
        //    public DateTime o_date;
        //    public string type;


        //    public Case(int cid, DateTime _o_date, string _type, int _firid, string _victims, string _suspect)
        //    {


        //        c_id = cid;
        //        o_date = _o_date;
        //        type = _type;
        //        firid = _firid;
        //        victims = _victims;
        //        suspect = _suspect;
        //    }
        //}

        //List <Case> c = new List<Case> ();

        public Form5()
        {
            InitializeComponent();
            
        }

        //private void LoadFIRS()
        //{
        //    con.Open();
        //    string sql = "Select FIR_ID from FIR";
        //    cm = new SqlCommand(sql, con);
        //    SqlDataAdapter da1 = new SqlDataAdapter(cm);
        //    DataSet ds1 = new DataSet();
        //    da1.Fill(ds1);
        //    cm.ExecuteNonQuery();

        //    listBox4.DataSource = ds1.Tables[0];
        //    listBox4.DisplayMember = "ID";
        //    con.Close();
        //}

        private void LoadVictims()
        {
            const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cm = new SqlCommand();
            con.Open();
            string sql = "Select Victim_ID, [Name] from Victim";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da2 = new SqlDataAdapter(cm);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            cm.ExecuteNonQuery();

            listBox1.DataSource = ds2.Tables[0];
            listBox1.DisplayMember = "Name";
            
            con.Close();

        }

        private void LoadSuspects()
        {
            const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cm = new SqlCommand();
            con.Open();
            string sql = "Select Accused_ID from Accused";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da3 = new SqlDataAdapter(cm);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            cm.ExecuteNonQuery();

            listBox5.DataSource = ds3.Tables[0];
            listBox5.DisplayMember = "Accused_ID";
            con.Close();
            //string str = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";
            //SqlConnection con = new SqlConnection(str);
            //string query = "select Accused_ID from is_a_suspect";
            //SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataReader dbr;

            //try
            //{
            //    con.Open();
            //    dbr = cmd.ExecuteReader();
            //    while (dbr.Read())
            //    {
            //        int id = (int)dbr["Accused_ID"]; ;
            //        listBox4.Items.Add(id);
            //    }

            //}
            //catch (Exception es)
            //{
            //    MessageBox.Show(es.Message);

            //}
        }

        private void LoadWitness()
        {
            string str = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(str);
            string query = "select CNIC from is_a_witness a, [Case] c where a.Case_ID = c.Case_ID ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dbr;

            try
            {
                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    long cnic = Convert.ToInt64(dbr["CNIC"]);
                    listBox4.Items.Add(cnic);
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }

        }

    

        private void fillFIR()

        {

            string str = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(str);
            string query = "select FIR_ID from FIR";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dbr;

            try
            {
                con.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    int id = (int)dbr["FIR_ID"]; ;
                    listBox4.Items.Add(id);
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }

        }


        private void Form5_Load(object sender, EventArgs e)
        {
            fillFIR();
            LoadVictims();
            LoadSuspects();
            LoadWitness();
            //dataGridView1.BackgroundColor = Color.White;
            //dataGridView1.RowHeadersVisible = false;
            //LoadFIRS();



            //SqlConnection con = new SqlConnection("Data Source = DESKTOP - 0FJ8K5U; Initial Catalog = CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security = SSPI");
            //SqlCommand cmd = new SqlCommand("Select [Name] from Victims", con);
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //listBox1.DataSource = dt;
            //listBox1.DisplayMember = "Name";
            //listBox1.ValueMember = "id";




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ////textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
            //    return;

            ////Check if click is on specific column 
            //if (e.ColumnIndex == dataGridView1.Columns["dataGridViewDeleteButton"].Index)
            //{
            //    var data = dataGridView1.Rows[e.RowIndex];
            //    MessageBox.Show(data.Cells[0].Value.ToString());

            //    dataGridView1.Columns.Remove("dataGridViewDeleteButton");
            //    dataGridView1.DataSource = null;

            //    LoadFIRS();

           

            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var caseid = Convert.ToInt32(textBox1.Text);
            //var category = comboBox1.SelectedIndex;

            //var copen = dateTimePicker1.Value;


            ////(Accused_ID, FIR_ID, [Name], Height, Eye_Color, Skin_Color)
            //string sql = "Select c.FIR_ID from case_has_fir c ,FIR f where c.FIR_ID = f.FIR";
            //con.Open();
            //cm = new SqlCommand(sql, con);
            // Specify the value for the parameters.

            string message = "The case has been registered successfully.";
            MessageBox.Show(message);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
