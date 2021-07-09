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
    public partial class CUSTOME_SIGNUP : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        public CUSTOME_SIGNUP()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_data_into_data_base()
        {


           
                if(isValidMail(emailField.Text) && isValidName(usernameField.Text) && isValidPassword(passwordField.Text) && isValidPassword(againPasswordField.Text))

                {
                if (passwordField.Text == againPasswordField.Text)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-OKS5T8F\\SQLEXPRESS;Initial Catalog=LAB1;Integrated Security=True");
                    con.Open();
                    string query = "insert into PR_CUSTOMERS(PASSWORDS,EMAIL,NAME)  " + "values(@pass,@email,@name)";
                    SqlCommand cmd = new SqlCommand(query, con);


                    cmd.Parameters.AddWithValue("@pass", passwordField.Text);
                    cmd.Parameters.AddWithValue("@email", emailField.Text);
                    cmd.Parameters.AddWithValue("@name", usernameField.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" REGISTERED SUCCESSFULLY AS CUSTOMER");
                    this.Clear();
                    con.Close();
                    this.Hide();
                    CUSTOMER f2 = new CUSTOMER();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("PASSWORD AND AGAIN PASSWORD ARE NOT SAME");
                }

                }
                else
                {
                MessageBox.Show("INVALID REGISTER FORMAT");
                }
            
        }


        private Boolean checkId()
        {
            Boolean idAvailable = false;
            // SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-OKS5T8F\\SQLEXPRESS;Initial Catalog=LAB1;Integrated Security=True");
            con.Open();
            String myquery = "Select * from PR_CUSTOMERS where NAME ='"+usernameField.Text+"'";
            //SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection =con;
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
            usernameField.Text = passwordField.Text=againPasswordField.Text = emailField.Text = "";
        }
        private void signupButton_Click(object sender, EventArgs e)
        {
            save_data_into_data_base();
           
        }

        private bool isValidName(string n)
        {
            Regex check = new Regex(@"([A-Z][a-z-A-z]+)$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;
        }

        private bool isValidPassword(string n)
        {
            Regex check = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,10})$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;
        }
        private bool isValidMail(string n)
        {
            Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUSTOMER f2 = new CUSTOMER();
            f2.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cnicField_TextChanged(object sender, EventArgs e)
        {

        }

        private void againPasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void emailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CUSTOME_SIGNUP_Load(object sender, EventArgs e)
        {

        }
    }
}
