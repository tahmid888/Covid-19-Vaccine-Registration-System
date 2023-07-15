/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;*/
using System;
using System.Data;
using System.Data.SqlClient; //add
using System.Windows.Forms;

namespace Covid19_Vaccine_Registration_System.Form_Design
{
    public partial class Form6 :Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Doctor12db;Integrated Security=True");

        private void Form6_Load(object sender, EventArgs e)
        {
            GetDoctorsRecord();
        }
        private void GetDoctorsRecord()
        {
          //  SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Doctordb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Doctor12tb", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            //  DoctorRecordDataGridView.DataSource = dt;     //error ashtese
            // dataGridView1.DataSource = dt;
            DoctorRecordDataGridView.DataSource = dt;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Doctor12tb VALUES (@doctor_id, @name, @age, @nid, @address, @dob, @mobile,@email)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@doctor_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@age", textBox3.Text);
                cmd.Parameters.AddWithValue("@nid", textBox4.Text);
                cmd.Parameters.AddWithValue("@address", textBox5.Text);
                cmd.Parameters.AddWithValue("@dob", textBox6.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox8.Text);
                cmd.Parameters.AddWithValue("@email", textBox7.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Doctor is successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetDoctorsRecord();
                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox7.Clear();
            }
        }

        private bool IsValid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Doctor ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true; 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoctorRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

