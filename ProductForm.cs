using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopritePMS
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttendantForm Attend = new AttendantForm();
            Attend.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Texts = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Texts = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Texts = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Texts = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JED\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTb1", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader(); 
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "CatName";
            CatCb.DataSource = dt;
            Con.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into ProductTb1 values(" + ProdId.Texts + ",'" + ProdName.Texts + "', '" + ProdQty.Texts + "', '"+ProdPrice.Texts+"', '"+CatCb.SelectedValue.ToString()+"' )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Texts == "" || ProdName.Texts == "" || ProdQty.Texts == "" || ProdPrice.Texts == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "Update ProductTb1 set ProdName='" + ProdName.Texts + "'ProdQty='" + ProdQty.Texts +"'ProdPrice'" +ProdPrice+ "'where ProdId=" + ProdId.Texts + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Texts == "")
                {
                    MessageBox.Show("Select the Product to Delete");

                }
                else
                {
                    Con.Open();
                    string query = " delete from CategoryTb1 where CatId=" + ProdId.Texts + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellingForm sell = new SellingForm();
            sell.Show();
            this.Hide();
        }

        private void CatCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from ProductTb1 where ProdCat= '" + CatCb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from ProductTb1 where ProdCat= '"+CatCb.SelectedValue.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
