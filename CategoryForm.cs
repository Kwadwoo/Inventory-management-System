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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JED\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into CategoryTb1 values(" +CatIdTb.Texts+ ",'"+CatNameTb.Texts+ "', '"+CatDescTb.Texts+ "' )";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Texts = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Texts = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Texts = CatDGV.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIdTb.Texts == "")
                {
                    MessageBox.Show("Select the Category to Delete");

                }else
                {
                    Con.Open();
                    string query = " delete from CategoryTb1 where CatId=" +CatIdTb.Texts+ "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    populate();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Texts == "" || CatNameTb.Texts == "" || CatDescTb.Texts == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "Update CategoryTb1 set CatName='" + CatNameTb.Texts + "',CatDesc='" + CatDescTb.Texts + "'where CatId=" + CatIdTb.Texts + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    Con.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttendantForm attend = new AttendantForm();
            attend.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }
    }
}
