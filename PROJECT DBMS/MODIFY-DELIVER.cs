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
    public partial class MODIFY_DELIVER : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");


        public MODIFY_DELIVER()
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
            String myquery = "Select * from PR_DELIVERYMEN where ID ='" + delField.Text + "'";
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

        void Clear()
        {
            phoneField.Text=areaField.Text= usernameField.Text=emailField.Text =againPasswordField.Text=cellField.Text=passwordField.Text= "";
        }
        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (cellField.Text != "")

            {
                if (isvalidAddress(areaField.Text) && isValidCity(cityField.Text) && isValidName(usernameField.Text) && isValidPassword(passwordField.Text) && isValidPassword(againPasswordField.Text) && isValidMail(emailField.Text) && isValidPhone(phoneField.Text) && isValidPhone(cellField.Text))
                {
                    if (!checkId())
                    {
                        MessageBox.Show("DELIVERYMEN TO BE UPDATED DOES NOT EXIST");
                        // populateData();
                    }
                    else
                    {
                        if (passwordField.Text == againPasswordField.Text)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE PR_DELIVERYMEN SET NAME=@name,PASSWORDS=@pass,EMAIL=@email WHERE ID=@id", con);
                            SqlCommand cmd1 = new SqlCommand("UPDATE PR_DELIVERYMEN_COMPOSITE SET CITY=@city,AREA=@area WHERE ID=@id1", con);
                            SqlCommand cmd2 = new SqlCommand("delete from PR_DELIVERYMEN_MULTIVALUES where ID=@n2 ", con);
                            cmd2.Parameters.AddWithValue("@n2", delField.Text);
                            cmd2.ExecuteNonQuery();
                            string q21 = "insert into PR_DELIVERYMEN_MULTIVALUES(Id,PHONE_NO)  " + "values(@id1,@PHONE)";

                            SqlCommand cmd8 = new SqlCommand(q21, con);
                            cmd8.Parameters.AddWithValue("@id1", delField.Text);
                            cmd8.Parameters.AddWithValue("@PHONE", phoneField.Text);
                            cmd8.ExecuteNonQuery();
                            if (cellField.Text != "")
                            {

                                string q31 = "insert into PR_DELIVERYMEN_MULTIVALUES(ID,PHONE_NO)  " + "values(@id2,@PHONE)";

                                SqlCommand cmd11 = new SqlCommand(q31, con);
                                cmd11.Parameters.AddWithValue("@id2", delField.Text);
                                cmd11.Parameters.AddWithValue("@PHONE", cellField.Text);
                                cmd11.ExecuteNonQuery();

                            }
                            cmd.Parameters.AddWithValue("@id", delField.Text);
                            //                  cmd.Parameters.AddWithValue("@admin", adminField.Text);
                            cmd.Parameters.AddWithValue("@name", usernameField.Text);
                            cmd.Parameters.AddWithValue("@pass", passwordField.Text);
                            cmd.Parameters.AddWithValue("@email", emailField.Text);

                            cmd1.Parameters.AddWithValue("@id1", delField.Text);
                            // cmd1.Parameters.AddWithValue("@add", addressField.Text);
                            cmd1.Parameters.AddWithValue("@city", cityField.Text);
                            cmd1.Parameters.AddWithValue("@area", areaField.Text);
                            //              cmd2.Parameters.AddWithValue("@id", cnicField.Text);

                            cmd.ExecuteNonQuery();
                            cmd1.ExecuteNonQuery();

                            MessageBox.Show("UPDATED DELIVERYMEN SUCCESSFULLY");
                            con.Close();
                            this.Hide();
                            ADMIN_DELIVER f2 = new ADMIN_DELIVER();
                            f2.ShowDialog();
                            //  populateData();
                        }
                        else
                        {
                            MessageBox.Show("PASSWORDS ARE NOT SAME");
                        }
                    }
                }
            
            else
            {
                MessageBox.Show("INVALID UPDATE DELIVERYMEN  CREDENTIALS FORMAT");


            }                
            }
            else
            {

                if (isvalidAddress(areaField.Text) && isValidCity(cityField.Text) && isValidName(usernameField.Text) && isValidPassword(passwordField.Text) && isValidPassword(againPasswordField.Text) && isValidMail(emailField.Text) && isValidPhone(phoneField.Text) )
                {
                    if (!checkId())
                    {
                        
                        MessageBox.Show("DELIVERYMEN TO BE UPDATED DOES NOT EXIST");
                        // populateData();
                    }
                    else
                    {
                        if (passwordField.Text == againPasswordField.Text)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE PR_DELIVERYMEN SET NAME=@name,PASSWORDS=@pass,EMAIL=@email WHERE ID=@id", con);
                            SqlCommand cmd1 = new SqlCommand("UPDATE PR_DELIVERYMEN_COMPOSITE SET CITY=@city,AREA=@area WHERE ID=@id1", con);
                            SqlCommand cmd2 = new SqlCommand("delete from PR_DELIVERYMEN_MULTIVALUES where ID=@n2 ", con);
                            cmd2.Parameters.AddWithValue("@n2", delField.Text);
                            cmd2.ExecuteNonQuery();
                            string q21 = "insert into PR_DELIVERYMEN_MULTIVALUES(Id,PHONE_NO)  " + "values(@id1,@PHONE)";

                            SqlCommand cmd8 = new SqlCommand(q21, con);
                            cmd8.Parameters.AddWithValue("@id1", delField.Text);
                            cmd8.Parameters.AddWithValue("@PHONE", phoneField.Text);
                            cmd8.ExecuteNonQuery();
                           
                            
                            cmd.Parameters.AddWithValue("@id", delField.Text);
                            //                  cmd.Parameters.AddWithValue("@admin", adminField.Text);
                            cmd.Parameters.AddWithValue("@name", usernameField.Text);
                            cmd.Parameters.AddWithValue("@pass", passwordField.Text);
                            cmd.Parameters.AddWithValue("@email", emailField.Text);

                            cmd1.Parameters.AddWithValue("@id1", delField.Text);
                            // cmd1.Parameters.AddWithValue("@add", addressField.Text);
                            cmd1.Parameters.AddWithValue("@city", cityField.Text);
                            cmd1.Parameters.AddWithValue("@area", areaField.Text);
                            //              cmd2.Parameters.AddWithValue("@id", cnicField.Text);

                            cmd.ExecuteNonQuery();
                            cmd1.ExecuteNonQuery();

                            MessageBox.Show("UPDATED DELIVERYMEN SUCCESSFULLY");
                            con.Close();
                            this.Hide();
                            ADMIN_DELIVER f2 = new ADMIN_DELIVER();
                            f2.ShowDialog();
                            //  populateData();
                        }
                        else
                        {
                            MessageBox.Show("PASSWORDS ARE NOT SAME");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("INVALID UPDATE DELIVERYMEN  CREDENTIALS FORMAT");


                }

            }
        }

        private void MODIFY_DELIVER_Load(object sender, EventArgs e)
        {

        }
    }
}

    
  