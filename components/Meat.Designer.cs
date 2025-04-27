namespace GroceryDiscountApp.components
{
    partial class Meat
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            _1WholeChicken1 = new _1WholeChicken();
            chickenwings1 = new Chickenwings();
            breast1 = new Breast();
            ribs1 = new Ribs();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(_1WholeChicken1);
            flowLayoutPanel1.Controls.Add(chickenwings1);
            flowLayoutPanel1.Controls.Add(breast1);
            flowLayoutPanel1.Controls.Add(ribs1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(540, 551);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // _1WholeChicken1
            // 
            _1WholeChicken1.BackColor = Color.FromArgb(23, 162, 184);
            _1WholeChicken1.Location = new Point(3, 3);
            _1WholeChicken1.Name = "_1WholeChicken1";
            _1WholeChicken1.Size = new Size(157, 189);
            _1WholeChicken1.TabIndex = 0;
            _1WholeChicken1.Load += _1WholeChicken1_Load;
            _1WholeChicken1.Click += WholeChickenClicked;
            // 
            // chickenwings1
            // 
            chickenwings1.BackColor = Color.FromArgb(23, 162, 184);
            chickenwings1.Location = new Point(166, 3);
            chickenwings1.Name = "chickenwings1";
            chickenwings1.Size = new Size(157, 189);
            chickenwings1.TabIndex = 1;
            // 
            // breast1
            // 
            breast1.BackColor = Color.FromArgb(23, 162, 184);
            breast1.Location = new Point(329, 3);
            breast1.Name = "breast1";
            breast1.Size = new Size(157, 189);
            breast1.TabIndex = 2;
            breast1.Load += breast1_Load;
            // 
            // ribs1
            // 
            ribs1.BackColor = Color.FromArgb(23, 162, 184);
            ribs1.Location = new Point(3, 198);
            ribs1.Name = "ribs1";
            ribs1.Size = new Size(157, 189);
            ribs1.TabIndex = 3;
            // 
            // Meat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "Meat";
            Size = new Size(540, 566);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private _1WholeChicken _1WholeChicken1;
        private Chickenwings chickenwings1;
        private Breast breast1;
        private Ribs ribs1;
    }
}
