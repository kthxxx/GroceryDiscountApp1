namespace GroceryDiscountApp
{
    partial class ReceiptItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuantity = new Label();
            lblItem = new Label();
            lblUnitPrice = new Label();
            lblAmount = new Label();
            SuspendLayout();
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(10, 11);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(24, 17);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "00";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItem.Location = new Point(89, 11);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(44, 17);
            lblItem.TabIndex = 1;
            lblItem.Text = "ITEM";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnitPrice.Location = new Point(238, 11);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(50, 17);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "₱0000";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(317, 11);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(50, 17);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "₱0000";
            // 
            // ReceiptItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAmount);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblItem);
            Controls.Add(lblQuantity);
            Name = "ReceiptItem";
            Size = new Size(402, 39);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuantity;
        private Label lblItem;
        private Label lblUnitPrice;
        private Label lblAmount;
    }
}
