namespace GroceryDiscountApp
{
    partial class Database
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ShopName = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            ld = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ld);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(129, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 578);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(603, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(675, 291);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(603, 374);
            panel3.Name = "panel3";
            panel3.Size = new Size(675, 275);
            panel3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(10, 92);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(447, 581);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ShopName
            // 
            ShopName.AutoSize = true;
            ShopName.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShopName.ForeColor = Color.FromArgb(23, 162, 185);
            ShopName.Location = new Point(3, 0);
            ShopName.Name = "ShopName";
            ShopName.Size = new Size(189, 57);
            ShopName.TabIndex = 7;
            ShopName.Text = "PantryPal";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(ShopName);
            panel4.Location = new Point(-13, 4);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1307, 58);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 58, 64);
            panel5.Location = new Point(4, 79);
            panel5.Name = "panel5";
            panel5.Size = new Size(119, 579);
            panel5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(234, 42);
            label1.TabIndex = 9;
            label1.Text = "Sales Report";
            // 
            // ld
            // 
            ld.AutoSize = true;
            ld.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ld.Location = new Point(20, 69);
            ld.Name = "ld";
            ld.Size = new Size(413, 14);
            ld.TabIndex = 10;
            ld.Text = "KioskID                     Product Name                           Amount                         Date";
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1284, 661);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Database";
            Text = "Database";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label ShopName;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label ld;
    }
}