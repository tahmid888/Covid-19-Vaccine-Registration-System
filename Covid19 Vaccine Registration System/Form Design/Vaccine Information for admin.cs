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
    public partial class Vaccine_Information_for_admin : Form
    {
        public Vaccine_Information_for_admin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Vaccineinfo12db;Integrated Security=True");
        public int serial;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vaccine_Information_for_admin_Load(object sender, EventArgs e)
        {
            GetVaccineInfoRecords();
        }

        private void GetVaccineInfoRecords()
        {

            SqlCommand cmd = new SqlCommand("Select * from Vaccineinfo12tb", con);
            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt1.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Vaccine_Information_for_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serial = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Vaccineinfo12tb VALUES (@vaccine_name, @total_stocks_of_vaccine,@new_vaccine_id,@total_type_of_vaccine_in_stock)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@vaccine_name", textBox6.Text);
                cmd.Parameters.AddWithValue("@total_stocks_of_vaccine", textBox4.Text);
                cmd.Parameters.AddWithValue("@new_vaccine_id", textBox5.Text);
                cmd.Parameters.AddWithValue("@total_type_of_vaccine_in_stock", textBox7.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetVaccineInfoRecords();

                textBox6.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox7.Clear();

            }
        }
        private bool IsValid()
        {
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show(" Vaccine name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Vaccineinfo12tb WHERE serial=@ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Information is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetVaccineInfoRecords();
                textBox6.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox7.Clear();
            }
            else
            {
                MessageBox.Show("Please Select to Delete Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE Vaccineinfo12tb SET   vaccine_name=@vaccine_name, total_stocks_of_vaccine=@total_stocks_of_vaccine,new_vaccine_id=@new_vaccine_id,total_type_of_vaccine_in_stock=@total_type_of_vaccine_in_stock  WHERE serial=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@vaccine_name", textBox6.Text);
                cmd.Parameters.AddWithValue("@total_stocks_of_vaccine", textBox4.Text);
                cmd.Parameters.AddWithValue("@new_vaccine_id", textBox5.Text);
                cmd.Parameters.AddWithValue("@total_type_of_vaccine_in_stock", textBox7.Text);



                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetVaccineInfoRecords();
                serial = 0;
                textBox6.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox7.Clear();


            }
            else
            {
                MessageBox.Show("Please Select to update information", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
