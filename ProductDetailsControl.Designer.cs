namespace GroceryDiscountApp
{
    partial class ProductDetailsControl
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
            lblProductName = new Label();
            lblProductPrice = new Label();
            lblProductQuantity = new Label();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.Control;
            lblProductName.Location = new Point(25, 19);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(134, 22);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductPrice.ForeColor = SystemColors.Control;
            lblProductPrice.Location = new Point(214, 19);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(54, 22);
            lblProductPrice.TabIndex = 1;
            lblProductPrice.Text = "Price";
            lblProductPrice.Click += lblProductPrice_Click;
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductQuantity.ForeColor = SystemColors.Control;
            lblProductQuantity.Location = new Point(372, 19);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(32, 22);
            lblProductQuantity.TabIndex = 2;
            lblProductQuantity.Text = "10";
            lblProductQuantity.Click += lblProductQuantity_Click;
            // 
            // ProductDetailsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(lblProductQuantity);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductName);
            Name = "ProductDetailsControl";
            Size = new Size(444, 61);
            Load += ProductDetailsControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        internal Label lblProductPrice;
        internal Label lblProductQuantity;
    }
}
