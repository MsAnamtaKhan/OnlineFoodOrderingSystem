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
    public partial class ADMIN : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-OKS5T8F\\SQLEXPRESS; Initial Catalog = LAB1; Integrated Security = True");
   
        public ADMIN()
        {
            InitializeComponent();
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
         
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }
        private void ADMIN_LOGIN()
        {
            if (usernameField.Text != "" || passwordField.Text != "")
            {
                string user = usernameField.Text;
                string pass = passwordField.Text;

                con.Open();
                SqlCommand cmd = new SqlCommand(" Select * From PR_ADMIN where USERNAME=@uName and PASSWORDS=@pass", con);
                cmd.Parameters.AddWithValue("@uName", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sd.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Clear();
                    MessageBox.Show("YOU SUCCESSFULLY LOGGED INTO FOOD ORDERONG SYSTEM AS ADMIN");
                    this.Hide();
                    ADMIN_LOGIN f2 = new ADMIN_LOGIN();
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
        private void loginButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICKED LOGIN");
            label5.Text = "CLICKED LOGIN";
            ADMIN_LOGIN();
          
           
        }
        void Clear()
        {
            usernameField.Text = passwordField.Text = "";
        }

        private void EXITBUTTON_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICKED EXIT");
            label5.Text = "CLICKED EXIT";
            this.Close();
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ADMIN_LOGIN();

        }
    }
}
