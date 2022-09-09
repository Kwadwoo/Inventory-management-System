using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace ShopritePMS
{
    public partial class AttendantForm : Form
    {
        public AttendantForm()
        {
            InitializeComponent();
        }
        public void AttendantForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JED\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into AttendantTb1 values(" + AttendId.Texts + ",'" + AttendName.Texts + "', '" + AttendAge.Texts + "', '" + AttendPhone.Texts + "', '"+AttendPass+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendant Added Successfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }
              

           
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AttendId.Texts = AttendDGV.SelectedRows[0].Cells[0].Value.ToString();
            AttendName.Texts = AttendDGV.SelectedRows[0].Cells[1].Value.ToString();
            AttendAge.Texts = AttendDGV.SelectedRows[0].Cells[2].Value.ToString();
            AttendPhone.Texts = AttendDGV.SelectedRows[0].Cells[3].Value.ToString();
            AttendPass.Texts = AttendDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from AttendantTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttendId.Texts == "")
                {
                    MessageBox.Show("Select the Attendant to Delete");
                    Con.Close();
                   

                }
                else
                {
                    Con.Open();
                    string query = " delete from AttendantTb1 where AttendId=" + AttendId.Texts + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendant Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttendId.Texts == "" || AttendName.Texts == "" || AttendAge.Texts == "" || AttendPhone.Texts == "" || AttendPass.Texts == "")
                {
                    MessageBox.Show("Missing Information");
                    Con.Close();
                    
                }
                else
                {
                    Con.Open();
                    string query = "Update CategoryTb1 set AttendName='" + AttendName.Texts + "',AttendAge='" + AttendAge.Texts + "'AttendPhone'"+AttendPhone.Texts+"'AttendPass'" +AttendPass.Texts+ "'where AttendId=" + AttendId.Texts + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendant Successfully Updated");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellingForm sell = new SellingForm();
            sell.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
