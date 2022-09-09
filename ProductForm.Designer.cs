namespace ShopritePMS
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.ProdPrice = new CustomControls.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdQty = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdName = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdId = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.ProdDGV);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(152, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 708);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.IndianRed;
            this.button8.Location = new System.Drawing.Point(844, 74);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 33);
            this.button8.TabIndex = 15;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ADMIN",
            "ATTENDANT"});
            this.comboBox2.Location = new System.Drawing.Point(592, 74);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(243, 33);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "Select Category";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // ProdDGV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProdDGV.EnableHeadersVisualStyles = false;
            this.ProdDGV.Location = new System.Drawing.Point(456, 114);
            this.ProdDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProdDGV.RowHeadersWidth = 53;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(693, 590);
            this.ProdDGV.TabIndex = 13;
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.IndianRed;
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
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.IndianRed;
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
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.IndianRed;
            this.button4.Location = new System.Drawing.Point(11, 490);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CatCb.ForeColor = System.Drawing.Color.IndianRed;
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "ADMIN",
            "ATTENDANT"});
            this.CatCb.Location = new System.Drawing.Point(127, 410);
            this.CatCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(243, 33);
            this.CatCb.TabIndex = 9;
            this.CatCb.Text = "Select Category";
            this.CatCb.SelectionChangeCommitted += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.Color.LightGray;
            this.ProdPrice.BorderColor = System.Drawing.Color.White;
            this.ProdPrice.BorderFocusColor = System.Drawing.Color.Purple;
            this.ProdPrice.BorderSize = 2;
            this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.ForeColor = System.Drawing.Color.DimGray;
            this.ProdPrice.Location = new System.Drawing.Point(127, 322);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdPrice.Multiline = false;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ProdPrice.PasswordChar = false;
            this.ProdPrice.Size = new System.Drawing.Size(244, 44);
            this.ProdPrice.TabIndex = 8;
            this.ProdPrice.Texts = "";
            this.ProdPrice.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "CATEGORY";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRICE";
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.Color.LightGray;
            this.ProdQty.BorderColor = System.Drawing.Color.White;
            this.ProdQty.BorderFocusColor = System.Drawing.Color.Purple;
            this.ProdQty.BorderSize = 2;
            this.ProdQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.ForeColor = System.Drawing.Color.DimGray;
            this.ProdQty.Location = new System.Drawing.Point(127, 242);
            this.ProdQty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdQty.Multiline = false;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ProdQty.PasswordChar = false;
            this.ProdQty.Size = new System.Drawing.Size(244, 44);
            this.ProdQty.TabIndex = 6;
            this.ProdQty.Texts = "";
            this.ProdQty.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "QUANTITY";
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.LightGray;
            this.ProdName.BorderColor = System.Drawing.Color.White;
            this.ProdName.BorderFocusColor = System.Drawing.Color.Purple;
            this.ProdName.BorderSize = 2;
            this.ProdName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.ForeColor = System.Drawing.Color.DimGray;
            this.ProdName.Location = new System.Drawing.Point(127, 167);
            this.ProdName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdName.Multiline = false;
            this.ProdName.Name = "ProdName";
            this.ProdName.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ProdName.PasswordChar = false;
            this.ProdName.Size = new System.Drawing.Size(244, 44);
            this.ProdName.TabIndex = 4;
            this.ProdName.Texts = "";
            this.ProdName.UnderlinedStyle = true;
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
            // ProdId
            // 
            this.ProdId.BackColor = System.Drawing.Color.LightGray;
            this.ProdId.BorderColor = System.Drawing.Color.White;
            this.ProdId.BorderFocusColor = System.Drawing.Color.Purple;
            this.ProdId.BorderSize = 2;
            this.ProdId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdId.ForeColor = System.Drawing.Color.DimGray;
            this.ProdId.Location = new System.Drawing.Point(127, 102);
            this.ProdId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdId.Multiline = false;
            this.ProdId.Name = "ProdId";
            this.ProdId.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ProdId.PasswordChar = false;
            this.ProdId.Size = new System.Drawing.Size(244, 44);
            this.ProdId.TabIndex = 2;
            this.ProdId.Texts = "";
            this.ProdId.UnderlinedStyle = true;
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
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(421, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(4, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Attendant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(4, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(4, 223);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Selling";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1273, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1325, 752);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox ProdPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox ProdQty;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox ProdName;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox ProdId;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView ProdDGV;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
    }
}