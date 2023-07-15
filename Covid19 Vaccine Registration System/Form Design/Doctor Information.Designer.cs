
namespace Covid19_Vaccine_Registration_System.Form_Design
{
    partial class Doctor_Information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Information));
            this.button7 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.number_Doctors = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nurses_Doctors = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_Doctors = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Location = new System.Drawing.Point(26, 508);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 48);
            this.button7.TabIndex = 30;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(457, 278);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(129, 50);
            this.update.TabIndex = 62;
            this.update.Text = "Update Info";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insert.Location = new System.Drawing.Point(615, 278);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(129, 50);
            this.insert.TabIndex = 61;
            this.insert.Text = "Insert Info";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(615, 205);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(354, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 33);
            this.textBox3.TabIndex = 59;
            // 
            // number_Doctors
            // 
            this.number_Doctors.AutoSize = true;
            this.number_Doctors.BackColor = System.Drawing.Color.Black;
            this.number_Doctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_Doctors.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_Doctors.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_Doctors.Location = new System.Drawing.Point(42, 113);
            this.number_Doctors.Name = "number_Doctors";
            this.number_Doctors.Size = new System.Drawing.Size(140, 26);
            this.number_Doctors.TabIndex = 58;
            this.number_Doctors.Text = "Doctor\'s Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(354, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 33);
            this.textBox2.TabIndex = 57;
            // 
            // nurses_Doctors
            // 
            this.nurses_Doctors.AutoSize = true;
            this.nurses_Doctors.BackColor = System.Drawing.Color.Black;
            this.nurses_Doctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nurses_Doctors.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nurses_Doctors.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.nurses_Doctors.Location = new System.Drawing.Point(42, 180);
            this.nurses_Doctors.Name = "nurses_Doctors";
            this.nurses_Doctors.Size = new System.Drawing.Size(232, 26);
            this.nurses_Doctors.TabIndex = 56;
            this.nurses_Doctors.Text = " Doctors\'s Phone Number";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(354, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 33);
            this.textBox1.TabIndex = 55;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Add_Doctors
            // 
            this.Add_Doctors.AutoSize = true;
            this.Add_Doctors.BackColor = System.Drawing.Color.Black;
            this.Add_Doctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Doctors.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Doctors.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_Doctors.Location = new System.Drawing.Point(42, 51);
            this.Add_Doctors.Name = "Add_Doctors";
            this.Add_Doctors.Size = new System.Drawing.Size(120, 26);
            this.Add_Doctors.TabIndex = 54;
            this.Add_Doctors.Text = " Doctors\'s ID";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(780, 278);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(129, 50);
            this.delete.TabIndex = 53;
            this.delete.Text = "Delete Info";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Doctor_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 614);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.number_Doctors);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nurses_Doctors);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add_Doctors);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button7);
            this.Name = "Doctor_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor_Information";
            this.Load += new System.EventHandler(this.Doctor_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label number_Doctors;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nurses_Doctors;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Add_Doctors;
        private System.Windows.Forms.Button delete;
    }
}