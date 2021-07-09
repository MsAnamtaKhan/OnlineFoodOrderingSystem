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
using System.Text.RegularExpressions;
namespace PROJECT_DBMS
{
    public partial class CUS_LOGIN : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");
        string m;
        public CUS_LOGIN(string value)
        {
            InitializeComponent();
            populateData();
             m = value;
            save_data_into_data_base();
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

    

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //save_data_into_data_base();
            this.Hide();
            CONFIRM f2 = new CONFIRM(id1Field.Text,id2Field.Text,priceField.Text);
            f2.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUSTOMER f2 = new CUSTOMER();
            f2.ShowDialog();
        }

        private void populateData()
        {
            dataGridView1.Rows.Clear();
            con.Open();
         
            SqlCommand cmd = new SqlCommand("select FOOD_NAME,PRICES from PR_FOOD_ITEMS1", con);
            //TO RETRIEVE DATA
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
               
                string item_name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string price = ds.Tables[0].Rows[i].ItemArray[1].ToString();
               // string quantity= ds.Tables[0].Rows[i].ItemArray[2].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                dataGridView1.ColumnCount = 3;
                row1.CreateCells(dataGridView1);
         
                row1.Cells[0].Value = item_name;
                row1.Cells[1].Value = price;
               //row1.Cells[2].Value = quantity;
              
                dataGridView1.Rows.Add(row1);
            }

