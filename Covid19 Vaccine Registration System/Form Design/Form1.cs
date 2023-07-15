//using Covid19_Vaccine_Registration_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Covid19_Vaccine_Registration_System.Form_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          Form2 form = new Form2();
          form.Show();
          this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


      /*  Boolean labelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
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
      */
        private void label4_Click(object sender, EventArgs e)
        {

        }

        Boolean labelVisible = true;
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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
