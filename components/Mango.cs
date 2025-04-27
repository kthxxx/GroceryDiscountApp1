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
    public partial class Mango : UserControl {
        public Mango() {
            InitializeComponent();
            this.Click += new EventHandler(MangoClicked);
        }

        private void MangoClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;
            productList.AddProduct("Mango", 130, 1);

            MainFormd mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Mango", 130, 1);
            }
        }
    }
}
