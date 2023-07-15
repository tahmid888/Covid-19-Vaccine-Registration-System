
namespace Covid19_Vaccine_Registration_System.Form_Design
{
    partial class Staff_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Information));
            this.button7 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.number_Staff = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Staffs_phone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_Staff = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Location = new System.Drawing.Point(12, 479);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 32);
            this.button7.TabIndex = 40;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(436, 266);
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
            this.insert.Location = new System.Drawing.Point(594, 266);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(129, 50);
            this.insert.TabIndex = 61;
            this.insert.Text = "Insert Info";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 177);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(324, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 37);
            this.textBox3.TabIndex = 59;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // number_Staff
            // 
            this.number_Staff.AutoSize = true;
            this.number_Staff.BackColor = System.Drawing.Color.Black;
            this.number_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_Staff.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_Staff.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_Staff.Location = new System.Drawing.Point(12, 89);
            this.number_Staff.Name = "number_Staff";
            this.number_Staff.Size = new System.Drawing.Size(128, 29);
            this.number_Staff.TabIndex = 58;
            this.number_Staff.Text = " Staff Name";
            this.number_Staff.Click += new System.EventHandler(this.number_Staff_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(324, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 37);
            this.textBox2.TabIndex = 57;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Staffs_phone
            // 
            this.Staffs_phone.AutoSize = true;
            this.Staffs_phone.BackColor = System.Drawing.Color.Black;
            this.Staffs_phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staffs_phone.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staffs_phone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Staffs_phone.Location = new System.Drawing.Point(12, 156);
            this.Staffs_phone.Name = "Staffs_phone";
            this.Staffs_phone.Size = new System.Drawing.Size(220, 29);
            this.Staffs_phone.TabIndex = 56;
            this.Staffs_phone.Text = " Staff Phone Number";
            this.Staffs_phone.Click += new System.EventHandler(this.Staffs_phone_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(324, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 37);
            this.textBox1.TabIndex = 55;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Add_Staff
            // 
            this.Add_Staff.AutoSize = true;
            this.Add_Staff.BackColor = System.Drawing.Color.Black;
            this.Add_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Staff.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Staff.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_Staff.Location = new System.Drawing.Point(12, 27);
            this.Add_Staff.Name = "Add_Staff";
            this.Add_Staff.Size = new System.Drawing.Size(152, 29);
            this.Add_Staff.TabIndex = 54;
            this.Add_Staff.Text = " Staff Office ID";
            this.Add_Staff.Click += new System.EventHandler(this.Add_Staff_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(759, 266);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(129, 50);
            this.delete.TabIndex = 53;
            this.delete.Text = "Delete Info";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Staff_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 552);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.number_Staff);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Staffs_phone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add_Staff);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button7);
            this.Name = "Staff_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_Information_FormClosing);
            this.Load += new System.EventHandler(this.Staff_Information_Load);
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
        private System.Windows.Forms.Label number_Staff;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Staffs_phone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Add_Staff;
        private System.Windows.Forms.Button delete;
    }
}