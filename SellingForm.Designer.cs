namespace ShopritePMS
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amtlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.ProdPrice = new CustomControls.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProdDGV1 = new System.Windows.Forms.DataGridView();
            this.Sellerlbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ProdQty = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdName = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillId = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.OrderDGV);
            this.panel1.Controls.Add(this.Amtlbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.SearchCb);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ProdDGV1);
            this.panel1.Controls.Add(this.Sellerlbl);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.BillsDGV);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BillId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(151, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 708);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(716, 336);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 38);
            this.label7.TabIndex = 26;
            this.label7.Text = "Sell List";
            // 
            // OrderDGV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderDGV.EnableHeadersVisualStyles = false;
            this.OrderDGV.Location = new System.Drawing.Point(443, 65);
            this.OrderDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderDGV.Name = "OrderDGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderDGV.RowHeadersWidth = 53;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(693, 206);
            this.OrderDGV.TabIndex = 25;
            this.OrderDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDGV_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Prodid";
            this.ID.MinimumWidth = 7;
            this.ID.Name = "ID";
            this.ID.Width = 130;
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 7;
            this.PName.Name = "PName";
            this.PName.Width = 130;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 7;
            this.Price.Name = "Price";
            this.Price.Width = 130;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 7;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 130;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 7;
            this.Total.Name = "Total";
            this.Total.Width = 130;
            // 
            // Amtlbl
            // 
            this.Amtlbl.AutoSize = true;
            this.Amtlbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amtlbl.ForeColor = System.Drawing.Color.White;
            this.Amtlbl.Location = new System.Drawing.Point(795, 281);
            this.Amtlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(0, 34);
            this.Amtlbl.TabIndex = 24;
            this.Amtlbl.Click += new System.EventHandler(this.Amtlbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(604, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 34);
            this.label5.TabIndex = 23;
            this.label5.Text = "Amount Ghc";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(101, 236);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 34);
            this.button9.TabIndex = 22;
            this.button9.Text = "ADD PRODUCT";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // SearchCb
            // 
            this.SearchCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SearchCb.ForeColor = System.Drawing.Color.Black;
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Items.AddRange(new object[] {
            "ADMIN",
            "ATTENDANT"});
            this.SearchCb.Location = new System.Drawing.Point(33, 278);
            this.SearchCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(211, 33);
            this.SearchCb.TabIndex = 21;
            this.SearchCb.Text = "Select Category";
            this.SearchCb.SelectionChangeCommitted += new System.EventHandler(this.SearchCb_SelectedIndexChanged);
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.Color.White;
            this.ProdPrice.BorderColor = System.Drawing.Color.Black;
            this.ProdPrice.BorderFocusColor = System.Drawing.Color.Purple;
            this.ProdPrice.BorderSize = 5;
            this.ProdPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.ForeColor = System.Drawing.Color.OldLace;
            this.ProdPrice.Location = new System.Drawing.Point(172, 138);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdPrice.Multiline = false;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ProdPrice.PasswordChar = false;
            this.ProdPrice.Size = new System.Drawing.Size(180, 44);
            this.ProdPrice.TabIndex = 20;
            this.ProdPrice.Texts = "";
            this.ProdPrice.UnderlinedStyle = true;
            this.ProdPrice._TextChanged += new System.EventHandler(this.ProdPrice__TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price";
            // 
            // ProdDGV1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ProdDGV1.BackgroundColor = System.Drawing.Color.White;
            this.ProdDGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV1.DefaultCellStyle = dataGridViewCellStyle7;
            this.ProdDGV1.EnableHeadersVisualStyles = false;
            this.ProdDGV1.Location = new System.Drawing.Point(33, 319);
            this.ProdDGV1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProdDGV1.Name = "ProdDGV1";
            this.ProdDGV1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProdDGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ProdDGV1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV1.Size = new System.Drawing.Size(319, 374);
            this.ProdDGV1.TabIndex = 18;
            this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
            // 
            // Sellerlbl
            // 
            this.Sellerlbl.AutoSize = true;
            this.Sellerlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Sellerlbl.ForeColor = System.Drawing.Color.White;
            this.Sellerlbl.Location = new System.Drawing.Point(80, 11);
            this.Sellerlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sellerlbl.Name = "Sellerlbl";
            this.Sellerlbl.Size = new System.Drawing.Size(66, 25);
            this.Sellerlbl.TabIndex = 17;
            this.Sellerlbl.Text = "Seller";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Datelbl.ForeColor = System.Drawing.Color.White;
            this.Datelbl.Location = new System.Drawing.Point(989, 20);
            this.Datelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(60, 25);
            this.Datelbl.TabIndex = 17;
            this.Datelbl.Text = "Date";
            // 
            // BillsDGV
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsDGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.BillsDGV.EnableHeadersVisualStyles = false;
            this.BillsDGV.Location = new System.Drawing.Point(401, 374);
            this.BillsDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersVisible = false;
            this.BillsDGV.RowHeadersWidth = 53;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(735, 217);
            this.BillsDGV.TabIndex = 13;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.IndianRed;
            this.button7.Location = new System.Drawing.Point(865, 658);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 34);
            this.button7.TabIndex = 12;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.IndianRed;
            this.button6.Location = new System.Drawing.Point(716, 658);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 34);
            this.button6.TabIndex = 11;
            this.button6.Text = "PRINT";
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
            this.button4.Location = new System.Drawing.Point(553, 658);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.Color.White;
            this.ProdQty.BorderColor = System.Drawing.Color.Black;
            this.ProdQty.BorderFocusColor = System.Drawing.Color.Purple;
            this.ProdQty.BorderSize = 5;
            this.ProdQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQty.ForeColor = System.Drawing.Color.OldLace;
            this.ProdQty.Location = new System.Drawing.Point(172, 182);
            this.ProdQty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdQty.Multiline = false;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ProdQty.PasswordChar = false;
            this.ProdQty.Size = new System.Drawing.Size(180, 44);
            this.ProdQty.TabIndex = 6;
            this.ProdQty.Texts = "";
            this.ProdQty.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "QUANTITY";
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.White;
            this.ProdName.BorderColor = System.Drawing.Color.Black;
            this.ProdName.BorderFocusColor = System.Drawing.Color.Purple;
            this.ProdName.BorderSize = 5;
            this.ProdName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.ForeColor = System.Drawing.Color.OldLace;
            this.ProdName.Location = new System.Drawing.Point(172, 91);
            this.ProdName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProdName.Multiline = false;
            this.ProdName.Name = "ProdName";
            this.ProdName.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.ProdName.PasswordChar = false;
            this.ProdName.Size = new System.Drawing.Size(180, 44);
            this.ProdName.TabIndex = 4;
            this.ProdName.Texts = "";
            this.ProdName.UnderlinedStyle = true;
            this.ProdName._TextChanged += new System.EventHandler(this.ProdName__TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProdName";
            // 
            // BillId
            // 
            this.BillId.BackColor = System.Drawing.Color.White;
            this.BillId.BorderColor = System.Drawing.Color.Black;
            this.BillId.BorderFocusColor = System.Drawing.Color.Purple;
            this.BillId.BorderSize = 5;
            this.BillId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillId.ForeColor = System.Drawing.Color.White;
            this.BillId.Location = new System.Drawing.Point(172, 47);
            this.BillId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BillId.Multiline = false;
            this.BillId.Name = "BillId";
            this.BillId.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.BillId.PasswordChar = false;
            this.BillId.Size = new System.Drawing.Size(180, 44);
            this.BillId.TabIndex = 2;
            this.BillId.Texts = "";
            this.BillId.UnderlinedStyle = true;
            this.BillId._TextChanged += new System.EventHandler(this.ProdId__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "BILL ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(497, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selling";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(7, 228);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Selling";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(7, 186);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 34);
            this.button2.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(7, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Attendant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1275, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 30);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(29, 709);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "LogOut";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(253, 278);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 33);
            this.button8.TabIndex = 15;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1325, 752);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView BillsDGV;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private CustomControls.RJControls.RJTextBox ProdQty;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox ProdName;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox BillId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ProdDGV1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.ComboBox SearchCb;
        private CustomControls.RJControls.RJTextBox ProdPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label Sellerlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.Label Amtlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button8;
    }
}