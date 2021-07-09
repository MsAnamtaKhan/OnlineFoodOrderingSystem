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
    public partial class Form2 : Form
    {
        string m;
        public Form2(string value)
        {
            InitializeComponent();
            m = value;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUS_LOGIN f2 = new CUS_LOGIN(m);
            f2.ShowDialog();

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ORDER_ALL f2 = new ORDER_ALL(m);
            f2.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EDIT_DETAILS f2 = new EDIT_DETAILS(m);
            f2.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CUSTOMER f2 = new CUSTOMER();
            f2.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
