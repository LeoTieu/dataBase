
namespace MyPhoneBook
{
    partial class Form1
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
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.TMobile = new System.Windows.Forms.TextBox();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.TLname = new System.Windows.Forms.TextBox();
            this.TFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Location = new System.Drawing.Point(708, 27);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(132, 57);
            this.ButtonInsert.TabIndex = 16;
            this.ButtonInsert.Text = "Insert";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // TMobile
            // 
            this.TMobile.Location = new System.Drawing.Point(325, 180);
            this.TMobile.Name = "TMobile";
            this.TMobile.Size = new System.Drawing.Size(303, 26);
            this.TMobile.TabIndex = 4;
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(325, 128);
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(303, 26);
            this.TEmail.TabIndex = 3;
            // 
            // TLname
            // 
            this.TLname.Location = new System.Drawing.Point(325, 76);
            this.TLname.Name = "TLname";
            this.TLname.Size = new System.Drawing.Size(303, 26);
            this.TLname.TabIndex = 2;
            // 
            // TFname
            // 
            this.TFname.Location = new System.Drawing.Point(325, 24);
            this.TFname.Name = "TFname";
            this.TFname.Size = new System.Drawing.Size(303, 26);
            this.TFname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(211, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(211, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(211, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(211, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mobile";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(976, 324);
            this.dataGridView1.TabIndex = 16;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(708, 90);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(132, 57);
            this.ButtonDelete.TabIndex = 16;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(708, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 57);
            this.button3.TabIndex = 16;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1010, 543);
            this.label5.TabIndex = 18;
            this.label5.Text = "         ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 579);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TFname);
            this.Controls.Add(this.TLname);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.TMobile);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.TextBox TMobile;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.TextBox TLname;
        private System.Windows.Forms.TextBox TFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
    }
}

