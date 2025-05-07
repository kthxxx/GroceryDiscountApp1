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
    public partial class Contactus : Form
    {
        public Contactus()
        {
            InitializeComponent();
        }

        private void PantryPal_Click(object sender, EventArgs e)
        {
            Welcom welcom = new Welcom();
            welcom.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Welcom welcom = new Welcom();
            welcom.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Aboutus aboutus = new Aboutus();
            aboutus.Show();
            this.Hide();
        }
    }
}
