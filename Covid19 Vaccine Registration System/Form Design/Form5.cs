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
using System.Windows.Forms; //add


namespace Covid19_Vaccine_Registration_System.Form_Design
{
    public partial class Form5 :Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Stuff12db;Integrated Security=True");
        private void Form5_Load(object sender, EventArgs e)
        {
            GetStuffsRecord();
        }

        private void GetStuffsRecord()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Stuff12db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Stuff12tb", con);
            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt1.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt1;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Stuff12tb VALUES (@office_id, @name, @age, @nid, @address, @dob, @mobile,@email)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@office_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@age", textBox3.Text);
                cmd.Parameters.AddWithValue("@nid", textBox4.Text);
                cmd.Parameters.AddWithValue("@address", textBox5.Text);
                cmd.Parameters.AddWithValue("@dob", textBox6.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox7.Text);
                cmd.Parameters.AddWithValue("@email", textBox8.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Stuff is successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStuffsRecord();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            }
        }

        private bool IsValid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Stuff ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
