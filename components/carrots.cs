using System;
using System.Windows.Forms;
using GroceryDiscountApp.models;
using GroceryDiscountApp.interfaces;

namespace GroceryDiscountApp.components
{
    public partial class Carrots : UserControl
    {
        public Carrots()
        {
            InitializeComponent();
            this.Click += new EventHandler(CarrotsClicked); 
        }

        private void CarrotsClicked(object? sender, EventArgs e)
        {
            Products productList = Products.Instance;
            productList.AddProduct("Carrot", 50, 1);

            // Assuming MainFormd is the main form
            MainFormd? mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Carrot", 50, 1);
            }
        }
    }
}
