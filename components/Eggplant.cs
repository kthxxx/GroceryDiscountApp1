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
    public partial class Eggplant : UserControl {
        public Eggplant() {
            InitializeComponent();
            this.Click += new EventHandler(EggplantClicked);
        }

        private void EggplantClicked(object sender, EventArgs e) {
            Products productList = Products.Instance;
            productList.AddProduct("Eggplant", 40, 1);

            MainFormd? mainForm = (MainFormd?)Application.OpenForms["MainFormd"];
            if (mainForm != null)
            {
                mainForm.UpdateProductDetails("Eggplant", 40, 1);
            }
        }

    }
}
