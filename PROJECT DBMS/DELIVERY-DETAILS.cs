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
    public partial class DELIVERY_DETAILS : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        string m;
        public DELIVERY_DETAILS(string value)
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
            this.Hide();
            DELIVER_CUSTOMER f2 = new DELIVER_CUSTOMER(m);
            f2.ShowDialog();
        }

        private void deliverymenButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            string query = " SELECT PR_DELIVERYMEN.NAME,PR_DELIVERYMEN.EMAIL,CONCAT(PR_DELIVERYMEN_COMPOSITE.AREA,', ',PR_DELIVERYMEN_COMPOSITE.CITY) FROM  PR_DELIVERYMEN INNER JOIN   PR_DELIVERYMEN_COMPOSITE ON PR_DELIVERYMEN.ID=PR_DELIVERYMEN_COMPOSITE.ID WHERE PR_DELIVERYMEN.ID='" + idField.Text + "'";

            // string q2 = "SELECT  S1.ID,(SELECT '     '+S2.PHONE_NO FROM PR_DELIVERYMEN_MULTIVALUES S2 WHERE S1.ID = S2.ID  FOR XML PATH('')) FROM PR_DELIVERYMEN_MULTIVALUES S1 GROUP BY S1.ID";

            SqlCommand cmd = new SqlCommand(query, con);

            //TO RETRIEVE DATA
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            string q2 = "SELECT  S1.ID,(SELECT '     '+S2.PHONE_NO FROM PR_DELIVERYMEN_MULTIVALUES S2 WHERE S1.ID = S2.ID  FOR XML PATH('')) FROM PR_DELIVERYMEN_MULTIVALUES S1 GROUP BY S1.ID HAVING S1.ID='" + idField.Text + "'";

            SqlCommand cmd1 = new SqlCommand(q2, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            ad.Fill(ds1);

          

            SqlCommand s = new SqlCommand("SELECT COUNT(PR_ORDER1.ID) AS TOTAL_COUNT FROM dbo.PR_ORDER1 WHERE PR_ORDER1.ID='" + idField.Text + "'", con);
            //Creating object of reader
            SqlDataReader reader1;
            //Executing the reader
            reader1 = s.ExecuteReader();
            reader1.Read();
            //Get the Sum of Column from Database
            id2Field.Text = reader1.GetValue(0).ToString();
            reader1.Close();
            if (Convert.ToInt32(this.id2Field.Text) == 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    string name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string email = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    
                    string area = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    
                    string phone = ds1.Tables[0].Rows[i].ItemArray[1].ToString();
                    string order = "NOT DELIVER ANY ORDER";

                    DataGridViewRow row1 = new DataGridViewRow();
                    dataGridView1.ColumnCount = 5;
                    row1.CreateCells(dataGridView1);

                    row1.Cells[0].Value = name;
                    row1.Cells[1].Value = email;
                 
                    row1.Cells[2].Value = area;
                    row1.Cells[3].Value = phone;
                    row1.Cells[4].Value = order;

                  
                    dataGridView1.Rows.Add(row1);
                }
            }

            else
            {
                string q3 = "SELECT  S1.ID,(SELECT '             '+CAST(S2.ORDER_ID AS VARCHAR(20)) FROM PR_ORDER1 S2 WHERE S1.ID = S2.ID  FOR XML PATH('')) FROM PR_ORDER1  S1 GROUP BY S1.ID HAVING S1.ID='" + idField.Text + "'";


                SqlCommand cmd2 = new SqlCommand(q3, con);
                SqlDataAdapter ad1 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                ad1.Fill(ds2);

                //DataGridViewRow row1 = new DataGridViewRow();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    string name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string email = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                 
                    string area = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                 

                    string phone = ds1.Tables[0].Rows[i].ItemArray[1].ToString();
                    string order = ds2.Tables[0].Rows[i].ItemArray[1].ToString();

                    DataGridViewRow row1 = new DataGridViewRow();
                    dataGridView1.ColumnCount = 5;
                    row1.CreateCells(dataGridView1);

                    row1.Cells[0].Value = name;
                    row1.Cells[1].Value = email;
                   
                    row1.Cells[2].Value = area;
                    row1.Cells[3].Value = phone;
                    row1.Cells[4].Value = order;

                    

                    dataGridView1.Rows.Add(row1);
                }
            }

            con.Close();
        }


    

    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
