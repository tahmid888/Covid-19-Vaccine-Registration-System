using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Covid19_Vaccine_Registration_System.Form_Design
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        
            
           
           // Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        Form10 ds = new Form10();
       

        Form13 fs = new Form13();

        private void AccessProvider(string userName, string pass)
        {
            if (comboBox1.Text == "Candidate")
            {
                if (userName == "c" && pass == "c")
                {
                    //do what student can access 
                    //this.Hide();
                    ds.Show();
                    this.Hide();
                }
                else
                {
                    textBox2.Clear();
                    MessageBox.Show("Incorrect username or password", "Warning", MessageBoxButtons.OK);
                }
            }
            else if (comboBox1.Text == "Admin")
            {
                if (userName == "a" && pass == "a")
                {
                    //do what admin can access
                    // this.Hide();
                    fs.Show();
                    this.Hide();
                }
                else
                {
                    textBox2.Clear();
                    MessageBox.Show("Incorrect username or password", "Warning", MessageBoxButtons.OK);
                }
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccessProvider(textBox2.Text.Trim(), textBox3.Text.Trim());
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}



