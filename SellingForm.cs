using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace ShopritePMS
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        private void ProdId__TextChanged(object sender, EventArgs e)
        {

        }

        private void ProdName__TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JED\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select ProdName, ProdQty from ProductTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTb1", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            SearchCb.ValueMember = "CatName";
            SearchCb.DataSource = dt;
            Con.Close();
        }
        private void populateBill()
        {
            Con.Open();
            string query = "select * from BillTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populateBill();
            fillcombo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int flag = 0;
        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Texts = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdPrice.Texts = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void ProdPrice__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttendantForm Attend = new AttendantForm();
            Attend.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            int GrdTotal = 0, n = 0;
            if (ProdName.Texts == "" || ProdQty.Texts == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPrice.Texts) * Convert.ToInt32(ProdQty.Texts);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Texts;
                newRow.Cells[2].Value = ProdPrice.Texts;
                newRow.Cells[3].Value = ProdQty.Texts;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Texts) * Convert.ToInt32(ProdQty.Texts);
                OrderDGV.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                Amtlbl.Text = " " + GrdTotal;
                n++;
            }
        }

        private void OrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Amtlbl_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BillId.Texts == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into BillTb1 values(" + BillId.Texts + ",'" + Sellerlbl.Text + "', '" + Datelbl.Text + "'," + Amtlbl.Text + " )";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    Con.Close();
                    populateBill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SHOPRITE", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(300));
            e.Graphics.DrawString("Bill ID: " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString("Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(100, 160));
            e.Graphics.DrawString("CodeSpace ", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Red, new Point(280, 280));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void SearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select ProdName, ProdQty from ProductTb1 where ProdCat= '" + SearchCb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
