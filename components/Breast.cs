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
using GroceryDiscountApp.interfaces;

namespace GroceryDiscountApp.components
{
    public partial class Breast : UserControl
    {
        public Breast()
        {
            InitializeComponent();
            this.Click += new EventHandler(BreastClicked); // Ensure the click event is subscribed
        }

        private void BreastClicked(object? sender, EventArgs e)
        {
          
            Products productList = Products.Instance;
            productList.AddProduct("Chicken Breast", 190, 1);

            // Assuming MainFormd is the main form
            MainFormd? mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Chicken Breast", 190, 1);
            }
        }
    }
}
