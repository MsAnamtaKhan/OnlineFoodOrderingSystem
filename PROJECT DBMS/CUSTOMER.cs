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
    public partial class CUSTOMER : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");
        public string MyValue
        {
            get { return usernameField.Text; }
        }
        public CUSTOMER()
        {
            InitializeComponent();
        }
      
        private void signupButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICKED SIGNNP");
            label5.Text = "CLICKED SIGNUP";
            this.Hide();
            CUSTOME_SIGNUP f2 = new CUSTOME_SIGNUP();
            f2.ShowDialog();
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }
        private void CUSTOMER_LOGIN()
        {
            if (usernameField.Text != "" || passwordField.Text != "")
            {
                string user = usernameField.Text;
                string pass = passwordField.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand(" Select * From PR_CUSTOMERS where NAME=@uName and PASSWORDS=@pass", con);
                cmd.Parameters.AddWithValue("@uName", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sd.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                   // this.Clear();
                    MessageBox.Show("YOU SUCCESSFULLY LOGGED INTO FOOD ORDERONG SYSTEM AS USER");
                    this.Hide();
                    
                    CUS_LOGIN f2 = new CUS_LOGIN(usernameField.Text);
                    f2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("INVALID USERNAME AND PASSWORD");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME AND PASSWORD");
            }

        }
        void Clear()
        {
            usernameField.Text = passwordField.Text = "";
        }
        private void loginButton_Click(object sender, EventArgs e)
        {

            if (usernameField.Text != "" || passwordField.Text != "")
            {
                string user = usernameField.Text;
                string pass = passwordField.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand(" Select * From PR_CUSTOMERS where NAME=@uName and PASSWORDS=@pass", con);
                cmd.Parameters.AddWithValue("@uName", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sd.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    // this.Clear();
                    MessageBox.Show("YOU SUCCESSFULLY LOGGED INTO FOOD ORDERONG SYSTEM AS USER");
                    this.Hide();

                    Form2 f2 = new Form2(usernameField.Text);
                    f2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("INVALID USERNAME AND PASSWORD");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME AND PASSWORD");
            }
        }

        private void CUSTOMER_Load(object sender, EventArgs e)
        {

        }
    }
}
