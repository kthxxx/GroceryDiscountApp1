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
    public partial class Orange : UserControl {
        public Orange() {
            InitializeComponent();
            this.Click += new EventHandler(OrangeClicked);
        }

        private void OrangeClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;
            productList.AddProduct("Orange", 130, 1);

            MainFormd? mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Orange", 130, 1);
            }
        }
    }
}
