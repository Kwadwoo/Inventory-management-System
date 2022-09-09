namespace ShopritePMS
{
    partial class AttendantForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttendDGV = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AttendPass = new CustomControls.RJControls.RJTextBox();
            this.AttendPhone = new CustomControls.RJControls.RJTextBox();
            this.AttendAge = new CustomControls.RJControls.RJTextBox();
            this.AttendName = new CustomControls.RJControls.RJTextBox();
            this.AttendId = new CustomControls.RJControls.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.AttendPass);
            this.panel1.Controls.Add(this.AttendDGV);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.AttendPhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AttendAge);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AttendName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AttendId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(151, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 708);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AttendDGV
            // 
            this.AttendDGV.AllowUserToResizeColumns = false;
            this.AttendDGV.AllowUserToResizeRows = false;
            this.AttendDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AttendDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttendDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttendDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AttendDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.AttendDGV.EnableHeadersVisualStyles = false;
            this.AttendDGV.GridColor = System.Drawing.Color.White;
            this.AttendDGV.Location = new System.Drawing.Point(428, 102);
            this.AttendDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttendDGV.Name = "AttendDGV";
            this.AttendDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AttendDGV.RowHeadersWidth = 53;
            this.AttendDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendDGV.Size = new System.Drawing.Size(727, 543);
            this.AttendDGV.TabIndex = 13;
            this.AttendDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(255, 490);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 34);
            this.button7.TabIndex = 12;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(132, 490);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 34);
            this.button6.TabIndex = 11;
            this.button6.Text = "EDIT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(11, 490);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "PHONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "AGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(421, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE ATTENDANTS";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1269, -2);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 30);
            this.button5.TabIndex = 16;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(5, 272);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 34);
            this.button3.TabIndex = 19;
            this.button3.Text = "Selling";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(5, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(5, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttendPass
            // 
            this.AttendPass.BackColor = System.Drawing.Color.White;
            this.AttendPass.BorderColor = System.Drawing.Color.Black;
            this.AttendPass.BorderFocusColor = System.Drawing.Color.Purple;
            this.AttendPass.BorderSize = 4;
            this.AttendPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.AttendPass.Location = new System.Drawing.Point(127, 395);
            this.AttendPass.Margin = new System.Windows.Forms.Padding(5);
            this.AttendPass.Multiline = false;
            this.AttendPass.Name = "AttendPass";
            this.AttendPass.Padding = new System.Windows.Forms.Padding(9);
            this.AttendPass.PasswordChar = true;
            this.AttendPass.Size = new System.Drawing.Size(244, 44);
            this.AttendPass.TabIndex = 14;
            this.AttendPass.Texts = "";
            this.AttendPass.UnderlinedStyle = true;
            // 
            // AttendPhone
            // 
            this.AttendPhone.BackColor = System.Drawing.Color.White;
            this.AttendPhone.BorderColor = System.Drawing.Color.Black;
            this.AttendPhone.BorderFocusColor = System.Drawing.Color.Purple;
            this.AttendPhone.BorderSize = 4;
            this.AttendPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendPhone.ForeColor = System.Drawing.Color.Gainsboro;
            this.AttendPhone.Location = new System.Drawing.Point(127, 322);
            this.AttendPhone.Margin = new System.Windows.Forms.Padding(5);
            this.AttendPhone.Multiline = false;
            this.AttendPhone.Name = "AttendPhone";
            this.AttendPhone.Padding = new System.Windows.Forms.Padding(9);
            this.AttendPhone.PasswordChar = false;
            this.AttendPhone.Size = new System.Drawing.Size(244, 44);
            this.AttendPhone.TabIndex = 8;
            this.AttendPhone.Texts = "";
            this.AttendPhone.UnderlinedStyle = true;
            // 
            // AttendAge
            // 
            this.AttendAge.BackColor = System.Drawing.Color.White;
            this.AttendAge.BorderColor = System.Drawing.Color.Black;
            this.AttendAge.BorderFocusColor = System.Drawing.Color.Purple;
            this.AttendAge.BorderSize = 4;
            this.AttendAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendAge.ForeColor = System.Drawing.Color.Black;
            this.AttendAge.Location = new System.Drawing.Point(127, 242);
            this.AttendAge.Margin = new System.Windows.Forms.Padding(5);
            this.AttendAge.Multiline = false;
            this.AttendAge.Name = "AttendAge";
            this.AttendAge.Padding = new System.Windows.Forms.Padding(9);
            this.AttendAge.PasswordChar = false;
            this.AttendAge.Size = new System.Drawing.Size(244, 44);
            this.AttendAge.TabIndex = 6;
            this.AttendAge.Texts = "";
            this.AttendAge.UnderlinedStyle = true;
            // 
            // AttendName
            // 
            this.AttendName.BackColor = System.Drawing.Color.White;
            this.AttendName.BorderColor = System.Drawing.Color.Black;
            this.AttendName.BorderFocusColor = System.Drawing.Color.Purple;
            this.AttendName.BorderSize = 4;
            this.AttendName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendName.ForeColor = System.Drawing.Color.Gainsboro;
            this.AttendName.Location = new System.Drawing.Point(127, 167);
            this.AttendName.Margin = new System.Windows.Forms.Padding(5);
            this.AttendName.Multiline = false;
            this.AttendName.Name = "AttendName";
            this.AttendName.Padding = new System.Windows.Forms.Padding(9);
            this.AttendName.PasswordChar = false;
            this.AttendName.Size = new System.Drawing.Size(244, 44);
            this.AttendName.TabIndex = 4;
            this.AttendName.Texts = "";
            this.AttendName.UnderlinedStyle = true;
            // 
            // AttendId
            // 
            this.AttendId.BackColor = System.Drawing.Color.White;
            this.AttendId.BorderColor = System.Drawing.Color.Black;
            this.AttendId.BorderFocusColor = System.Drawing.Color.Purple;
            this.AttendId.BorderSize = 4;
            this.AttendId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendId.ForeColor = System.Drawing.Color.Gainsboro;
            this.AttendId.Location = new System.Drawing.Point(127, 102);
            this.AttendId.Margin = new System.Windows.Forms.Padding(5);
            this.AttendId.Multiline = false;
            this.AttendId.Name = "AttendId";
            this.AttendId.Padding = new System.Windows.Forms.Padding(9);
            this.AttendId.PasswordChar = false;
            this.AttendId.Size = new System.Drawing.Size(244, 44);
            this.AttendId.TabIndex = 2;
            this.AttendId.Texts = "";
            this.AttendId.UnderlinedStyle = true;
            // 
            // AttendantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1325, 752);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AttendantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendantForm";
            this.Load += new System.EventHandler(this.AttendantForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView AttendDGV;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private CustomControls.RJControls.RJTextBox AttendPhone;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox AttendAge;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox AttendName;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox AttendId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private CustomControls.RJControls.RJTextBox AttendPass;
        private System.Windows.Forms.Label label6;
    }
}