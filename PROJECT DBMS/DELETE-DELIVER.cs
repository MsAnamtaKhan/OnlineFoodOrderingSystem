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
    public partial class DELETE_DELIVER : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        public DELETE_DELIVER()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_DELIVER f2 = new ADMIN_DELIVER();
            f2.ShowDialog();
        }

        private Boolean checkId()
        {
            Boolean idAvailable = false;
            // SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-OKS5T8F\\SQLEXPRESS;Initial Catalog=LAB1;Integrated Security=True");
            con.Open();
            String myquery = "Select * from PR_DELIVERYMEN where ID ='" + cnicField.Text + "'";
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
            cnicField.Text = "";
        }
        private void delete_data_from_database()
        {

            if (checkQuantity(cnicField.Text))
            {
                if (!checkId())
                {
                    MessageBox.Show("DELIVERYMEN SUCH DOES NOT EXIS");

                }


                else
                {
                    con.Open();
                    string s = "";
                    SqlCommand cmd3 = new SqlCommand("  UPDATE PR_ORDER1 SET ID=NULL WHERE PR_ORDER1.ID=@n3", con);
                    cmd3.Parameters.AddWithValue("@n3", cnicField.Text);
                    cmd3.ExecuteNonQuery();


                    SqlCommand cmd = new SqlCommand("delete from PR_DELIVERYMEN where ID=@n ", con);
                   SqlCommand cmd1 = new SqlCommand("delete from PR_DELIVERYMEN_COMPOSITE where ID=@n1 ", con);
                    SqlCommand cmd2 = new SqlCommand("delete from PR_DELIVERYMEN_MULTIVALUES where ID=@n2 ", con);

                    cmd1.Parameters.AddWithValue("@n1", cnicField.Text);
                    cmd1.ExecuteNonQuery();
                    
                    cmd2.Parameters.AddWithValue("@n2", cnicField.Text);
                    cmd2.ExecuteNonQuery();

                    cmd.Parameters.AddWithValue("@n", cnicField.Text);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("SUCCESSFULLY DELIVERYMEN DELETED");
                    /* string s = "DBCC CHECKIDENT('[PR_DELIVERYMEN]',RESEED,0)";
                     SqlCommand cmd3 = new SqlCommand(s, con);
                     cmd3.ExecuteNonQuery();*/
                    con.Close();
                    this.Clear();
                    this.Hide();
                    ADMIN_DELIVER f2 = new ADMIN_DELIVER();
                    f2.ShowDialog();
                    //populateData();

                }

            }

            else
            {
                MessageBox.Show("INVALID DELETE DELIVERYMEN CREDENTIALS FORMAT ");
            }


        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete_data_from_database();
        }

        private void cnicField_TextChanged(object sender, EventArgs e)
        {

        }

        private void DELETE_DELIVER_Load(object sender, EventArgs e)
        {

        }
    }
}
