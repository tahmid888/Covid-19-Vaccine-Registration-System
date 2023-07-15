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
    public partial class Management_Works : Form
    {
        public Management_Works()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Managementformsdb;Integrated Security=True");
        public int serial;
        private void button1_Click(object sender, EventArgs e)
        {
            Form13 obj = new Form13();
            obj.Show();
            this.Hide();
        }

        private void Management_Works_Load(object sender, EventArgs e)
        {
            GetManagementWorksRecords();
        }

        private void GetManagementWorksRecords()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Managementformsdb;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from Managementformstb", con);
            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt1.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt1;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Managementformstb VALUES (@Total_Number_Of_Doctor_In_Duty, @Total_Number_Of_Nurse_In_Duty ,@Total_Number_Of_Stuff_In_Dut,@Total_Number_Of_Hospital)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Total_Number_Of_Doctor_In_Duty", textBox1.Text);
                cmd.Parameters.AddWithValue("@Total_Number_Of_Nurse_In_Duty", textBox2.Text);
                cmd.Parameters.AddWithValue("@Total_Number_Of_Stuff_In_Dut", textBox3.Text); 
                     cmd.Parameters.AddWithValue("@Total_Number_Of_Hospital", textBox4.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetManagementWorksRecords();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
        }
        private bool IsValid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("  Number of Doctor is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("UPDATE Managementformstb SET  Total_Number_Of_Doctor_In_Duty=@Total_Number_Of_Doctor_In_Duty,   Total_Number_Of_Nurse_In_Duty=@Total_Number_Of_Nurse_In_Duty, Total_Number_Of_Stuff_In_Dut=@Total_Number_Of_Stuff_In_Dut, Total_Number_Of_Hospital=@Total_Number_Of_Hospital  WHERE serial=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Total_Number_Of_Doctor_In_Duty", textBox1.Text);
                cmd.Parameters.AddWithValue("@Total_Number_Of_Nurse_In_Duty", textBox2.Text);
                cmd.Parameters.AddWithValue("@Total_Number_Of_Stuff_In_Dut", textBox3.Text);
                cmd.Parameters.AddWithValue("@Total_Number_Of_Hospital", textBox4.Text);

                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully updated in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetManagementWorksRecords();
                serial = 0;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();



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
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (serial > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Managementformstb WHERE serial=@ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Selected Information is deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetManagementWorksRecords();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Please Select to Delete Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
// tahmid pic gula koi

