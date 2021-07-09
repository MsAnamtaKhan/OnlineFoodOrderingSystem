using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_DBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
           
            Console.WriteLine("CLICKED ADMIN");
            label2.Text = "CLICKED ADMIN";
            this.Hide();
            ADMIN f2=new ADMIN();
            f2.ShowDialog();
        }

        private void EXITBUTTON_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICKED EXIT");
            label2.Text = "CLICKED EXIT";
            this.Close();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
           
            Console.WriteLine("CLICKED CUSTOMER");
            label2.Text = "CLICKED CUSTOMER";
            this.Hide();
            CUSTOMER f2 = new CUSTOMER();
            f2.ShowDialog();
        }

        private void deliverymenButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICKED DELIVERYMEN");
            label2.Text = "CLICKED DELIVERYMEN";
            this.Hide();
            DELIVERYMEN f2 = new DELIVERYMEN();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
