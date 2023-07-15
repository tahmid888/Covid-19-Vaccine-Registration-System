/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; */
using System;
using System.Data;
using System.Data.SqlClient; //add
using System.Windows.Forms; //add

namespace Covid19_Vaccine_Registration_System.Form_Design
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Vaccineinfoformsdb;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Your Information is added!"); //submit
            if (IsValid())
            {



                SqlCommand cmd = new SqlCommand("INSERT INTO Vaccineinfoformstb VALUES (@NID, @Vaccine_type, @Vaccine_name,@Dose_number)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Vaccine_type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Vaccine_name", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Dose_number", Convert.ToInt32(comboBox3.Text));


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Informatione is successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetVaccineInfoRecords();


                textBox1.Clear();


            }


            bool IsValid()
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("NID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;



            }
       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 form2 = new Form10();
            form2.Show();
            this.Hide();
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void GetVaccineInfoRecords()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Vaccineinfoformsdb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Vaccineinfoformstb", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            GetVaccineInfoRecords();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

       
    

