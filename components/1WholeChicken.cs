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
    public partial class _1WholeChicken : UserControl {
        public _1WholeChicken() {
            InitializeComponent();
            this.Click += new EventHandler(WholeChickenClicked);
        }


        private void WholeChickenClicked(object sender, EventArgs e)
        {
            Products productList = Products.Instance;
            productList.AddProduct("Whole Chicken", 230, 1);

            MainFormd? mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Whole Chicken", 230, 1);
            }
        }
    }
}
