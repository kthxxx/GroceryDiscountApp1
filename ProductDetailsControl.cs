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
    public partial class ProductDetailsControl : UserControl
    {
        public ProductDetailsControl()
        {
            InitializeComponent();
        }

        public void SetProductDetails(string productName, decimal price, int quantity)
        {
            lblProductName.Text = productName;
            lblProductPrice.Text = $" {price:C}";
            lblProductQuantity.Text = $"{quantity}";
        }
        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            int currentQuantity = int.Parse(lblProductQuantity.Text);
            int newQuantity = currentQuantity + 1;
            UpdateQuantity(newQuantity);
        }



        private void btnRemoveQuatity_Click(object sender, EventArgs e)
        {
            int currentQuantity = int.Parse(lblProductQuantity.Text);
            int newQuantity = currentQuantity - 1;

            if (newQuantity > 0)
            {
                UpdateQuantity(newQuantity);
            }
            else
            {
                // Assuming the parent control is the CartPanel
                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                }
                // Optionally, you can also remove it from the productDetailsMap in the MainFormd
                MainFormd? mainForm = Application.OpenForms["MainFormd"] as MainFormd;
                if (mainForm != null)
                {   
                    mainForm.RemoveProductFromCart(lblProductName.Text);
                }
            }
        }




        public void UpdateQuantity(int quantity)
        {
            lblProductQuantity.Text = quantity.ToString();
        }

        private void lblProductPrice_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetailsControl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblProductQuantity_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        //public void UpdatePrice(decimal price)
        //{
        //    lblProductPrice.Text = $" {price:C}";
        //}







    }
}
