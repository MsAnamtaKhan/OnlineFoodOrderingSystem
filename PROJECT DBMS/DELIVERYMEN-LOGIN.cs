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
    public partial class DELIVERYMEN_LOGIN : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");
        string m;
        public DELIVERYMEN_LOGIN(string value)
        {
            InitializeComponent();
            populateData();
            m = value;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DELIVERYMEN f2 = new DELIVERYMEN();
            f2.ShowDialog();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DELIVER_CUSTOMER f2 = new DELIVER_CUSTOMER(m);
            f2.ShowDialog();
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
          //  dataGridView1.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy";
            con.Open();
          

       
           string q3 = " SELECT PR_ORDER1.ORDER_ID,CONCAT(PR_ORDERS_COMPOSITE.AREA,', ',PR_ORDERS_COMPOSITE.CITY),CAST(PR_ORDER1.ORDER_DATE AS DATE) FROM PR_ORDERS_COMPOSITE INNER JOIN PR_ORDER1 ON PR_ORDER1.ORDER_ID=PR_ORDERS_COMPOSITE.ID ";
            SqlCommand cmd2 = new SqlCommand(q3, con);
            SqlDataAdapter ad1 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            ad1.Fill(ds2);
            string m1 = "DELIVERED";
            SqlCommand sc = new SqlCommand("SELECT PR_ORDER1.STATUSES AS TotalCount FROM dbo.PR_ORDER1", con);
            //Creating object of reader
            SqlDataReader reader;
            //Executing the reader
            reader = sc.ExecuteReader();

           
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
               


                string ID = ds2.Tables[0].Rows[i].ItemArray[0].ToString();
               
                string area = ds2.Tables[0].Rows[i].ItemArray[1].ToString();
                dateTimePicker1.Text= ds2.Tables[0].Rows[i].ItemArray[2].ToString();
          

               

                DataGridViewRow row1 = new DataGridViewRow();
                dataGridView1.ColumnCount = 4;

                row1.CreateCells(dataGridView1);

               

            
                reader.Read();
                idField.Text = reader["TotalCount"].ToString();

                row1.Cells[0].Value = ID;
              
                row1.Cells[1].Value = area;

                //  row1.Cells[6].Value = phone;
  //              row1.Cells[4].Value =phone;
             
                if (idField.Text==m1)
                {
                    row1.Cells[2].Value = "ACCEPTED";
                }
                else
                {
                    row1.Cells[2].Value = "NOT ACCEPTED";

                }
                // row1.Cells[5].DataFormatString ="{ 0:dd/MM/yyyy}";

                 row1.Cells[3].Value = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                 
                
                dataGridView1.Rows.Add(row1);
            }
            reader.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sc = new SqlCommand("SELECT PR_DELIVERYMEN.ID AS TotalCount FROM dbo.PR_DELIVERYMEN WHERE PR_DELIVERYMEN.PASSWORDS='"+m+"'", con);
            //Creating object of reader
            SqlDataReader reader;
            //Executing the reader
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                //Get the Sum of Column from Database
                id2Field.Text = reader["TotalCount"].ToString();
            }

            reader.Close();

            SqlCommand cmd = new SqlCommand("UPDATE PR_ORDER1 SET STATUSES=@status,ID=@id WHERE ORDER_ID='"+acceptField.Text+"'", con);
            cmd.Parameters.AddWithValue("@status","DELIVERED");
            cmd.Parameters.AddWithValue("@id", id2Field.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            populateData();
        }
    }
}
