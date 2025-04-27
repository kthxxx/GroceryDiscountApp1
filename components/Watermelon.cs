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
    public partial class Watermelon : UserControl {
        public Watermelon() {
            InitializeComponent();
            this.Click += new EventHandler(WatermelonClicked);
        }

        private void WatermelonClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;
            productList.AddProduct("Watermelon", 185, 1);

            MainFormd mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Watermelon", 185, 1);
            }
        }
    }
}
