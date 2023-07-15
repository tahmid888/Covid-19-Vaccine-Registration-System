using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Covid19_Vaccine_Registration_System.Form_Design
{
    public partial class Form13 :Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Vaccine_Information_for_admin
            Vaccine_Information_for_admin vaccine_information_for_admin = new Vaccine_Information_for_admin();
            vaccine_information_for_admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Area_Information
            Area_Information area_information = new Area_Information();
            area_information.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //  Hospital_Information
            Hospital_Information hospital_information = new Hospital_Information();
            hospital_information.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Staff_Information

            Staff_Information staff_information = new Staff_Information();
            staff_information.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //  Doctor_Information

            Doctor_Information doctor_information = new Doctor_Information();
            doctor_information.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 fs = new Form9();
            fs.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
           Nurse_Information nurse_information = new Nurse_Information();
           nurse_information.Show();
           this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             Management_Works  obj1 = new Management_Works();
             obj1.Show();
             this.Hide();
            
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void Form13_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
