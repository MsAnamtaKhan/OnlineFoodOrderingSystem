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
    public partial class MODIFY_ITEMS : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        public MODIFY_ITEMS()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_LOGIN f2 = new ADMIN_LOGIN();
            f2.ShowDialog();
        }
        private Boolean checkId()
        {
            Boolean idAvailable = false;
            // SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-OKS5T8F\\SQLEXPRESS;Initial Catalog=LAB1;Integrated Security=True");
            con.Open();
            String myquery = "Select * from PR_FOOD_ITEMS1 where FOOD_ID='" + itemIdField.Text + "'";
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

        private bool isValidName(string n)
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
        void Clear()
        {
           itemNameField.Text=itemPriceField.Text = "";
        }
        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (isValidName(itemNameField.Text) && checkQuantity(itemPriceField.Text) && checkQuantity(itemIdField.Text))
            {
                if (!checkId())
                {
                    MessageBox.Show("ITEM TO BE UPDATED DOES NOT EXIST");
                    // populateData();
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE PR_FOOD_ITEMS1 SET FOOD_NAME=@name,PRICES=@price WHERE FOOD_ID=@id", con);
                    cmd.Parameters.AddWithValue("@id", itemIdField.Text);
                    cmd.Parameters.AddWithValue("@name", itemNameField.Text);
                    cmd.Parameters.AddWithValue("@price", itemPriceField.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATED ITEM SUCCESSFULLY");
                    con.Close();
                    this.Hide();
                    ADMIN_LOGIN f2 = new ADMIN_LOGIN();
                    f2.ShowDialog();
                    //  populateData();
                }


            }
            else
            {
                MessageBox.Show("INVALID UPDATE CREDENTIALS FORMAT");
               
            }
        }

        private void itemIdField_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MODIFY_ITEMS_Load(object sender, EventArgs e)
        {

        }
    }
}
