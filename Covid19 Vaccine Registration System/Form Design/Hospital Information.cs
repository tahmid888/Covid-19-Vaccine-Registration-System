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
    public partial class Hospital_Information : Form
    {
        public Hospital_Information()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Hospitalinfo13db;Integrated Security=True");
        public int serial;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Hospital_sort_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Hospital_removehospital_button_Click(object sender, EventArgs e)
        {

            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Hospitalinfo13tb WHERE serial=@ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Information is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetHospitalInfoRecords();
                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please Select to Delete Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hospital_removeall_button_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hospital_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Hospital_Information_Load(object sender, EventArgs e)
        {
            GetHospitalInfoRecords();
        }

        private void GetHospitalInfoRecords()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Hospitalinfo12db;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from Hospitalinfo13tb", con);
            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt1.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt1;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Hospitalinfo13tb VALUES (@hospital_registration_number, @hospital_name,@hospital_phone_number)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@hospital_registration_number", textBox1.Text);
                cmd.Parameters.AddWithValue("@hospital_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@hospital_phone_number", textBox2.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetHospitalInfoRecords();

                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();

            }
        }
        private bool IsValid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show(" Hospital Registration Number is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE Hospitalinfo13tb SET hospital_registration_number=@hospital_registration_number, hospital_name=@hospital_name,hospital_phone_number=@hospital_phone_number WHERE serial=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@hospital_registration_number", textBox1.Text);
                cmd.Parameters.AddWithValue("@hospital_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@hospital_phone_number", textBox2.Text);

                 cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetHospitalInfoRecords();
                serial = 0;
                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();


            }
            else
            {
                MessageBox.Show("Please Select to update information", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serial = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
