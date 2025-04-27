using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GroceryDiscountApp.models;

namespace GroceryDiscountApp.interfaces
{
    public partial class ReceiptItem : UserControl
    {
        public ReceiptItem()
        {
            InitializeComponent();
        }

        public void GenerateReceipt(List<Product> products, decimal subtotal, decimal discount, decimal total)
        {
            // Clear existing controls
            this.Controls.Clear();

            // Add header
            Label header = new Label
            {
                Text = "Receipt",
                Font = new Font("Arial", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            this.Controls.Add(header);

            // Add product details
            int yOffset = 40;
            foreach (var product in products)
            {
                ReceiptItem receiptItem = new ReceiptItem();
                receiptItem.SetProductDetails(product.Name, (decimal)product.Price, product.Quantity);
                receiptItem.Location = new Point(10, yOffset);
                this.Controls.Add(receiptItem);
                yOffset += 50; // Adjust the offset for the next item
            }

            // Add subtotal
            Label subtotalLabel = new Label
            {
                Text = $"Subtotal: {subtotal:C}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, yOffset)
            };
            this.Controls.Add(subtotalLabel);
            yOffset += 30;

            // Add discount
            Label discountLabel = new Label
            {
                Text = $"Discount: {discount:C}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, yOffset)
            };
            this.Controls.Add(discountLabel);
            yOffset += 30;

            // Add total
            Label totalLabel = new Label
            {
                Text = $"Total: {total:C}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, yOffset)
            };
            this.Controls.Add(totalLabel);
        }

        public void SetProductDetails(string name, decimal price, int quantity)
        {
            // Assuming lblItem, lblUnitPrice, lblQuantity, and lblAmount are labels in the UserControl
            lblItem.Text = name;
            lblUnitPrice.Text = price.ToString("C");
            lblQuantity.Text = quantity.ToString();
            lblAmount.Text = (price * quantity).ToString("C");
        }
    }
}
