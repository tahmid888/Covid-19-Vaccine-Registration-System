using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Covid19_Vaccine_Registration_System.Form_Design
{
    public partial class Nurses_Update_Information : Form
    {
        public Nurses_Update_Information()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nurses_Update_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
