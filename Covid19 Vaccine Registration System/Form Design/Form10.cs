using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Covid19_Vaccine_Registration_System.Form_Design
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        Boolean labelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Form12 form12 = new Form12();
                form12.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Homepage_district homepage_district = new Homepage_district();
                homepage_district.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Cirtificate id download in the file section");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form10_Load_1(object sender, EventArgs e)
        {

        }

         /*Boolean labelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                if (labelVisible == true)
                {
                    hmsLabel.Visible = true;
                    labelVisible = false;

                }
                else
                {
                    hmsLabel.Visible = false;
                    labelVisible = true;

                }
            }
        } */


    }





}