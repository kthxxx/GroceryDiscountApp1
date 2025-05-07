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
    public partial class Welcom : Form
    {
        public Welcom()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PantryPal_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Aboutus aboutus = new Aboutus();
            aboutus.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormd mainForm = new MainFormd();
            mainForm.Show();
            this.Hide();
        }

        private void LblContactus_Click(object sender, EventArgs e)
        {
            Contactus contactus = new Contactus();
            contactus.Show();
            this.Hide();
        }
    }
}
