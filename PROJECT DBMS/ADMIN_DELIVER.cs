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
    public partial class ADMIN_DELIVER : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");


        public ADMIN_DELIVER()
        {
            InitializeComponent();
            populateData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_LOGIN f2 = new ADMIN_LOGIN();
            f2.ShowDialog();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_CUSTOMERS f2 = new ADMIN_CUSTOMERS();
            f2.ShowDialog();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ORDERS f2 = new ORDERS();
            f2.ShowDialog();
        }

        private void deliverymenButton_Click(object sender, EventArgs e)
        {
            this.Show();
          
        }

        private void modifyItems_Click(object sender, EventArgs e)
        {
            this.Hide();
           MODIFY_DELIVER f2 = new MODIFY_DELIVER();
            f2.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD_DELIVERYMEN f2 = new ADD_DELIVERYMEN();
            f2.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DELETE_DELIVER f2 = new DELETE_DELIVER();
            f2.ShowDialog();
        }

        private void populateData()
        {
            dataGridView2.Rows.Clear();

            con.Open();

            string query = " SELECT PR_DELIVERYMEN.ID,PR_DELIVERYMEN.NAME,PR_DELIVERYMEN.PASSWORDS,PR_DELIVERYMEN.EMAIL,CONCAT(PR_DELIVERYMEN_COMPOSITE.AREA,', ',PR_DELIVERYMEN_COMPOSITE.CITY) FROM  PR_DELIVERYMEN INNER JOIN   PR_DELIVERYMEN_COMPOSITE ON PR_DELIVERYMEN.ID=PR_DELIVERYMEN_COMPOSITE.ID ";
            
           
            SqlCommand cmd = new SqlCommand(query, con);
            
            //TO RETRIEVE DATA
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            string q2 = "SELECT  S1.ID,(SELECT '     '+S2.PHONE_NO FROM PR_DELIVERYMEN_MULTIVALUES S2 WHERE S1.ID = S2.ID  FOR XML PATH('')) FROM PR_DELIVERYMEN_MULTIVALUES S1 GROUP BY S1.ID ";

            SqlCommand cmd1 = new SqlCommand(q2, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            ad.Fill(ds1);

        
          
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string ID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string password = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string email = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                   
                    string area = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string order, status;



                SqlCommand s = new SqlCommand("SELECT COUNT(PR_ORDER1.ID) AS TOTAL_COUNT FROM dbo.PR_ORDER1 WHERE PR_ORDER1.ID='" + ID+ "'", con);
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
                    order = "NOT DELIVERED ANY";
                    status = "NOT DELIVERED";
                }

                else
                {
                    string q3 = "SELECT  S1.STATUSES,S1.ID,(SELECT '             '+CAST(S2.ORDER_ID AS VARCHAR(20)) FROM PR_ORDER1 S2 WHERE S1.ID = S2.ID  FOR XML PATH('')) FROM PR_ORDER1  S1 GROUP BY S1.ID,S1.STATUSES HAVING S1.ID='" + ID + "'";

                   
                    SqlCommand cmd2 = new SqlCommand(q3, con);
                    SqlDataAdapter ad1 = new SqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    ad1.Fill(ds2);
                    //status = "";
                    status = ds2.Tables[0].Rows[0].ItemArray[0].ToString();
                    order = ds2.Tables[0].Rows[0].ItemArray[2].ToString();
                   
                }

                    string phone = ds1.Tables[0].Rows[i].ItemArray[1].ToString();

                    DataGridViewRow row1 = new DataGridViewRow();
                    dataGridView2.ColumnCount = 8;
                    row1.CreateCells(dataGridView2);
                    row1.Cells[0].Value = ID;
                    row1.Cells[1].Value = name;
                    row1.Cells[2].Value = password;
                    row1.Cells[3].Value = email;
                
                    row1.Cells[4].Value = area;
                    row1.Cells[5].Value = phone;
                    row1.Cells[6].Value = order;
                    row1.Cells[7].Value = status;
                    dataGridView2.Rows.Add(row1);
                }

            
    
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
