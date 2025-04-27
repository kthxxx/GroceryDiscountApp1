namespace GroceryDiscountApp.interfaces;

partial class MainFormd
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormd));
        panel1 = new Panel();
        pictureBox1 = new PictureBox();
        textBox1 = new TextBox();
        BT_Sell = new Button();
        panel2 = new Panel();
        panel3 = new Panel();
        ShopName = new Label();
        label2 = new Label();
        label8 = new Label();
        panel5 = new Panel();
        Panel0 = new Panel();
        CartPanel = new FlowLayoutPanel();
        panel6 = new Panel();
        AllTotal = new TextBox();
        LB_Total = new Label();
        DiscountTotal = new TextBox();
        label1 = new Label();
        QuantityTotal = new TextBox();
        LB_Quantity = new Label();
        ItemTotal = new TextBox();
        ItemLabel = new Label();
        SubTotal = new TextBox();
        TX_Subtotal = new TextBox();
        panel7 = new Panel();
        BT_Remove = new Button();
        BT_Calculate = new Button();
        BT_Vegi = new Button();
        BT_Fruit = new Button();
        BT_Meat = new Button();
        BT_All = new Button();
        productDisplayPanel = new FlowLayoutPanel();
        allProduct2 = new components.AllProduct();
        allProduct1 = new components.AllProduct();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel3.SuspendLayout();
        panel5.SuspendLayout();
        Panel0.SuspendLayout();
        panel6.SuspendLayout();
        productDisplayPanel.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(52, 58, 64);
        panel1.Controls.Add(pictureBox1);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(BT_Sell);
        panel1.Controls.Add(panel2);
        panel1.Location = new Point(1, -5);
        panel1.Name = "panel1";
        panel1.Size = new Size(89, 673);
        panel1.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(13, 14);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(60, 54);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 6;
        pictureBox1.TabStop = false;
        // 
        // textBox1
        // 
        textBox1.BackColor = Color.FromArgb(52, 58, 64);
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        textBox1.ForeColor = Color.FromArgb(248, 249, 251);
        textBox1.Location = new Point(13, 136);
        textBox1.Margin = new Padding(2);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(55, 28);
        textBox1.TabIndex = 5;
        textBox1.Text = "Sell";
        textBox1.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // BT_Sell
        // 
        BT_Sell.AllowDrop = true;
        BT_Sell.BackColor = Color.FromArgb(52, 58, 64);
        BT_Sell.BackgroundImage = Properties.Resources.shopping;
        BT_Sell.BackgroundImageLayout = ImageLayout.Stretch;
        BT_Sell.FlatAppearance.BorderSize = 0;
        BT_Sell.FlatStyle = FlatStyle.Flat;
        BT_Sell.Location = new Point(11, 78);
        BT_Sell.Name = "BT_Sell";
        BT_Sell.Size = new Size(52, 53);
        BT_Sell.TabIndex = 4;
        BT_Sell.UseVisualStyleBackColor = false;
        // 
        // panel2
        // 
        panel2.BackColor = Color.WhiteSmoke;
        panel2.Location = new Point(88, 8);
        panel2.Name = "panel2";
        panel2.Size = new Size(1131, 66);
        panel2.TabIndex = 1;
        // 
        // panel3
        // 
        panel3.BackColor = SystemColors.ButtonHighlight;
        panel3.Controls.Add(ShopName);
        panel3.Location = new Point(90, 2);
        panel3.Margin = new Padding(2);
        panel3.Name = "panel3";
        panel3.Size = new Size(1197, 66);
        panel3.TabIndex = 1;
        // 
        // ShopName
        // 
        ShopName.AutoSize = true;
        ShopName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ShopName.ForeColor = Color.FromArgb(23, 162, 185);
        ShopName.Location = new Point(5, 4);
        ShopName.Name = "ShopName";
        ShopName.Size = new Size(142, 37);
        ShopName.TabIndex = 7;
        ShopName.Text = "7 Ebelen";
        // 
        // label2
        // 
        label2.Location = new Point(0, 0);
        label2.Name = "label2";
        label2.Size = new Size(100, 23);
        label2.TabIndex = 0;
        // 
        // label8
        // 
        label8.Location = new Point(0, 0);
        label8.Name = "label8";
        label8.Size = new Size(100, 23);
        label8.TabIndex = 0;
        // 
        // panel5
        // 
        panel5.BackColor = Color.FromArgb(52, 58, 64);
        panel5.Controls.Add(Panel0);
        panel5.ForeColor = Color.White;
        panel5.Location = new Point(795, 67);
        panel5.Name = "panel5";
        panel5.Size = new Size(492, 600);
        panel5.TabIndex = 3;
        // 
        // Panel0
        // 
        Panel0.BackColor = Color.FromArgb(52, 58, 64);
        Panel0.Controls.Add(CartPanel);
        Panel0.Controls.Add(panel6);
        Panel0.ForeColor = Color.White;
        Panel0.Location = new Point(0, 0);
        Panel0.Margin = new Padding(2);
        Panel0.Name = "Panel0";
        Panel0.Size = new Size(490, 583);
        Panel0.TabIndex = 3;
        // 
        // CartPanel
        // 
        CartPanel.AutoScroll = true;
        CartPanel.Location = new Point(3, 6);
        CartPanel.Name = "CartPanel";
        CartPanel.Size = new Size(474, 394);
        CartPanel.TabIndex = 12;
        CartPanel.Paint += CartPanel_Paint;
        // 
        // panel6
        // 
        panel6.BackColor = Color.FromArgb(55, 58, 64);
        panel6.Controls.Add(AllTotal);
        panel6.Controls.Add(LB_Total);
        panel6.Controls.Add(DiscountTotal);
        panel6.Controls.Add(label1);
        panel6.Controls.Add(QuantityTotal);
        panel6.Controls.Add(LB_Quantity);
        panel6.Controls.Add(ItemTotal);
        panel6.Controls.Add(ItemLabel);
        panel6.Controls.Add(SubTotal);
        panel6.Controls.Add(TX_Subtotal);
        panel6.Controls.Add(panel7);
        panel6.Controls.Add(BT_Remove);
        panel6.Controls.Add(BT_Calculate);
        panel6.Location = new Point(1, 406);
        panel6.Name = "panel6";
        panel6.Size = new Size(488, 191);
        panel6.TabIndex = 0;
        // 
        // AllTotal
        // 
        AllTotal.BackColor = Color.FromArgb(55, 58, 64);
        AllTotal.BorderStyle = BorderStyle.None;
        AllTotal.Font = new Font("Arial", 14.25F);
        AllTotal.ForeColor = SystemColors.Control;
        AllTotal.Location = new Point(334, 100);
        AllTotal.Name = "AllTotal";
        AllTotal.Size = new Size(100, 22);
        AllTotal.TabIndex = 11;
        AllTotal.Text = "₱0";
        AllTotal.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // LB_Total
        // 
        LB_Total.AutoSize = true;
        LB_Total.Font = new Font("Arial", 14F, FontStyle.Bold);
        LB_Total.Location = new Point(334, 75);
        LB_Total.Name = "LB_Total";
        LB_Total.Size = new Size(56, 22);
        LB_Total.TabIndex = 10;
        LB_Total.Text = "Total";
        LB_Total.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // DiscountTotal
        // 
        DiscountTotal.BackColor = Color.FromArgb(55, 58, 64);
        DiscountTotal.BorderStyle = BorderStyle.None;
        DiscountTotal.Font = new Font("Arial", 14.25F);
        DiscountTotal.ForeColor = SystemColors.Control;
        DiscountTotal.Location = new Point(214, 99);
        DiscountTotal.Name = "DiscountTotal";
        DiscountTotal.Size = new Size(100, 22);
        DiscountTotal.TabIndex = 9;
        DiscountTotal.Text = "₱0";
        DiscountTotal.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 14F, FontStyle.Bold);
        label1.Location = new Point(214, 74);
        label1.Name = "label1";
        label1.Size = new Size(93, 22);
        label1.TabIndex = 8;
        label1.Text = "Discount";
        label1.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // QuantityTotal
        // 
        QuantityTotal.BackColor = Color.FromArgb(55, 58, 64);
        QuantityTotal.BorderStyle = BorderStyle.None;
        QuantityTotal.Font = new Font("Arial", 14.25F);
        QuantityTotal.ForeColor = SystemColors.Control;
        QuantityTotal.Location = new Point(105, 100);
        QuantityTotal.Name = "QuantityTotal";
        QuantityTotal.Size = new Size(100, 22);
        QuantityTotal.TabIndex = 7;
        QuantityTotal.Text = "0";
        QuantityTotal.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // LB_Quantity
        // 
        LB_Quantity.AutoSize = true;
        LB_Quantity.Font = new Font("Arial", 14F, FontStyle.Bold);
        LB_Quantity.Location = new Point(99, 75);
        LB_Quantity.Name = "LB_Quantity";
        LB_Quantity.Size = new Size(88, 22);
        LB_Quantity.TabIndex = 6;
        LB_Quantity.Text = "Quantity";
        LB_Quantity.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // ItemTotal
        // 
        ItemTotal.BackColor = Color.FromArgb(55, 58, 64);
        ItemTotal.BorderStyle = BorderStyle.None;
        ItemTotal.Font = new Font("Arial", 14.25F);
        ItemTotal.ForeColor = SystemColors.Control;
        ItemTotal.Location = new Point(7, 100);
        ItemTotal.Name = "ItemTotal";
        ItemTotal.Size = new Size(100, 22);
        ItemTotal.TabIndex = 5;
        ItemTotal.Text = "0";
        ItemTotal.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // ItemLabel
        // 
        ItemLabel.AutoSize = true;
        ItemLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
        ItemLabel.Location = new Point(7, 75);
        ItemLabel.Name = "ItemLabel";
        ItemLabel.Size = new Size(60, 22);
        ItemLabel.TabIndex = 4;
        ItemLabel.Text = "Items";
        ItemLabel.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // SubTotal
        // 
        SubTotal.BackColor = Color.FromArgb(55, 58, 64);
        SubTotal.BorderStyle = BorderStyle.None;
        SubTotal.Font = new Font("Arial", 12F);
        SubTotal.ForeColor = SystemColors.Control;
        SubTotal.Location = new Point(7, 28);
        SubTotal.Name = "SubTotal";
        SubTotal.Size = new Size(100, 19);
        SubTotal.TabIndex = 3;
        // 
        // TX_Subtotal
        // 
        TX_Subtotal.BackColor = Color.FromArgb(55, 58, 64);
        TX_Subtotal.BorderStyle = BorderStyle.None;
        TX_Subtotal.Font = new Font("Arial", 10F, FontStyle.Bold);
        TX_Subtotal.ForeColor = SystemColors.Control;
        TX_Subtotal.Location = new Point(7, 12);
        TX_Subtotal.Name = "TX_Subtotal";
        TX_Subtotal.Size = new Size(100, 16);
        TX_Subtotal.TabIndex = 0;
        TX_Subtotal.Text = "Subtotal";
        TX_Subtotal.EnabledChanged += TX_Subtotal_EnabledChanged;
        // 
        // panel7
        // 
        panel7.BackColor = Color.White;
        panel7.Location = new Point(7, 56);
        panel7.Name = "panel7";
        panel7.Size = new Size(465, 10);
        panel7.TabIndex = 2;
        // 
        // BT_Remove
        // 
        BT_Remove.BackColor = Color.FromArgb(220, 53, 68);
        BT_Remove.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        BT_Remove.Location = new Point(39, 132);
        BT_Remove.Name = "BT_Remove";
        BT_Remove.Size = new Size(60, 46);
        BT_Remove.TabIndex = 1;
        BT_Remove.Text = "🗑️";
        BT_Remove.UseVisualStyleBackColor = false;
        BT_Remove.Click += BT_Remove_Click;
        // 
        // BT_Calculate
        // 
        BT_Calculate.BackColor = Color.FromArgb(40, 167, 69);
        BT_Calculate.Font = new Font("Arial", 16F, FontStyle.Bold);
        BT_Calculate.Location = new Point(214, 132);
        BT_Calculate.Name = "BT_Calculate";
        BT_Calculate.Size = new Size(262, 46);
        BT_Calculate.TabIndex = 0;
        BT_Calculate.Text = "Check Out";
        BT_Calculate.UseVisualStyleBackColor = false;
        // 
        // BT_Vegi
        // 
        BT_Vegi.Font = new Font("Arial", 10F, FontStyle.Bold);
        BT_Vegi.ForeColor = Color.FromArgb(23, 162, 184);
        BT_Vegi.Location = new Point(105, 142);
        BT_Vegi.Name = "BT_Vegi";
        BT_Vegi.Size = new Size(111, 48);
        BT_Vegi.TabIndex = 4;
        BT_Vegi.Text = "Vegetables";
        BT_Vegi.UseVisualStyleBackColor = true;
        BT_Vegi.Click += BT_Vegi_Click_1;
        // 
        // BT_Fruit
        // 
        BT_Fruit.Font = new Font("Arial", 14.25F, FontStyle.Bold);
        BT_Fruit.ForeColor = Color.FromArgb(23, 162, 184);
        BT_Fruit.Location = new Point(105, 196);
        BT_Fruit.Name = "BT_Fruit";
        BT_Fruit.Size = new Size(111, 48);
        BT_Fruit.TabIndex = 5;
        BT_Fruit.Text = "Fruits";
        BT_Fruit.UseVisualStyleBackColor = true;
        BT_Fruit.Click += BT_Fruit_Click;
        // 
        // BT_Meat
        // 
        BT_Meat.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BT_Meat.ForeColor = Color.FromArgb(23, 162, 184);
        BT_Meat.Location = new Point(105, 250);
        BT_Meat.Name = "BT_Meat";
        BT_Meat.Size = new Size(111, 48);
        BT_Meat.TabIndex = 7;
        BT_Meat.Text = "Meat";
        BT_Meat.UseVisualStyleBackColor = true;
        BT_Meat.Click += BT_Meat_Click;
        // 
        // BT_All
        // 
        BT_All.BackColor = Color.White;
        BT_All.Font = new Font("Arial", 14.25F, FontStyle.Bold);
        BT_All.ForeColor = Color.FromArgb(23, 162, 184);
        BT_All.Location = new Point(105, 88);
        BT_All.Name = "BT_All";
        BT_All.Size = new Size(111, 48);
        BT_All.TabIndex = 8;
        BT_All.Text = "ALL";
        BT_All.UseVisualStyleBackColor = false;
        BT_All.Click += BT_All_Click;
        // 
        // productDisplayPanel
        // 
        productDisplayPanel.Controls.Add(allProduct2);
        productDisplayPanel.Location = new Point(236, 83);
        productDisplayPanel.Name = "productDisplayPanel";
        productDisplayPanel.Size = new Size(540, 621);
        productDisplayPanel.TabIndex = 9;
        // 
        // allProduct2
        // 
        allProduct2.AutoScroll = true;
        allProduct2.Location = new Point(2, 2);
        allProduct2.Margin = new Padding(2);
        allProduct2.Name = "allProduct2";
        allProduct2.Size = new Size(540, 566);
        allProduct2.TabIndex = 0;
        // 
        // allProduct1
        // 
        allProduct1.AutoScroll = true;
        allProduct1.Location = new Point(3, 3);
        allProduct1.Margin = new Padding(3, 4, 3, 4);
        allProduct1.Name = "allProduct1";
        allProduct1.Size = new Size(540, 566);
        allProduct1.TabIndex = 0;
        // 
        // MainFormd
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(1284, 661);
        Controls.Add(productDisplayPanel);
        Controls.Add(BT_All);
        Controls.Add(BT_Meat);
        Controls.Add(BT_Fruit);
        Controls.Add(BT_Vegi);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Controls.Add(panel5);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(4);
        Name = "MainFormd";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Grocery Store";
        Load += MainFormd_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel5.ResumeLayout(false);
        Panel0.ResumeLayout(false);
        panel6.ResumeLayout(false);
        panel6.PerformLayout();
        productDisplayPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private Panel panel5;
    private Button BT_Sell;
    private TextBox textBox1;
    private Button BT_Vegi;
    private Button BT_Fruit;
    private Button BT_Meat;
    private Button BT_All;
    private Button BT_Calculate;
    private Button BT_Remove;
    private PictureBox pictureBox1;
    private Panel panel6;
    private TextBox AllTotal;
    private Label LB_Total;
    private TextBox DiscountTotal;
    private Label label1;
    private TextBox QuantityTotal;
    private Label LB_Quantity;
    private TextBox ItemTotal;
    private Label ItemLabel;
    private TextBox SubTotal;
    private TextBox TX_Subtotal;
    private Panel panel7;
    private Panel Panel0;
    private FlowLayoutPanel productDisplayPanel;
    private components.AllProduct allProduct1;
    private FlowLayoutPanel CartPanel;
    private components.AllProduct allProduct2;
    private Label label2;
    private Label label8;
    private Label ShopName;
}
