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
    public partial class DELIVERYMEN_SIGNUP : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        public DELIVERYMEN_SIGNUP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void againPasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnicField_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_data_into_data_base()
        {


          
            con.Open();

            //  cmd.Parameters.AddWithValue("@admin", SCOPE_IDENTITY());
            //Setting the command
            SqlCommand sc = new SqlCommand("SELECT PR_DELIVERYMEN.ID AS TotalCount FROM dbo.PR_DELIVERYMEN ", con);
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
            string query1 = "insert into PR_DELIVERYMEN_COMPOSITE(ID,CITY,AREA)  " + "values(@id,@city,@area)";

            SqlCommand cmd5 = new SqlCommand(query1, con);
            cmd5.Parameters.AddWithValue("@id", idField.Text);
       
            cmd5.Parameters.AddWithValue("@city", cityField.Text);
            cmd5.Parameters.AddWithValue("@area", areaField.Text);

            cmd5.ExecuteNonQuery();
            string q21 = "insert into PR_DELIVERYMEN_MULTIVALUES(Id,PHONE_NO)  " + "values(@id1,@PHONE)";

            SqlCommand cmd8 = new SqlCommand(q21, con);
            cmd8.Parameters.AddWithValue("@id1", idField.Text);
            cmd8.Parameters.AddWithValue("@PHONE", phoneField.Text);
            cmd8.ExecuteNonQuery();

            if (cellField.Text != "")
            {

                string q31 = "insert into PR_DELIVERYMEN_MULTIVALUES(ID,PHONE_NO)  " + "values(@id2,@PHONE)";

                SqlCommand cmd11 = new SqlCommand(q31, con);
                cmd11.Parameters.AddWithValue("@id2", idField.Text);
                cmd11.Parameters.AddWithValue("@PHONE", cellField.Text);
                cmd11.ExecuteNonQuery();

            }


            MessageBox.Show(" ADD DELIVERYMEN SUCCESSFULLY");

            con.Close();
            this.Hide();
            DELIVERYMEN f2 = new DELIVERYMEN();
            f2.ShowDialog();



        }

        private void insert_data()
        {
            if (cellField.Text != "")

            {
                if (isValidMail(emailField.Text) && isValidName(usernameField.Text) && isValidPassword(passwordField.Text) && isValidPassword(againPasswordField.Text) && isvalidAddress(areaField.Text) && isValidCity(cityField.Text) && isValidPhone(phoneField.Text) && isValidPhone(cellField.Text))

                {
                    if (passwordField.Text == againPasswordField.Text)
                    {
                        con.Open();
                        string query = "insert into PR_DELIVERYMEN(ADMIN_ID,NAME,PASSWORDS,EMAIL) values(@id,@name,@pass,@email)";

                        SqlCommand cmd2 = new SqlCommand(query, con);
                        cmd2.Parameters.AddWithValue("@id", 1);
                        cmd2.Parameters.AddWithValue("@pass", passwordField.Text);
                        cmd2.Parameters.AddWithValue("@email", emailField.Text);
                        cmd2.Parameters.AddWithValue("@name", usernameField.Text);

                        cmd2.ExecuteNonQuery();
                        con.Close();
                        save_data_into_data_base();
                      
                    }
                    else
                    {
                        MessageBox.Show("PASSWORDS ARE NOT SAME");
                        
                    }

                   
                }
                else
                {
                    MessageBox.Show("INVALID ADD DELIVERYMEN CREDENTIALS FORMAT");
                }
            }

            else
            {
                if (isValidMail(emailField.Text) && isValidName(usernameField.Text) && isValidPassword(passwordField.Text) && isValidPassword(againPasswordField.Text) && isvalidAddress(areaField.Text) && isValidCity(cityField.Text) && isValidPhone(phoneField.Text))

                {
                    if (passwordField.Text == againPasswordField.Text)
                    {
                        con.Open();
                        string query = "insert into PR_DELIVERYMEN(ADMIN_ID,NAME,PASSWORDS,EMAIL) values(@id,@name,@pass,@email)";

                        SqlCommand cmd2 = new SqlCommand(query, con);
                        cmd2.Parameters.AddWithValue("@id", 1);
                        cmd2.Parameters.AddWithValue("@pass", passwordField.Text);
                        cmd2.Parameters.AddWithValue("@email", emailField.Text);
                        cmd2.Parameters.AddWithValue("@name", usernameField.Text);

                        cmd2.ExecuteNonQuery();
                        con.Close();
                        save_data_into_data_base();
                        
                    }
                    else
                    {
                        MessageBox.Show("PASSWORDS ARE NOT SAME");
                       
                    }

                  
                }
                else
                {
                    MessageBox.Show("INVALID ADD DELIVERYMEN CREDENTIALS FORMAT");
                }

            }
        }
       
      
        void Clear()
        {
            usernameField.Text = passwordField.Text = againPasswordField.Text=cityField.Text=areaField.Text=phoneField.Text=cellField.Text = emailField.Text = "";
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
               insert_data();
         //   save_data_into_data_base();
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
        private bool isValidPhone(string n)
        {

            Regex check = new Regex(@"^[0-9]{11}$");
            bool isValid = false;
            isValid = check.IsMatch(n);
            return isValid;

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            DELIVERYMEN f2 = new DELIVERYMEN();
            f2.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DELIVERYMEN_SIGNUP_Load(object sender, EventArgs e)
        {

        }
    }
}
