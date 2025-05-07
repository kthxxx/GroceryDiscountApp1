namespace GroceryDiscountApp
{
    partial class Confirmation
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
            NoBtn = new Button();
            YesBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 19);
            label1.Name = "label1";
            label1.Size = new Size(355, 25);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to checkout?";
            // 
            // NoBtn
            // 
            NoBtn.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoBtn.Location = new Point(63, 66);
            NoBtn.Name = "NoBtn";
            NoBtn.Size = new Size(119, 38);
            NoBtn.TabIndex = 1;
            NoBtn.Text = "No";
            NoBtn.UseVisualStyleBackColor = true;
            NoBtn.Click += NoBtn_Click;
            // 
            // YesBtn
            // 
            YesBtn.Font = new Font("Helvetica", 12F, FontStyle.Bold);
            YesBtn.Location = new Point(252, 66);
            YesBtn.Name = "YesBtn";
            YesBtn.Size = new Size(119, 38);
            YesBtn.TabIndex = 2;
            YesBtn.Text = "Yes";
            YesBtn.UseVisualStyleBackColor = true;
            YesBtn.Click += YesBtn_Click;
            // 
            // Confirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(455, 125);
            Controls.Add(YesBtn);
            Controls.Add(NoBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Confirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteBTN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button NoBtn;
        private Button YesBtn;
    }
}