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
    public partial class ADD_ITEM : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        private void addButton_Click(object sender, EventArgs e)
        {
            save_data_into_data_base();
        }
        public ADD_ITEM()
        {
            InitializeComponent();
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
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_LOGIN f2 = new ADMIN_LOGIN();
            f2.ShowDialog();
        }
        private void save_data_into_data_base()
        {

        
                if(isValidName(itemNameField.Text) && checkQuantity(itemPriceField.Text))

                {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-OKS5T8F\\SQLEXPRESS;Initial Catalog=LAB1;Integrated Security=True");
                con.Open();
                string query = "insert into PR_FOOD_ITEMS1(ADMIN_ID,FOOD_NAME,PRICES)  " + "values(@adm,@name,@prices)";
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@adm", 1);
                cmd.Parameters.AddWithValue("@name", itemNameField.Text);
                cmd.Parameters.AddWithValue("@prices", itemPriceField.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show(" ADD SUCCESSFULLY FOOD ITEMS");
                this.Clear();
                con.Close();
                this.Hide();
                ADMIN_LOGIN f2 = new ADMIN_LOGIN();
                f2.ShowDialog();
              }
                else
                {
                MessageBox.Show("INVALID ADD CREDENTIALS FORMAT");
            }
        }


        private Boolean checkId()
        {
            Boolean idAvailable = false;
            
            con.Open();
            String myquery = "Select * from PR_FOOD_ITEMS1 where FOOD_Name ='" + itemNameField.Text + "'";
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

        void Clear()
        {
            itemNameField.Text  = itemPriceField.Text = "";
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_LOGIN f2 = new ADMIN_LOGIN();
            f2.ShowDialog();
        }

        private void ADD_ITEM_Load(object sender, EventArgs e)
        {

        }
    }
}
