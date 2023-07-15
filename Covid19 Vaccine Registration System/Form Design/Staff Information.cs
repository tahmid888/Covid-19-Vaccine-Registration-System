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
    public partial class Staff_Information : Form
    {
        public Staff_Information()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Staffinfo12db;Integrated Security=True");
        public int serial;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff1_s_Update_Information obj2 = new Staff1_s_Update_Information();
            obj2.Show();
            this.Hide();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Staffinfo12tb VALUES (@office_id, @staff_name,@staff_phone_number)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@office_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@staff_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@staff_phone_number", textBox2.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStaffsInfoRecords();

                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();

            }
        }
        private bool IsValid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show(" Nurse ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE Staffinfo12tb SET  office_id=@office_id,staff_name=@staff_name,staff_phone_number=@staff_phone_number WHERE serial=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@office_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@staff_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@staff_phone_number", textBox2.Text);
                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStaffsInfoRecords();
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

        private void number_Staff_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staffs_phone_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Staff_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Staffinfo12tb WHERE serial=@ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Information is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStaffsInfoRecords();
                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please Select to Delete Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Staff_Information_Load(object sender, EventArgs e)
        {
            GetStaffsInfoRecords();
        }

        private void GetStaffsInfoRecords()
        {
            

            SqlCommand cmd = new SqlCommand("Select * from Staffinfo12tb", con);
            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt1.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt1;
        }

        private void Staff_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
