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
    public partial class DELIVER_CUSTOMER : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");
        string m;
        public DELIVER_CUSTOMER(string value)
        {
            InitializeComponent();
            m = value;
            populateData();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DELIVERYMEN_LOGIN f2 = new DELIVERYMEN_LOGIN(m);
            f2.ShowDialog();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void deliverymenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DELIVERY_DETAILS f2 = new DELIVERY_DETAILS(m);
            f2.ShowDialog();
        }

        private void populateData()
        {
            dataGridView1.Rows.Clear();

            con.Open();
            SqlCommand sc = new SqlCommand("SELECT PR_DELIVERYMEN.ID AS TotalCount FROM dbo.PR_DELIVERYMEN WHERE PR_DELIVERYMEN.PASSWORDS='" + m + "'", con);
            //Creating object of reader
            SqlDataReader reader;
            //Executing the reader
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                //Get the Sum of Column from Database
                idField.Text = reader["TotalCount"].ToString();
            }

            reader.Close();

            SqlCommand s= new SqlCommand("SELECT COUNT(PR_ORDER1.ID) AS TOTAL_COUNT FROM dbo.PR_ORDER1 WHERE PR_ORDER1.ID='" + idField.Text+ "'", con);
            //Creating object of reader
            SqlDataReader reader1;
            //Executing the reader
            reader1 = s.ExecuteReader();
            while (reader1.Read())

            //Get the Sum of Column from Database
            { id2Field.Text = reader1.GetValue(0).ToString();
            }
                reader1.Close();
            if (Convert.ToInt32(this.id2Field.Text)==0)
            {
                MessageBox.Show("NO ORDERS ARE DELIVERED YET");
            }
            else
            {
                SqlCommand s1 = new SqlCommand("SELECT PR_ORDER1.ORDER_ID FROM dbo.PR_ORDER1 WHERE PR_ORDER1.ID='" + idField.Text + "'", con);
                //Creating object of reader
                SqlDataReader reader2;
                //Executing the reader
                reader2 = s1.ExecuteReader();
                reader2.Read();
                //Get the Sum of Column from Database
                id1Field.Text = reader2.GetValue(0).ToString();


                if (Convert.ToInt32(this.id2Field.Text) > 1)
                {
                    reader2.Read();
                    id2Field.Text = reader2.GetValue(0).ToString();
                }
                reader2.Close();



                string query = "SELECT PR_ORDER1.ORDER_ID,PR_CUSTOMERS.NAME,PR_CUSTOMERS.EMAIL,PR_ORDER1.PRICE FROM PR_ORDER1 INNER JOIN PR_CUSTOMERS ON PR_ORDER1.CUTOMER_ID=PR_CUSTOMERS.ID WHERE PR_ORDER1.ID='" + idField.Text + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);



                if (Convert.ToInt32(this.id2Field.Text) > 1)
                {
                    string q3 = " SELECT PR_PAYMENTS.PAYMENT_TYPE FROM PR_PAYMENTS INNER JOIN PR_ORDER1 ON PR_PAYMENTS.ORDER_ID='" + id1Field.Text + "' OR PR_PAYMENTS.ORDER_ID='" + id2Field.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(q3, con);
                    SqlDataAdapter ad1 = new SqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    ad1.Fill(ds2);
                    string q2 = "SELECT  S1.ORDER_ID,(SELECT '     '+S2.PHONE_NO FROM PR_ORDERS_MULTIVALUES S2 WHERE S1.ORDER_ID = S2.ORDER_ID  FOR XML PATH('')) FROM PR_ORDERS_MULTIVALUES S1 GROUP BY S1.ORDER_ID HAVING S1.ORDER_ID='" + id1Field.Text + "' OR S1.ORDER_ID='" + id2Field.Text + "' ";

                    SqlCommand cmd1 = new SqlCommand(q2, con);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd1);
                    DataSet ds1 = new DataSet();
                    ad.Fill(ds1);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                        string email = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                        string price = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                        string phone = ds1.Tables[0].Rows[i].ItemArray[1].ToString();

                        string payment = ds2.Tables[0].Rows[i].ItemArray[0].ToString();
                        
                        DataGridViewRow row1 = new DataGridViewRow();
                        dataGridView1.ColumnCount = 6;
                        row1.CreateCells(dataGridView1);


                        row1.Cells[0].Value = id;
                        row1.Cells[1].Value = name;
                        // row1.Cells[4].Value = phone;
                        row1.Cells[2].Value = payment;
                        row1.Cells[3].Value = price;

                        //  row1.Cells[6].Value = phone;
                        row1.Cells[4].Value = email;
                        row1.Cells[5].Value = phone;
                        
                        dataGridView1.Rows.Add(row1);
                    }
                }

                else
                {
                    string q3 = " SELECT PR_PAYMENTS.PAYMENT_TYPE FROM PR_PAYMENTS INNER JOIN PR_ORDER1 ON PR_PAYMENTS.ORDER_ID='" + id1Field.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(q3, con);
                    SqlDataAdapter ad1 = new SqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    ad1.Fill(ds2);

                    string q2 = "SELECT  S1.ORDER_ID,(SELECT '     '+S2.PHONE_NO FROM PR_ORDERS_MULTIVALUES S2 WHERE S1.ORDER_ID = S2.ORDER_ID  FOR XML PATH('')) FROM PR_ORDERS_MULTIVALUES S1 GROUP BY S1.ORDER_ID HAVING S1.ORDER_ID='" + id1Field.Text + "'";

                    SqlCommand cmd1 = new SqlCommand(q2, con);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd1);
                    DataSet ds1 = new DataSet();
                    ad.Fill(ds1);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                        string email = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                        string price = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                        string phone = ds1.Tables[0].Rows[i].ItemArray[1].ToString();

                        string payment = ds2.Tables[0].Rows[i].ItemArray[0].ToString();
                        
                        DataGridViewRow row1 = new DataGridViewRow();
                        dataGridView1.ColumnCount = 6;
                        row1.CreateCells(dataGridView1);


                        row1.Cells[0].Value = id;
                        row1.Cells[1].Value = name;
                        // row1.Cells[4].Value = phone;
                        row1.Cells[2].Value = payment;
                        row1.Cells[3].Value = price;

                        //  row1.Cells[6].Value = phone;
                        row1.Cells[4].Value = email;
                        row1.Cells[5].Value = phone;
                        //row1.Cells[6].Value = phone;
                        // row1.Cells[3].Value = quantity;
                        dataGridView1.Rows.Add(row1);
                    }
                }
               

            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
