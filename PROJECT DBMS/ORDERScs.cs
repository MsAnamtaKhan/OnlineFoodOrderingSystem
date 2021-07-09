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
    public partial class ORDERS : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        public ORDERS()
        {
            InitializeComponent();
            populateData();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_LOGIN f2 = new ADMIN_LOGIN();
            f2.ShowDialog();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void orderIdField_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusField_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerIdField_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalPriceField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void itemsField_TextChanged(object sender, EventArgs e)
        {

        }

        private void ORDERS_Load(object sender, EventArgs e)
        {

        }
        private void populateData()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            con.Open();
            string q2 = "SELECT PR_ORDER1.ORDER_ID,PR_ORDER1.PRICE,PR_ORDER1.QUANTITY,PR_ORDER1.STATUSES,PR_ORDER1.ORDER_DATE FROM PR_ORDER1";

            SqlCommand cmd1 = new SqlCommand(q2, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            ad.Fill(ds1);
            string q3 = "SELECT  * FROM ORDER_FOOD1";
            SqlCommand cmd2 = new SqlCommand(q3, con);
            SqlDataAdapter ad1 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            ad1.Fill(ds2);
   
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {

                string id = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                // string address = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                //string phone = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string price = ds1.Tables[0].Rows[i].ItemArray[1].ToString();
                string quantity= ds1.Tables[0].Rows[i].ItemArray[2].ToString();
                string status = ds1.Tables[0].Rows[i].ItemArray[3].ToString();
             

                dateTimePicker1.Text = ds1.Tables[0].Rows[i].ItemArray[4].ToString();
          

                // string phone = ds.Tables[0].Rows[i].ItemArray[7].ToString();

                // string phone = ds1.Tables[0].Rows[i].ItemArray[1].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                dataGridView1.ColumnCount = 5;

                row1.CreateCells(dataGridView1);



                //              dataGridView1.Updat;

                row1.Cells[0].Value = id;
                row1.Cells[1].Value = price;
                // row1.Cells[4].Value = phone;
                row1.Cells[2].Value = quantity;
                row1.Cells[3].Value = status;
 

                row1.Cells[4].Value = dateTimePicker1.Value.ToString("dd-MM-yyyy");
              
                dataGridView1.Rows.Add(row1);
            }
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {

                string id = ds2.Tables[0].Rows[i].ItemArray[0].ToString();
                // string address = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                //string phone = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string food = ds2.Tables[0].Rows[i].ItemArray[1].ToString();
                string quantity = ds2.Tables[0].Rows[i].ItemArray[2].ToString();
               

              

                DataGridViewRow row1 = new DataGridViewRow();
                dataGridView2.ColumnCount = 3;

                row1.CreateCells(dataGridView2);



                //              dataGridView1.Updat;

                row1.Cells[0].Value = id;
                row1.Cells[1].Value = food;
                // row1.Cells[4].Value = phone;
                row1.Cells[2].Value = quantity;
               

               // row1.Cells[4].Value = dateTimePicker1.Value.ToString("dd-MM-yyyy");

                dataGridView2.Rows.Add(row1);
            }

            con.Close();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
