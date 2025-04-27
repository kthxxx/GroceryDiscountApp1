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
    public partial class Chickenwings : UserControl {
        public Chickenwings() {
            InitializeComponent();
            this.Click += new EventHandler(ChickenWingsClicked);
        }

        private void ChickenWingsClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;
            productList.AddProduct("Chicken Wings", 190, 1);

            MainFormd mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Chicken Wings", 190, 1);
            }
        }
    }
}
