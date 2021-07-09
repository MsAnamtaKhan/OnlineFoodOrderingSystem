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
    public partial class DELETE_ITEM : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        public DELETE_ITEM()
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
            String myquery = "Select * from PR_FOOD_ITEMS1 where FOOD_ID ='" + idField.Text + "'";
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


        private bool checkQuantity(string n)
        {
            Regex check = new Regex(@"^[0-9]+$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;

        }
        void Clear()
        {
            idField.Text= "";
        }
        private void delete_data_from_database()
        {

            


            if (checkQuantity(idField.Text))
            {
                if (!checkId())
                {
                    MessageBox.Show("ITEM DOES NOT EXIS");

                }


                else
                {
                    con.Open();

                    SqlCommand cmd1= new SqlCommand("UPDATE ORDER_FOOD1 SET FOOD_ID=NULL WHERE FOOD_ID=@n1", con);
                    cmd1.Parameters.AddWithValue("@n1", idField.Text);

                    cmd1.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("delete from PR_FOOD_ITEMS1 where FOOD_ID=@n ", con);
                    cmd.Parameters.AddWithValue("@n", idField.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ITEM DELETED");
                    con.Close();
                    this.Clear();
                    this.Hide();
                    ADMIN_LOGIN f2 = new ADMIN_LOGIN();
                    f2.ShowDialog();
                    //populateData();

                }
            }

            else
            {
                MessageBox.Show("INVALID DELETE  CREDENTIALS FORMAT");
              
            }


        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete_data_from_database();
        }

        private void DELETE_ITEM_Load(object sender, EventArgs e)
        {

        }
    }
}
