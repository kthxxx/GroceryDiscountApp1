using System;
using System.Windows.Forms;
using GroceryDiscountApp.models;
using GroceryDiscountApp.interfaces;

namespace GroceryDiscountApp.components
{
    public partial class Apple : UserControl
    {
        public Apple()
        {
            InitializeComponent();
            this.Click += new EventHandler(AppleClicked); // Ensure the click event is subscribed
        }

        private void AppleClicked(object? sender, EventArgs e)
        {
            Products productList = Products.Instance;
            productList.AddProduct("Apple", 30, 1);

            // Assuming MainFormd is the main form
            MainFormd? mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Apple", 30, 1);
            }
        }

        private void Apple_Load(object sender, EventArgs e)
        {

        }
    }
}
