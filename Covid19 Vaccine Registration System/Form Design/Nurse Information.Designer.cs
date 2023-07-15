
namespace Covid19_Vaccine_Registration_System.Form_Design
{
    partial class Nurse_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse_Information));
            this.button7 = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.number_nurse = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nurses_phone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add_Nurse = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Location = new System.Drawing.Point(12, 498);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 45);
            this.button7.TabIndex = 40;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insert.Location = new System.Drawing.Point(601, 267);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(129, 50);
            this.insert.TabIndex = 50;
            this.insert.Text = "Insert Info";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 209);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(327, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 33);
            this.textBox3.TabIndex = 48;
            // 
            // number_nurse
            // 
            this.number_nurse.AutoSize = true;
            this.number_nurse.BackColor = System.Drawing.Color.Black;
            this.number_nurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number_nurse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_nurse.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.number_nurse.Location = new System.Drawing.Point(15, 87);
            this.number_nurse.Name = "number_nurse";
            this.number_nurse.Size = new System.Drawing.Size(125, 26);
            this.number_nurse.TabIndex = 47;
            this.number_nurse.Text = " Nurse Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(327, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 33);
            this.textBox2.TabIndex = 46;
            // 
            // nurses_phone
            // 
            this.nurses_phone.AutoSize = true;
            this.nurses_phone.BackColor = System.Drawing.Color.Black;
            this.nurses_phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nurses_phone.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nurses_phone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.nurses_phone.Location = new System.Drawing.Point(15, 154);
            this.nurses_phone.Name = "nurses_phone";
            this.nurses_phone.Size = new System.Drawing.Size(199, 26);
            this.nurses_phone.TabIndex = 45;
            this.nurses_phone.Text = "Nurse Phone Number";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(327, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 33);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Add_Nurse
            // 
            this.Add_Nurse.AutoSize = true;
            this.Add_Nurse.BackColor = System.Drawing.Color.Black;
            this.Add_Nurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Nurse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Nurse.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_Nurse.Location = new System.Drawing.Point(15, 25);
            this.Add_Nurse.Name = "Add_Nurse";
            this.Add_Nurse.Size = new System.Drawing.Size(92, 26);
            this.Add_Nurse.TabIndex = 43;
            this.Add_Nurse.Text = " Nurse ID";
            this.Add_Nurse.Click += new System.EventHandler(this.Add_Nurse_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(766, 267);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(129, 50);
            this.delete.TabIndex = 41;
            this.delete.Text = "Delete Info";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(443, 267);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(129, 50);
            this.update.TabIndex = 51;
            this.update.Text = "Update Info";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Nurse_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 554);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.number_nurse);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nurses_phone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add_Nurse);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button7);
            this.Name = "Nurse_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse_Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nurse_Information_FormClosing);
            this.Load += new System.EventHandler(this.Nurse_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label number_nurse;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nurses_phone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Add_Nurse;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
    }
}