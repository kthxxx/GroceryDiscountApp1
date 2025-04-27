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
    public partial class Avocado : UserControl {
        public Avocado() {
            InitializeComponent();
            this.Click += new EventHandler(AvocadoClicked);
        }

        private void AvocadoClicked(object sender, EventArgs e) {
           Products productList = Products.Instance;
            productList.AddProduct("Avocado", 80, 1);

            MainFormd? mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Avocado", 80, 1);
            }
        }
    }
}
