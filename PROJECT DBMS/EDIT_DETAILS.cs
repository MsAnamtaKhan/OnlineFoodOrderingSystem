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
    public partial class EDIT_DETAILS : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");
     
        string m;
        public EDIT_DETAILS(string value)
        {
            InitializeComponent();
            m = value;
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

        private void confirmButton_Click(object sender, EventArgs e)
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



            if (isvalidAddress(areaField.Text) && isValidCity(cityField.Text) && paymentBox.Text != "")

            {

                string query = "UPDATE PR_ORDERS_COMPOSITE SET CITY='" + cityField.Text + "',AREA='" + areaField.Text + "'  FROM PR_ORDERS_COMPOSITE INNER JOIN PR_ORDER1 ON  PR_ORDERS_COMPOSITE.ID = PR_ORDER1.ORDER_ID WHERE PR_ORDER1.CUTOMER_ID ='" + idField.Text + "'";



                SqlCommand cmd1 = new SqlCommand(query, con);
                cmd1.ExecuteNonQuery();




                string query3 = "UPDATE PR_PAYMENTS SET PAYMENT_TYPE='" + paymentBox.Text + "' FROM PR_PAYMENTS INNER JOIN PR_ORDER1 ON PR_ORDER1.ORDER_ID=PR_PAYMENTS.ORDER_ID WHERE PR_ORDER1.CUTOMER_ID='" + idField.Text + "'";

                SqlCommand cmd52 = new SqlCommand(query3, con);
                cmd52.ExecuteNonQuery();
                MessageBox.Show("UPDATED SUCCESSFULLY");
                con.Close();
                this.Hide();
                Form2 f2 = new Form2(m);
                f2.ShowDialog();

            }
            else
            {
                MessageBox.Show("INVALID FORMAT");
            }
         
     
            con.Close();
        }

      

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void EDIT_DETAILS_Load(object sender, EventArgs e)
        {

        }

        private void paymentField_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void areaField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
