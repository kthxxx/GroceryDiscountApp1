namespace GroceryDiscountApp
{
    partial class Receipt
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            SubTotalLabel = new Label();
            DiscountLabel = new Label();
            TotalLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 29);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(1, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 318);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(4, 84);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(394, 318);
            tableLayoutPanel1.TabIndex = 6;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // SubTotalLabel
            // 
            SubTotalLabel.AutoSize = true;
            SubTotalLabel.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubTotalLabel.Location = new Point(10, 423);
            SubTotalLabel.Name = "SubTotalLabel";
            SubTotalLabel.Size = new Size(73, 17);
            SubTotalLabel.TabIndex = 3;
            SubTotalLabel.Text = "RECEIPT";
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Font = new Font("Helvetica", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiscountLabel.Location = new Point(10, 445);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(73, 17);
            DiscountLabel.TabIndex = 4;
            DiscountLabel.Text = "RECEIPT";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalLabel.Location = new Point(8, 467);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(116, 29);
            TotalLabel.TabIndex = 5;
            TotalLabel.Text = "RECEIPT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 59);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 9;
            label5.Text = "ITEM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(200, 59);
            label6.Name = "label6";
            label6.Size = new Size(51, 22);
            label6.TabIndex = 10;
            label6.Text = "QTY";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(301, 59);
            label7.Name = "label7";
            label7.Size = new Size(70, 22);
            label7.TabIndex = 11;
            label7.Text = "PRICE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Helvetica", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(110, 7);
            label8.Name = "label8";
            label8.Size = new Size(192, 25);
            label8.TabIndex = 12;
            label8.Text = "SebenEveleyn Inc,";
            // 
            // button1
            // 
            button1.Location = new Point(21, 519);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 13;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(251, 519);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 14;
            button2.Text = "CHECKOUT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 561);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(TotalLabel);
            Controls.Add(DiscountLabel);
            Controls.Add(SubTotalLabel);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Receipt";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            Load += Receipt_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        public void GenerateReceipt(List<Product> products, decimal subtotal, decimal discount, decimal total)
        {
            // Clear existing rows
            this.tableLayoutPanel1.Controls.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();
            this.tableLayoutPanel1.RowCount = 0;

            // Ensure the panel contains the table
            if (!panel1.Controls.Contains(tableLayoutPanel1))
            {
                panel1.Controls.Add(tableLayoutPanel1);
            }

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

            // Refresh the UI
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.Refresh();
        }




        private Label label1;
        private Label SubTotalLabel;
        private Label DiscountLabel;
        private Label TotalLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}
