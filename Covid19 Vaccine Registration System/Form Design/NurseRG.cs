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
    public partial class NurseRG : Form
    {
        public NurseRG()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Nursedb;Integrated Security=True");
        private void NurseRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void NurseRG_Load(object sender, EventArgs e)
        {
            GetNursesRecord();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Nurse12db;Integrated Security=True");
        private void GetNursesRecord()
        {
            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Nursedb;Integrated Security=True ");
           // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Nurse12db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Nurse12tb", con);
            DataTable dt1 = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt1.Load(sdr);
            con.Close();

            NurseRecordDataGridView.DataSource = dt1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Nurse12tb VALUES (@nurse_id, @name, @age, @nid, @address, @dob, @mobile,@email)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nurse_id", txtBox1.Text);
                cmd.Parameters.AddWithValue("@name", txtBox2.Text);
                cmd.Parameters.AddWithValue("@age", txtBox3.Text);
                cmd.Parameters.AddWithValue("@nid", txtBox4.Text);
                cmd.Parameters.AddWithValue("@address", txtBox5.Text);
                cmd.Parameters.AddWithValue("@dob", txtBox6.Text);
                cmd.Parameters.AddWithValue("@mobile", txtBox8.Text);
                cmd.Parameters.AddWithValue("@email", txtBox7.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Nurse is successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetNursesRecord();

                txtBox1.Clear();
                txtBox2.Clear();
                txtBox3.Clear();
                txtBox4.Clear();
                txtBox5.Clear();
                txtBox6.Clear();
                txtBox7.Clear();
                txtBox8.Clear();
            }
        }

        private bool IsValid()
        {
            if (txtBox1.Text == string.Empty)
            {
                MessageBox.Show("Nurse ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}



