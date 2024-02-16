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
    public partial class Form4 : Form
    {
        const string constr = @"Data Source = DESKTOP-0FJ8K5U; Initial Catalog=CrimeDatabase; User ID = sa; Password = 8383097aA; Integrated Security=SSPI";

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();

        public class FIR
        {
            public int f_id;
            public DateTime f_date;
            public DateTime i_date;
            public string filed_by;
            public string i_desc;
            public string i_location;
            public string accused;
            public string cnic;

            public FIR(int id, DateTime _f_date, DateTime _i_date, string _filed_by, string
                _i_desc, string _i_location, string _accused, string _cnic)
            {



                f_id = id;
                f_date = _f_date;
                i_date = _i_date;
                filed_by = _filed_by;
                i_desc = _i_desc;
                i_location = _i_location;
                accused = _accused;
                cnic = _cnic;

            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            //Form15 form = new Form1();
            //this.Hide();
            //form.Show();
            //Form14 view = new Form14();
            //string select = textBox1.Text;
            //view.fid = textBox1.Text;

            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firid = Convert.ToInt32(textBox1.Text);
            var increp = textBox3.Text;
            var compbyid = Convert.ToDouble(textBox2.Text);
            var comrel = comboBox1.Text;
            var dtorep = dateTimePicker1.Value;
            var dtoinc = dateTimePicker2.Value;
            var locofinc = textBox4.Text;
            var station = Convert.ToInt32(textBox7.Text);
            var desc = textBox5.Text;
            //(Accused_ID, FIR_ID, [Name], Height, Eye_Color, Skin_Color)
            string sql = "insert into FIR values (@FIR_ID, @Incident_Reported, @ComplainedBy_ID, @Complainant_Relation,  @DateTime_of_Report, @DateTime_of_Incident, @Location_of_Incident, @Station_of_Complaint, @Description)";
            con.Open();
            cm = new SqlCommand(sql, con);
            // Specify the value for the parameters.

            cm.Parameters.AddWithValue("@FIR_ID", firid);
            cm.Parameters.AddWithValue("@Incident_Reported", increp);
            cm.Parameters.AddWithValue("@ComplainedBy_ID", compbyid);
            cm.Parameters.AddWithValue("@Complainant_Relation", comrel);
            cm.Parameters.AddWithValue("@DateTime_of_Report", dtorep);
            cm.Parameters.AddWithValue("@DateTime_of_Incident", dtoinc);
            cm.Parameters.AddWithValue("@Location_of_Incident", locofinc);
            cm.Parameters.AddWithValue("@Station_of_Complaint", station);
            cm.Parameters.AddWithValue("@Description", desc);
            cm.ExecuteNonQuery();
            con.Close();
            string message = "The FIR has been submitted successfully";
            MessageBox.Show(message);
        }
    }
}
