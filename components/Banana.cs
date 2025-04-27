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
    public partial class Banana : UserControl {
        public Banana() {
            InitializeComponent();
            this.Click += new EventHandler(BananaClicked);
        }

        private void BananaClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;
            productList.AddProduct("Banana", 80, 1);

            MainFormd mainForm = (MainFormd)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Banana", 80, 1);
            }
        }
    }
}
