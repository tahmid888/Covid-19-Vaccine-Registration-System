
namespace Covid19_Vaccine_Registration_System.Form_Design
{
    partial class Area_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_Information));
            this.button7 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.number_area = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.number_district = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Add_dristrict = new System.Windows.Forms.Label();
            this.Hospital_removehospital_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(12, 487);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 50);
            this.button7.TabIndex = 28;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(418, 270);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(129, 50);
            this.update.TabIndex = 62;
            this.update.Text = "Update Info";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insert.Location = new System.Drawing.Point(600, 270);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(129, 50);
            this.insert.TabIndex = 61;
            this.insert.Text = "Insert ";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 203);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(324, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 33);
            this.textBox3.TabIndex = 59;
            // 
            // number_area
            // 
            this.number_area.AutoSize = true;
            this.number_area.BackColor = System.Drawing.Color.Black;
            this.number_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_area.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_area.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_area.Location = new System.Drawing.Point(12, 92);
            this.number_area.Name = "number_area";
            this.number_area.Size = new System.Drawing.Size(110, 26);
            this.number_area.TabIndex = 58;
            this.number_area.Text = "Area Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(324, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 33);
            this.textBox2.TabIndex = 57;
            // 
            // number_district
            // 
            this.number_district.AutoSize = true;
            this.number_district.BackColor = System.Drawing.Color.Black;
            this.number_district.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_district.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_district.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_district.Location = new System.Drawing.Point(12, 159);
            this.number_district.Name = "number_district";
            this.number_district.Size = new System.Drawing.Size(258, 26);
            this.number_district.TabIndex = 56;
            this.number_district.Text = "Add Total Number of District";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(324, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 33);
            this.textBox4.TabIndex = 55;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Add_dristrict
            // 
            this.Add_dristrict.AutoSize = true;
            this.Add_dristrict.BackColor = System.Drawing.Color.Black;
            this.Add_dristrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_dristrict.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_dristrict.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_dristrict.Location = new System.Drawing.Point(12, 30);
            this.Add_dristrict.Name = "Add_dristrict";
            this.Add_dristrict.Size = new System.Drawing.Size(107, 26);
            this.Add_dristrict.TabIndex = 54;
            this.Add_dristrict.Text = " Area Code";
            // 
            // Hospital_removehospital_button
            // 
            this.Hospital_removehospital_button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hospital_removehospital_button.Location = new System.Drawing.Point(770, 270);
            this.Hospital_removehospital_button.Name = "Hospital_removehospital_button";
            this.Hospital_removehospital_button.Size = new System.Drawing.Size(129, 50);
            this.Hospital_removehospital_button.TabIndex = 53;
            this.Hospital_removehospital_button.Text = "Delete ";
            this.Hospital_removehospital_button.UseVisualStyleBackColor = true;
            this.Hospital_removehospital_button.Click += new System.EventHandler(this.Hospital_removehospital_button_Click);
            // 
            // Area_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 584);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.number_area);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.number_district);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Add_dristrict);
            this.Controls.Add(this.Hospital_removehospital_button);
            this.Controls.Add(this.button7);
            this.Name = "Area_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area_Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Area_Information_FormClosing);
            this.Load += new System.EventHandler(this.Area_Information_Load);
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
        private System.Windows.Forms.Label number_area;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label number_district;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Add_dristrict;
        private System.Windows.Forms.Button Hospital_removehospital_button;
    }
}