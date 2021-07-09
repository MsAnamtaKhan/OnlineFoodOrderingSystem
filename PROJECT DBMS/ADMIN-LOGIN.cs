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
namespace PROJECT_DBMS
{
    public partial class ADMIN_LOGIN : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        public ADMIN_LOGIN()
        {
            InitializeComponent();
            populateData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_LOGIN f2 = new ADMIN_LOGIN();
            f2.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN f2 = new ADMIN();
            f2.ShowDialog();
        }

        private void modifyItems_Click(object sender, EventArgs e)
        {

            this.Hide();
            MODIFY_ITEMS f2 = new MODIFY_ITEMS();
            f2.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
          ADD_ITEM f2 = new ADD_ITEM();
            f2.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DELETE_ITEM f2 = new DELETE_ITEM();
            f2.ShowDialog();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ORDERS f2 = new ORDERS();
            f2.ShowDialog();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_CUSTOMERS f2 = new ADMIN_CUSTOMERS();
            f2.ShowDialog();
        }

        private void deliverymenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_DELIVER f2 = new ADMIN_DELIVER();
            f2.ShowDialog();
        }

        private void populateData()
        {
            dataGridView1.Rows.Clear();
            con.Open();

            SqlCommand cmd = new SqlCommand("select FOOD_ID,FOOD_NAME,PRICES from PR_FOOD_ITEMS1", con);
            //TO RETRIEVE DATA
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string itemID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string item_name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string price = ds.Tables[0].Rows[i].ItemArray[2].ToString();
              
                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView1);
                row1.Cells[0].Value = itemID;
                row1.Cells[1].Value = item_name;
                row1.Cells[2].Value = price;
            
                dataGridView1.Rows.Add(row1);
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADMIN_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
