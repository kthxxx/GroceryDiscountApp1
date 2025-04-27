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
    public partial class Ribs : UserControl {
        public Ribs() {
            InitializeComponent();
            this.Click += new EventHandler(RibsClicked);
        }

        private void RibsClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;
            productList.AddProduct("Ribs", 450, 1);

            MainFormd mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Ribs", 450, 1);
            }
        }
    }
}
