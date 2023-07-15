using System;
using System.Data;
using System.Data.SqlClient; //add
using System.Windows.Forms; //add

namespace Covid19_Vaccine_Registration_System.Form_Design
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-57VB5O1\SQLEXPRESS;Initial Catalog=Candidatedb;Integrated Security=True");

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            GetCandidatesRecord();
        }

        private void GetCandidatesRecord()
        {
           // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HJMUR66;Initial Catalog=Candidatedb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Candidate1tb", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            CandidateRecordDataGridView.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Candidate1tb VALUES (@NID, @username, @age,@dob,@mobile, @address, @email)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NID", txtUserName.Text);// shob change korte hobe!
                cmd.Parameters.AddWithValue("@username", txtUserAge.Text);
                cmd.Parameters.AddWithValue("@age", txtMobileNumber.Text);
                cmd.Parameters.AddWithValue("@dob", txtAddress.Text);
                cmd.Parameters.AddWithValue("@mobile", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", textBox1.Text);
                cmd.Parameters.AddWithValue("@email", txtPassword.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
              
                MessageBox.Show("New Candidate is successfully added in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCandidatesRecord();
                txtUserName.Clear();
                txtUserAge.Clear();
                txtMobileNumber.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                textBox1.Clear();
                txtPassword.Clear();
            }
        }

        private bool IsValid()
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Candidate NID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        
        private void CandidateRecordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
