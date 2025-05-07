using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryDiscountApp
{
    public partial class Aboutus : Form
    {
        public Aboutus()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PantryPal_Click(object sender, EventArgs e)
        {
            Welcom welcom = new Welcom();
            welcom.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Contactus contactus = new Contactus();
            contactus.Show();
            this.Hide();

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Welcom welcom = new Welcom();
            welcom.Show();
            this.Hide();
        }
    }
}
