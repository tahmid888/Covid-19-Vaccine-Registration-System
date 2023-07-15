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
    public partial class Homepage_district : Form
    {
        public Homepage_district()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=District13db;Integrated Security=True");
        public int serial;
        private void Homepage_district_Load(object sender, EventArgs e)
        {
            GetDistrictsRecord();
        }

        private void GetDistrictsRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * from District13tb", con);
            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt1.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 fs = new Form10();
            this.Hide();
            fs.Show();

        }

        private void Homepage_district_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO District13tb VALUES (@NID, @division,@district,@center)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NID", textBox1.Text);
                cmd.Parameters.AddWithValue("@division", textBox6.Text);
                cmd.Parameters.AddWithValue("@district", textBox4.Text);
                cmd.Parameters.AddWithValue("@center", textBox5.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetDistrictsRecord();

                textBox1.Clear();
                textBox6.Clear();
                textBox4.Clear();
                textBox5.Clear();

            }
        }

        private bool IsValid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show(" NID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            serial = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
           if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE District13tb SET NID=@NID, division=@division,district=@district,center=@center WHERE serial=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NID", textBox1.Text);
                cmd.Parameters.AddWithValue("@division", textBox6.Text);
                cmd.Parameters.AddWithValue("@district", textBox4.Text);
                cmd.Parameters.AddWithValue("@center", textBox5.Text);
                cmd.Parameters.AddWithValue("@ID", this.serial);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetDistrictsRecord();

                textBox1.Clear();
                textBox6.Clear();
                textBox4.Clear();
                textBox5.Clear();

            }
            else
            {
                MessageBox.Show("Please Select to update information", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    




   