            con.Close();
        }

        private void populateData1()
        {
           dataGridView2.Rows.Clear();
            con.Open();

             SqlCommand cmd = new SqlCommand("select FOOD_NAME,PRICES,ORDER_FOOD1.QUANTITY from PR_FOOD_ITEMS1 LEFT OUTER JOIN ORDER_FOOD1 ON PR_FOOD_ITEMS1.FOOD_ID=ORDER_FOOD1.FOOD_ID WHERE ORDER_FOOD1.ORDER_ID='"+id2Field.Text+"'", con);
            //TO RETRIEVE DATA
//            SqlCommand cmd = new SqlCommand("select ORDER_FOOD.QUANTITY from PR_FOOD_ITEMS LEFT OUTER JOIN ORDER_FOOD ON PR_FO WHERE ORDER_FOOD.ORDER_ID='" + id2Field.Text + "'", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                string item_name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string price = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string quantity= ds.Tables[0].Rows[i].ItemArray[2].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                dataGridView2.ColumnCount = 3;
                row1.CreateCells(dataGridView2);

                row1.Cells[0].Value = item_name;
                row1.Cells[1].Value = price;
                row1.Cells[2].Value = quantity;

                dataGridView2.Rows.Add(row1);
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void quantityField_TextChanged(object sender, EventArgs e)
        {

        }
        private void save_data_into_data_base()
        {


         
                 con.Open();

                   

                    SqlCommand s = new SqlCommand("SELECT PR_CUSTOMERS.ID AS TotalCount FROM dbo.PR_CUSTOMERS WHERE NAME='"+m+"'", con);
                   
                    //Creating object of reader
                    SqlDataReader reader1;
                    
                    reader1 = s.ExecuteReader();
                    while (reader1.Read())
                    {
                        //Get the Sum of Column from Database
                        id1Field.Text = reader1["TotalCount"].ToString();
                    }

                    reader1.Close();

                   SqlCommand cmd1 = new SqlCommand("INSERT INTO PR_ORDER1(CUTOMER_ID) VALUES(@id1)", con);
                    cmd1.Parameters.AddWithValue("@id1", id1Field.Text);
                    cmd1.ExecuteNonQuery();
                    

                    SqlCommand s2 = new SqlCommand("SELECT PR_ORDER1.ORDER_ID AS TotalCount FROM dbo.PR_ORDER1 WHERE CUTOMER_ID='" + id1Field.Text+"'", con);
                    //Creating object of reader
                    SqlDataReader reader2;
                    //Executing the reader
                    reader2 = s2.ExecuteReader();
                    while (reader2.Read())
                    {
                        //Get the Sum of Column from Database
                        id2Field.Text = reader2["TotalCount"].ToString();
                    }

                    reader2.Close();
                    
               
                    con.Close();

                

            }
        private bool checkQuantity(string n)
        {
            Regex check = new Regex(@"^[0-9]+$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;

        }
        private bool checkFood(string n)
        {
            Regex check = new Regex(@"([A-Z][a-z-A-z]+)$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;
        }
        private void Save()
        {
            if (checkQuantity(quantityField.Text) && checkFood(foodField.Text))
            {
                if (!checkEmail())
                {
                    MessageBox.Show("NOT AVAILABLE");
                }
                else {
                    con.Open();
                    SqlCommand sc = new SqlCommand("SELECT PR_FOOD_ITEMS1.FOOD_ID AS TotalCount FROM dbo.PR_FOOD_ITEMS1 WHERE FOOD_NAME='" + foodField.Text + "'", con);
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
                    SqlCommand s2 = new SqlCommand("SELECT PR_ORDER1.ORDER_ID AS TotalCount FROM dbo.PR_ORDER1 WHERE CUTOMER_ID='" + id1Field.Text + "'", con);
                    //Creating object of reader
                    SqlDataReader reader2;
                    //Executing the reader
                    reader2 = s2.ExecuteReader();
                    while (reader2.Read())
                    {
                        //Get the Sum of Column from Database
                        id2Field.Text = reader2["TotalCount"].ToString();
                    }

                    reader2.Close();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ORDER_FOOD1(ORDER_ID,FOOD_ID,QUANTITY) VALUES(@i,@id,@nam)", con);

                    cmd.Parameters.AddWithValue("@i", id2Field.Text);
                    cmd.Parameters.AddWithValue("@id", idField.Text);
                    cmd.Parameters.AddWithValue("@nam", quantityField.Text);
                    // SqlCommand cmd = new SqlCommand(query, con
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" SAVED SUCCESSFULLY FOOD QUANTITY");
                    this.Clear();

                    populateData1();
                } }
            else
            {
                MessageBox.Show("INVALILD SAVE FORMAT");
            }
        }
        private Boolean checkEmail()
        {
            Boolean idAvailable = false;
            // SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-OKS5T8F\\SQLEXPRESS;Initial Catalog=LAB1;Integrated Security=True");
            con.Open();
            String myquery = "Select * from PR_FOOD_ITEMS1 where FOOD_NAME ='" + foodField.Text + "'";
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                idAvailable = true;
            }
            con.Close();
            return idAvailable;
        }

        void Clear()
        {
            quantityField.Text=foodField.Text= "";
        }
        private void saveButton_Click(object sender, EventArgs e)
        {      
            Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            con.Open();
            //Setting the command
            SqlCommand sc = new SqlCommand("SELECT SUM(QUANTITY) AS TotalCount FROM dbo.ORDER_FOOD1 WHERE ORDER_ID='"+id2Field.Text+"' ", con);
            //Creating object of reader
            SqlDataReader reader;
            //Executing the reader
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                //Get the Sum of Column from Database
                itemField.Text = reader["TotalCount"].ToString();
            }
            con.Close();
        }

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            con.Open();
            //Setting the command
            SqlCommand sc = new SqlCommand("SELECT SUM(PRICES*(ORDER_FOOD1.QUANTITY)) AS TotalCount FROM dbo.PR_FOOD_ITEMS1 INNER JOIN ORDER_FOOD1 ON ORDER_FOOD1.FOOD_ID=PR_FOOD_ITEMS1.FOOD_ID WHERE ORDER_FOOD1.ORDER_ID='"+id2Field.Text+"'", con);
            //Creating object of reader
            SqlDataReader reader;
            //Executing the reader
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                //Get the Sum of Column from Database
                priceField.Text = reader["TotalCount"].ToString();
            }
            reader.Close();
            SqlCommand cmd = new SqlCommand("UPDATE PR_ORdER1 SET PRICE='"+priceField.Text+"' WHERE ORDER_ID='"+id2Field.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
