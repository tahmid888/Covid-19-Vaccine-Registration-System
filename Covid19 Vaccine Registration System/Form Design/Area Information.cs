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
    public partial class Area_Information : Form
    {
        public Area_Information()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Areainfo12db;Integrated Security=True");
        public int serial;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Area_Information_Load(object sender, EventArgs e)
        {
            GetAreaInfoRecords();
        }

        private void GetAreaInfoRecords()
        {
            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Areainfodb;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from Areainfo12tb", con);
            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt1.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt1;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Area_sort_button_Click(object sender, EventArgs e)
        {

        }

        private void Area_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Areainfo12tb VALUES (@area_code, @area_name,@total_number_of_district)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@area_code", textBox4.Text);
                cmd.Parameters.AddWithValue("@area_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@total_number_of_district", textBox2.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAreaInfoRecords();

                textBox4.Clear();
                textBox3.Clear();
                textBox2.Clear();

            }
        }
        private bool IsValid()
        {
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show(" Area code is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serial = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE Areainfo12tb SET area_code=@area_code, area_name=@area_name,total_number_of_district=@total_number_of_district WHERE serial=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@area_code", textBox4.Text);
                cmd.Parameters.AddWithValue("@area_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@total_number_of_district", textBox2.Text);
                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAreaInfoRecords();
                serial = 0;
                textBox4.Clear();
                textBox3.Clear();
                textBox2.Clear();


            }
            else
            {
                MessageBox.Show("Please Select to update information", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hospital_removehospital_button_Click(object sender, EventArgs e)
        {
            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Areainfo12tb WHERE serial=@ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Information is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAreaInfoRecords();
                textBox4.Clear();
                textBox3.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please Select to Delete Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


