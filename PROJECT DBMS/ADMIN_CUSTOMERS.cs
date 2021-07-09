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
    public partial class ADMIN_CUSTOMERS : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        public ADMIN_CUSTOMERS()
        {
            InitializeComponent();
            populateData();
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_LOGIN f2 = new ADMIN_LOGIN();
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
            this.Show();
         
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


            string query = " SELECT * FROM PR_CUSTOMERS";

            
            SqlCommand cmd = new SqlCommand(query, con);

            //TO RETRIEVE DATA
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            //DataGridViewRow row1 = new DataGridViewRow();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string ID= ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string password = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string email = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                SqlCommand s = new SqlCommand("SELECT COUNT(PR_ORDER1.ORDER_ID) AS TOTAL_COUNT FROM dbo.PR_ORDER1 WHERE PR_ORDER1.CUTOMER_ID='" + ID + "'", con);
                //Creating object of reader
                SqlDataReader reader1;
                //Executing the reader
                reader1 = s.ExecuteReader();
                reader1.Read();
                //Get the Sum of Column from Database
                idField.Text = reader1.GetValue(0).ToString();
                reader1.Close();
                string order, status,phone,area,payment;
                
                if (Convert.ToInt32(this.idField.Text) == 0)
                {
                    order = "NOT ORDER ANY";
                    status = "";
                   area=payment=phone = "";
                    
                }


                else
                {
                    string q3 = "SELECT  S1.STATUSES,S1.CUTOMER_ID,(SELECT '             '+CAST(S2.ORDER_ID AS VARCHAR(20)) FROM PR_ORDER1 S2 WHERE S1.CUTOMER_ID = S2.CUTOMER_ID  FOR XML PATH('')) FROM PR_ORDER1  S1 GROUP BY S1.CUTOMER_ID,S1.STATUSES HAVING S1.CUTOMER_ID='" + ID + "'";                   
                    SqlCommand cmd2 = new SqlCommand(q3, con);
                    SqlDataAdapter ad1 = new SqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    ad1.Fill(ds2);
                    order = ds2.Tables[0].Rows[0].ItemArray[2].ToString();
                    status = ds2.Tables[0].Rows[0].ItemArray[0].ToString();

                    string q2 = " SELECT CONCAT(PR_ORDERS_COMPOSITE.AREA,', ',PR_ORDERS_COMPOSITE.CITY) FROM PR_ORDERS_COMPOSITE INNER JOIN PR_ORDER1 ON PR_ORDER1.ORDER_ID=PR_ORDERS_COMPOSITE.ID WHERE PR_ORDER1.CUTOMER_ID='"+ID+"'";
                    SqlCommand cmd1 = new SqlCommand(q2, con);
                    SqlDataAdapter ad2 = new SqlDataAdapter(cmd1);
                    DataSet ds1 = new DataSet();
                    ad2.Fill(ds1);
                    area = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
                    int val;
                     bool id = int.TryParse(order, out val);
                    string q21 = " SELECT  S1.ORDER_ID,(SELECT '     '+S2.PHONE_NO FROM PR_ORDERS_MULTIVALUES S2 WHERE S1.ORDER_ID = S2.ORDER_ID  FOR XML PATH('')) FROM PR_ORDERS_MULTIVALUES S1 GROUP BY S1.ORDER_ID ";

                    SqlCommand cmd11 = new SqlCommand(q21, con);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd11);
                    DataSet ds11 = new DataSet();
                    ad.Fill(ds11);
                    phone = ds11.Tables[0].Rows[i].ItemArray[1].ToString();

                    string q4 = " SELECT PR_PAYMENTS.PAYMENT_TYPE FROM PR_PAYMENTS INNER JOIN PR_ORDER1 ON PR_ORDER1.ORDER_ID=PR_PAYMENTS.ORDER_ID WHERE PR_ORDER1.CUTOMER_ID='"+ID+"'";
                    SqlCommand cmd3 = new SqlCommand(q4, con);
                    SqlDataAdapter ad21 = new SqlDataAdapter(cmd3);
                    DataSet ds3 = new DataSet();
                    ad21.Fill(ds3);
                    payment = ds3.Tables[0].Rows[0].ItemArray[0].ToString();
                }
               
              

                
                DataGridViewRow row1 = new DataGridViewRow();
                dataGridView1.ColumnCount = 10;
                row1.CreateCells(dataGridView1);

                row1.Cells[0].Value = ID;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = password;
                row1.Cells[3].Value = email;
                row1.Cells[4].Value = phone;          
                row1.Cells[5].Value = order;
                row1.Cells[6].Value = status;
                row1.Cells[7].Value = payment;

                
                if (status == "DELIVERED")
                {
                    row1.Cells[8].Value = "PAID";
                }
                else
                {
                    row1.Cells[8].Value = "NOT PAID";
                }
          
                row1.Cells[9].Value = area;
               

                dataGridView1.Rows.Add(row1);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
