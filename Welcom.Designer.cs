namespace GroceryDiscountApp
{
    partial class Welcom
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
            pictureBox1 = new PictureBox();
            PantryPal = new Label();
            label1 = new Label();
            button1 = new Button();
            LblAboutus = new Label();
            LblContactus = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._11436168;
            pictureBox1.Location = new Point(592, -42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(913, 842);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PantryPal
            // 
            PantryPal.AutoSize = true;
            PantryPal.BackColor = Color.Transparent;
            PantryPal.FlatStyle = FlatStyle.Flat;
            PantryPal.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PantryPal.ForeColor = SystemColors.Control;
            PantryPal.Location = new Point(68, 30);
            PantryPal.Name = "PantryPal";
            PantryPal.Size = new Size(205, 62);
            PantryPal.TabIndex = 1;
            PantryPal.Text = "PantryPal";
            PantryPal.TextAlign = ContentAlignment.BottomLeft;
            PantryPal.Click += PantryPal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(68, 227);
            label1.Name = "label1";
            label1.Size = new Size(325, 28);
            label1.TabIndex = 2;
            label1.Text = "Your pantry’s new best friend.";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 167, 69);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Helvetica", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(68, 514);
            button1.Name = "button1";
            button1.Size = new Size(262, 38);
            button1.TabIndex = 3;
            button1.Text = "Continue Shopping";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LblAboutus
            // 
            LblAboutus.AutoSize = true;
            LblAboutus.Font = new Font("Helvetica", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAboutus.ForeColor = SystemColors.Control;
            LblAboutus.Location = new Point(617, 52);
            LblAboutus.Name = "LblAboutus";
            LblAboutus.Size = new Size(106, 28);
            LblAboutus.TabIndex = 4;
            LblAboutus.Text = "About us";
            LblAboutus.Click += label2_Click;
            // 
            // LblContactus
            // 
            LblContactus.AutoSize = true;
            LblContactus.Font = new Font("Helvetica", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContactus.ForeColor = SystemColors.Control;
            LblContactus.Location = new Point(793, 52);
            LblContactus.Name = "LblContactus";
            LblContactus.Size = new Size(126, 28);
            LblContactus.TabIndex = 5;
            LblContactus.Text = "Contact us";
            LblContactus.Click += LblContactus_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(68, 255);
            label4.Name = "label4";
            label4.Size = new Size(465, 57);
            label4.TabIndex = 6;
            label4.Text = "From Cart to Heart,";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(68, 312);
            label5.Name = "label5";
            label5.Size = new Size(518, 57);
            label5.TabIndex = 7;
            label5.Text = "Freshness Delivered!";
            // 
            // Welcom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1284, 661);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LblContactus);
            Controls.Add(LblAboutus);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(PantryPal);
            Controls.Add(pictureBox1);
            Name = "Welcom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label PantryPal;
        private Label label1;
        private Button button1;
        private Label LblAboutus;
        private Label LblContactus;
        private Label label4;
        private Label label5;
    }
}