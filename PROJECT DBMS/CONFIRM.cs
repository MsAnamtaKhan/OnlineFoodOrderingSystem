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
    public partial class CONFIRM : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        string customer,order,price;
        public CONFIRM(string c,string o,string p)
        {
            InitializeComponent();
            customer = c;
            order = o;
            price = p;
      
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {


            if (checkId())
            {

                if (cellField.Text != "")

                {
                    if (isValidCity(cityField.Text) && isvalidAddress(areaField.Text) && isValidPhone(phoneField.Text) && checkQuantity(quantityField.Text) && isValidPhone(cellField.Text))
                    {

                        con.Open();

                        string query1 = "UPDATE PR_ORDER1 SET QUANTITY='" + quantityField.Text + "',ORDER_DATE='" + dateTimePicker1.Text + "',STATUSES=@st WHERE ORDER_ID='" + order + "' AND CUTOMER_ID='" + customer + "'";
                        string query = "insert into PR_ORDERS_COMPOSITE(ID,CITY,AREA) values(@id,@city,@area) ";


                        SqlCommand cmd = new SqlCommand(query1, con);
                        cmd.Parameters.AddWithValue("@st", "NOT DELIVERED");
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd1 = new SqlCommand(query, con);

                        cmd1.Parameters.AddWithValue("@id", order);

                        cmd1.Parameters.AddWithValue("@city", cityField.Text);
                        cmd1.Parameters.AddWithValue("@area", areaField.Text);
                        cmd1.ExecuteNonQuery();

                        string query2 = "insert into PR_ORDERS_MULTIVALUES(ORDER_ID,PHONE_NO)  " + "values(@id2,@phone)";
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@id2", order);
                        cmd2.Parameters.AddWithValue("@phone", phoneField.Text);
                        cmd2.ExecuteNonQuery();

                        string query4 = "insert into PR_ORDERS_MULTIVALUES(ORDER_ID,PHONE_NO)  " + "values(@id2,@phone)";
                                SqlCommand cmd4 = new SqlCommand(query4, con);
                                cmd4.Parameters.AddWithValue("@id2", order);
                                cmd4.Parameters.AddWithValue("@phone", cellField.Text);
                                cmd4.ExecuteNonQuery();
                          
                        string query3 = "insert into PR_PAYMENTS (PAYMENT_TYPE,ID,ORDER_ID,PRICE)  " + "values(@type,@cus,@order,@price)";

                        SqlCommand cmd3 = new SqlCommand(query3, con);


                        // cmd3.Parameters.AddWithValue("@id3", payField.Text);
                        cmd3.Parameters.AddWithValue("@type", paymentBox1.Text);
                        cmd3.Parameters.AddWithValue("@cus", customer);
                        cmd3.Parameters.AddWithValue("@order", order);
                        cmd3.Parameters.AddWithValue("@price", price);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("ORDER IS CONFIRMED");

                        SqlCommand s = new SqlCommand("SELECT PR_CUSTOMERS.NAME AS TotalCount FROM dbo.PR_CUSTOMERS WHERE ID='" + customer + "'", con);

                        //Creating object of reader
                        SqlDataReader reader1;

                        reader1 = s.ExecuteReader();
                        while (reader1.Read())
                        {
                            //Get the Sum of Column from Database
                            cellField.Text = reader1["TotalCount"].ToString();
                        }


                        con.Close();
                        this.Hide();
                        Form2 f2 = new Form2(cellField.Text);
                        f2.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("INVALID DATTA FORMAT");
                    }
                }
                else
                {
                    if (isValidCity(cityField.Text) && isvalidAddress(areaField.Text) && isValidPhone(phoneField.Text) && checkQuantity(quantityField.Text) )
                    {

                        con.Open();

                        string query1 = "UPDATE PR_ORDER1 SET QUANTITY='" + quantityField.Text + "',ORDER_DATE='" + dateTimePicker1.Text + "',STATUSES=@st WHERE ORDER_ID='" + order + "' AND CUTOMER_ID='" + customer + "'";
                        string query = "insert into PR_ORDERS_COMPOSITE(ID,CITY,AREA) values(@id,@city,@area) ";


                        SqlCommand cmd = new SqlCommand(query1, con);
                        cmd.Parameters.AddWithValue("@st", "NOT DELIVERED");
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd1 = new SqlCommand(query, con);

                        cmd1.Parameters.AddWithValue("@id", order);

                        cmd1.Parameters.AddWithValue("@city", cityField.Text);
                        cmd1.Parameters.AddWithValue("@area", areaField.Text);
                        cmd1.ExecuteNonQuery();

                        string query2 = "insert into PR_ORDERS_MULTIVALUES(ORDER_ID,PHONE_NO)  " + "values(@id2,@phone)";
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@id2", order);
                        cmd2.Parameters.AddWithValue("@phone", phoneField.Text);
                        cmd2.ExecuteNonQuery();
                        

                        string query3 = "insert into PR_PAYMENTS (PAYMENT_TYPE,ID,ORDER_ID,PRICE)  " + "values(@type,@cus,@order,@price)";

                        SqlCommand cmd3 = new SqlCommand(query3, con);


                        // cmd3.Parameters.AddWithValue("@id3", payField.Text);
                        cmd3.Parameters.AddWithValue("@type", paymentBox1.Text);
                        cmd3.Parameters.AddWithValue("@cus", customer);
                        cmd3.Parameters.AddWithValue("@order", order);
                        cmd3.Parameters.AddWithValue("@price", price);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("ORDER IS CONFIRMED");

                        SqlCommand s = new SqlCommand("SELECT PR_CUSTOMERS.NAME AS TotalCount FROM dbo.PR_CUSTOMERS WHERE ID='" + customer + "'", con);

                        //Creating object of reader
                        SqlDataReader reader1;

                        reader1 = s.ExecuteReader();
                        while (reader1.Read())
                        {
                            //Get the Sum of Column from Database
                            cellField.Text = reader1["TotalCount"].ToString();
                        }


                        con.Close();
                        this.Hide();
                        Form2 f2 = new Form2(cellField.Text);
                        f2.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("INVALID DATTA FORMAT");
                    }

                }
            }
            else
            {
                MessageBox.Show("INVALID CUSTOMER ID");
                this.Hide();
                Form2 f2 = new Form2(cellField.Text);
                f2.ShowDialog();
            }

        }

        private Boolean checkId()
        {
            Boolean idAvailable = false;
            // SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-OKS5T8F\\SQLEXPRESS;Initial Catalog=LAB1;Integrated Security=True");
            con.Open();
            String myquery = "Select * from PR_CUSTOMERS where ID ='" + customer + "'";
            //SqlConnection con = new SqlConnection(mycon);
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
           CUS_LOGIN f2 = new CUS_LOGIN(customer);
            f2.ShowDialog();
        }

        private void CONFIRM_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool isvalidAddress(string n)
        {
            Regex check = new Regex(@"^[#.0-9a-zA-Z\s,-]+$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;
        }
        private bool isValidCity(string n)
        {
            Regex check = new Regex(@"([A-Z][a-z-A-z]+)$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;

        }
        private bool checkQuantity(string n)
        {
            Regex check = new Regex(@"^[0-9]+$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;

        }

        private bool isValidPhone(string n)
        {

            Regex check = new Regex(@"^[0-9]{11}$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;

        }
        private void addressField_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
