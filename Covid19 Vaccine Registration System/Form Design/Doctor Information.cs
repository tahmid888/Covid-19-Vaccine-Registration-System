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
    public partial class Doctor_Information : Form
    {
        public Doctor_Information()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Doctorinfo12db;Integrated Security=True");
        public int serial;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           Update_Doctors_info obj= new Update_Doctors_info();
           obj.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.ShowDialog();
            this.Hide();
        }

        private void Doctor_Information_Load(object sender, EventArgs e)
        {
            GetDoctorInfoRecords();
        }

        private void GetDoctorInfoRecords()
        {
           // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Doctorinfo12db;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from Doctorinfo12tb", con);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Doctorinfo12tb VALUES (@doctor_id, @doctor_name,@doctor_phone_number)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@doctor_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@doctor_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@doctor_phone_number", textBox2.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetDoctorInfoRecords();

                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();

            }
        }
        private bool IsValid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show(" Doctor ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE Doctorinfo12tb SET doctor_id=@doctor_id, doctor_name=@doctor_name,doctor_phone_number=@doctor_phone_number WHERE serial=@ID", con);
                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@doctor_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@doctor_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@doctor_phone_number", textBox2.Text);
                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetDoctorInfoRecords();
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

        private void delete_Click(object sender, EventArgs e)
        {

            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Doctorinfo12tb WHERE serial=@ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Information is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDoctorInfoRecords();
                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please Select to Delete Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
