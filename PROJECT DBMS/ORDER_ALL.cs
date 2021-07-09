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
    public partial class ORDER_ALL : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");
        int a = 250;
        int b = 200;
        string m;
        public ORDER_ALL(string value)
        {
            InitializeComponent();
            m = value;
            populateData();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

       
        private void populateData()
        {
            con.Open();

            SqlCommand s = new SqlCommand("SELECT PR_CUSTOMERS.ID AS TotalCount FROM dbo.PR_CUSTOMERS WHERE NAME='" + m + "'", con);

            //Creating object of reader
            SqlDataReader reader1;

            reader1 = s.ExecuteReader();
            while (reader1.Read())
            {
                //Get the Sum of Column from Database
                idField.Text = reader1["TotalCount"].ToString();
            }

            reader1.Close();

            SqlCommand s1 = new SqlCommand("SELECT COUNT(ORDER_ID) AS TotalCount FROM dbo.PR_ORDER1 WHERE CUTOMER_ID='" + idField.Text + "'", con);

            //Creating object of reader
            SqlDataReader reader2;

            reader2 = s1.ExecuteReader();
            while (reader2.Read())
            {
                //Get the Sum of Column from Database
                id1Field.Text = reader2["TotalCount"].ToString();
            }

            reader2.Close();
            if (Convert.ToInt32(this.id1Field.Text) == 0)
            {
                MessageBox.Show("NO ORDERS ARE PLACED YET");
            }
            else
            { 
           
                string q3 = " SELECT PR_CUSTOMERS.NAME,PR_CUSTOMERS.EMAIL,PR_ORDER1.ORDER_ID,PR_ORDER1.STATUSES,PR_ORDER1.PRICE,PR_ORDER1.QUANTITY,PR_ORDER1.ORDER_DATE,CONCAT(PR_ORDERS_COMPOSITE.AREA, ',',PR_ORDERS_COMPOSITE.CITY ) FROM PR_CUSTOMERS INNER JOIN PR_ORDER1 ON PR_CUSTOMERS.ID=PR_ORDER1.CUTOMER_ID INNER JOIN PR_ORDERS_COMPOSITE ON PR_ORDERS_COMPOSITE.ID=PR_ORDER1.ORDER_ID WHERE PR_CUSTOMERS.ID='" + idField.Text + "'";
                SqlCommand cmd2 = new SqlCommand(q3, con);
                SqlDataAdapter ad1 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                ad1.Fill(ds2);

                string q2 = "SELECT  S1.ORDER_ID,(SELECT '     '+S2.PHONE_NO FROM PR_ORDERS_MULTIVALUES S2 WHERE S1.ORDER_ID = S2.ORDER_ID  FOR XML PATH('')) FROM PR_ORDERS_MULTIVALUES S1  INNER JOIN PR_ORDER1 ON PR_ORDER1.ORDER_ID=S1.ORDER_ID WHERE  PR_ORDER1.CUTOMER_ID='"+idField.Text+"'  GROUP BY S1.ORDER_ID";

                SqlCommand cmd1 = new SqlCommand(q2, con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                ad.Fill(ds1);
                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {

                    string name = ds2.Tables[0].Rows[i].ItemArray[0].ToString();
                    // string address = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    //string phone = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    string email = ds2.Tables[0].Rows[i].ItemArray[1].ToString();
                    string id = ds2.Tables[0].Rows[i].ItemArray[2].ToString();
                    string status = ds2.Tables[0].Rows[i].ItemArray[3].ToString();
                    string price = ds2.Tables[0].Rows[i].ItemArray[4].ToString();
                    string quantity = ds2.Tables[0].Rows[i].ItemArray[5].ToString();

                    dateTimePicker1.Text = ds2.Tables[0].Rows[i].ItemArray[6].ToString();
                    //string address = ds2.Tables[0].Rows[i].ItemArray[7].ToString();
                   // string city = ds2.Tables[0].Rows[i].ItemArray[7].ToString();
                    string area = ds2.Tables[0].Rows[i].ItemArray[7].ToString();

                    string phone = ds1.Tables[0].Rows[i].ItemArray[1].ToString();
                    

                    // string phone = ds.Tables[0].Rows[i].ItemArray[7].ToString();

                    // string phone = ds1.Tables[0].Rows[i].ItemArray[1].ToString();

                    DataGridViewRow row1 = new DataGridViewRow();
                    dataGridView1.ColumnCount = 9;

                    row1.CreateCells(dataGridView1);



                    //              dataGridView1.Updat;

                    row1.Cells[0].Value = name;
                    row1.Cells[1].Value = email;
                    // row1.Cells[4].Value = phone;
                    row1.Cells[2].Value = id;
                    row1.Cells[3].Value = price;
                    row1.Cells[4].Value = status;
                    row1.Cells[5].Value = quantity;

                    //  row1.Cells[6].Value = phone;
                    //              row1.Cells[4].Value =phone;


                    // row1.Cells[5].DataFormatString ="{ 0:dd/MM/yyyy}";

                    row1.Cells[6].Value = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                   // row1.Cells[7].Value = address;
                   // row1.Cells[7].Value = city;
                    row1.Cells[7].Value = area;
                    row1.Cells[8].Value = phone;

                    //row1.Columns(5).DefaultCellStyle.Format = "dd/MM/yyyy";

                    //row1.Cells[6].Value = phone;

                    // row1.Cells[3].Value = quantity;
                    dataGridView1.Rows.Add(row1);
                }


                //  if( Convert.ToInt32(this.id1Field.Text)>1)
            }

            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ORDER_ALL_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(m);
            f2.ShowDialog();
        }

        private void ORDER_ALL_Load_1(object sender, EventArgs e)
        {

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(m);
            f2.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

     
