using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroceryDiscountApp
{
    public partial class FinalReceipt : Form
    {
        public FinalReceipt(List<Product> products, decimal subtotal, decimal discount, decimal total)
        {
            InitializeComponent();
            GenerateReceipt(products, subtotal, discount, total);
            timeLbl.Text = DateTime.Now.ToString("f"); // "f" format specifier for full date/time pattern
        }

        public void GenerateReceipt(List<Product> products, double subtotal, double discount, double total)
        {
            // Clear existing rows
            this.tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.RowCount = 0;

            // Add product details
            foreach (var product in products)
            {
                this.tableLayoutPanel1.RowCount++;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

                Label nameLabel = new Label
                {
                    Text = product.Name,
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    AutoSize = true
                };
                Label quantityLabel = new Label
                {
                    Text = product.Quantity.ToString(),
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    AutoSize = true
                };
                Label priceLabel = new Label
                {
                    Text = $"{product.Price:C}",
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    AutoSize = true
                };

                this.tableLayoutPanel1.Controls.Add(nameLabel, 0, this.tableLayoutPanel1.RowCount - 1);
                this.tableLayoutPanel1.Controls.Add(quantityLabel, 1, this.tableLayoutPanel1.RowCount - 1);
                this.tableLayoutPanel1.Controls.Add(priceLabel, 2, this.tableLayoutPanel1.RowCount - 1);
            }

            // Set subtotal, discount, and total
            this.SubTotalLabel.Text = $"Subtotal: {subtotal:C}";
            this.DiscountLabel.Text = $"Discount: {discount:C}";
            this.TotalLabel.Text = $"Total: {total:C}";
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFormd? mainForm = Application.OpenForms.OfType<MainFormd>().FirstOrDefault();
            Products prod = Products.Instance;
            prod.ProductList.Clear();
            mainForm.ResetForm();

        }
    }
}
