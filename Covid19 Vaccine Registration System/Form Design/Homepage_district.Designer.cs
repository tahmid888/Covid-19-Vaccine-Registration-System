
namespace Covid19_Vaccine_Registration_System.Form_Design
{
    partial class Homepage_district
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage_district));
            this.insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.number_Vaccine_available = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Vaccine_Id = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Add_Vaccine = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insert.Location = new System.Drawing.Point(734, 341);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(129, 50);
            this.insert.TabIndex = 85;
            this.insert.Text = "Insert Info";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(666, 211);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(348, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 33);
            this.textBox4.TabIndex = 83;
            // 
            // number_Vaccine_available
            // 
            this.number_Vaccine_available.AutoSize = true;
            this.number_Vaccine_available.BackColor = System.Drawing.Color.Black;
            this.number_Vaccine_available.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_Vaccine_available.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_Vaccine_available.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_Vaccine_available.Location = new System.Drawing.Point(26, 170);
            this.number_Vaccine_available.Name = "number_Vaccine_available";
            this.number_Vaccine_available.Size = new System.Drawing.Size(234, 26);
            this.number_Vaccine_available.TabIndex = 82;
            this.number_Vaccine_available.Text = "Enter Your District Name  \r\n";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(348, 233);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(194, 33);
            this.textBox5.TabIndex = 81;
            // 
            // Vaccine_Id
            // 
            this.Vaccine_Id.AutoSize = true;
            this.Vaccine_Id.BackColor = System.Drawing.Color.Black;
            this.Vaccine_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vaccine_Id.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Vaccine_Id.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Vaccine_Id.Location = new System.Drawing.Point(26, 237);
            this.Vaccine_Id.Name = "Vaccine_Id";
            this.Vaccine_Id.Size = new System.Drawing.Size(221, 26);
            this.Vaccine_Id.TabIndex = 80;
            this.Vaccine_Id.Text = "Enter Your Center Name";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(348, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(194, 33);
            this.textBox6.TabIndex = 79;
            // 
            // Add_Vaccine
            // 
            this.Add_Vaccine.AutoSize = true;
            this.Add_Vaccine.BackColor = System.Drawing.Color.Black;
            this.Add_Vaccine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Vaccine.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Vaccine.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_Vaccine.Location = new System.Drawing.Point(26, 108);
            this.Add_Vaccine.Name = "Add_Vaccine";
            this.Add_Vaccine.Size = new System.Drawing.Size(241, 26);
            this.Add_Vaccine.TabIndex = 78;
            this.Add_Vaccine.Text = "Enter Your Division Name  ";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(895, 341);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(129, 50);
            this.delete.TabIndex = 77;
            this.delete.Text = "Delete Info";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(561, 341);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(129, 50);
            this.update.TabIndex = 88;
            this.update.Text = "Update Info";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 89;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(348, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 33);
            this.textBox1.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 90;
            this.label1.Text = "Enter Your NID";
            // 
            // Homepage_district
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 609);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.number_Vaccine_available);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Vaccine_Id);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Add_Vaccine);
            this.Controls.Add(this.delete);
            this.Name = "Homepage_district";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage_district";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homepage_district_FormClosing);
            this.Load += new System.EventHandler(this.Homepage_district_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label number_Vaccine_available;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Vaccine_Id;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Add_Vaccine;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}