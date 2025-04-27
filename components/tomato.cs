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
    public partial class Tomato : UserControl {
        public Tomato() {
            InitializeComponent();
            this.Click += new EventHandler(TomatoClicked);
        }

        private void TomatoClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;
            productList.AddProduct("Tomato", 95, 1);

            MainFormd mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Tomato", 95, 1);
            }
        }
    }
}
