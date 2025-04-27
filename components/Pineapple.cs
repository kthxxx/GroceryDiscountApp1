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
    public partial class Pineapple : UserControl {
        public Pineapple() {
            InitializeComponent();
            this.Click += new EventHandler(PineappleClicked);
        }

        private void PineappleClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;
            productList.AddProduct("Pineapple", 140, 1);

            MainFormd mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Pineapple", 140, 1);
            }
        }
    }
}
