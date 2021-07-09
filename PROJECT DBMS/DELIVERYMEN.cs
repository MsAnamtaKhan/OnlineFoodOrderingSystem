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
    public partial class DELIVERYMEN : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");

        public DELIVERYMEN()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DELIVERYMEN_SIGNUP f2 = new DELIVERYMEN_SIGNUP();
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

        private void LOGIN()
        {
            if (usernameField.Text != "" || passwordField.Text != "")
            {
                string user = usernameField.Text;
                string pass = passwordField.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand(" Select * From PR_DELIVERYMEN where NAME=@uName and PASSWORDS=@pass", con);
                cmd.Parameters.AddWithValue("@uName", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sd.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Clear();
                    MessageBox.Show("YOU SUCCESSFULLY LOGGED INTO FOOD ORDERONG SYSTEM AS DELIVERYMEN");
                    this.Hide();
                    DELIVERYMEN_LOGIN f2 = new DELIVERYMEN_LOGIN(pass);
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
            LOGIN();
        }

        private void DELIVERYMEN_Load(object sender, EventArgs e)
        {

        }
    }
}
