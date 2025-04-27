using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryDiscountApp.models;

namespace GroceryDiscountApp.interfaces
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }


        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            MainFormd? mainForm = Application.OpenForms.OfType<MainFormd>().FirstOrDefault();

            Receipt? receiptForm = Application.OpenForms.OfType<Receipt>().FirstOrDefault();
            if (receiptForm != null)
            {
                receiptForm.Close();
            }

            // Check if mainForm is null before proceeding
            if (mainForm == null)
            {
                MessageBox.Show("Main form not found!");
                return;
            }

            // Get the receipt details
            List<Product> products = Products.Instance.ProductList;
            decimal subtotal = mainForm.CalculateSubtotal();
            decimal discount = subtotal - (decimal)Products.Instance.GetDiscountedPrice();
            decimal total = (decimal)Products.Instance.GetDiscountedPrice();


            // Show the FinalReceipt form
            FinalReceipt finalReceiptForm = new FinalReceipt(products, subtotal, discount, total);
            finalReceiptForm.ShowDialog(); // Using ShowDialog to keep it open

            mainForm.BringToFront();
            this.Close();
        }








    }
}
