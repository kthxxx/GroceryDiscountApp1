namespace GroceryDiscountApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            CloseButton = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ShopName = new Label();
            panel2 = new Panel();
            CleanBTN = new Button();
            LoginBTN = new Button();
            ShowPassCheck = new CheckBox();
            label3 = new Label();
            PasswordField = new TextBox();
            label2 = new Label();
            UserField = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.BackgroundImage = Properties.Resources.close;
            resources.ApplyResources(CloseButton, "CloseButton");
            CloseButton.Name = "CloseButton";
            CloseButton.TabStop = false;
            CloseButton.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 58, 64);
            panel1.Controls.Add(ShopName);
            panel1.Controls.Add(pictureBox2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // ShopName
            // 
            resources.ApplyResources(ShopName, "ShopName");
            ShopName.ForeColor = Color.FromArgb(23, 162, 185);
            ShopName.Name = "ShopName";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(CleanBTN);
            panel2.Controls.Add(LoginBTN);
            panel2.Controls.Add(ShowPassCheck);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(PasswordField);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(UserField);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(CloseButton);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // CleanBTN
            // 
            resources.ApplyResources(CleanBTN, "CleanBTN");
            CleanBTN.Name = "CleanBTN";
            CleanBTN.UseVisualStyleBackColor = true;
            // 
            // LoginBTN
            // 
            LoginBTN.BackColor = Color.FromArgb(23, 162, 185);
            resources.ApplyResources(LoginBTN, "LoginBTN");
            LoginBTN.ForeColor = SystemColors.Control;
            LoginBTN.Name = "LoginBTN";
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += LoginBTN_Click;
            // 
            // ShowPassCheck
            // 
            resources.ApplyResources(ShowPassCheck, "ShowPassCheck");
            ShowPassCheck.Name = "ShowPassCheck";
            ShowPassCheck.UseVisualStyleBackColor = true;
            ShowPassCheck.CheckedChanged += ShowPassCheck_CheckedChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(52, 58, 64);
            label3.Name = "label3";
            // 
            // PasswordField
            // 
            resources.ApplyResources(PasswordField, "PasswordField");
            PasswordField.Name = "PasswordField";
            PasswordField.TextChanged += PasswordField_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(52, 58, 64);
            label2.Name = "label2";
            // 
            // UserField
            // 
            resources.ApplyResources(UserField, "UserField");
            UserField.Name = "UserField";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(23, 162, 185);
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_interface;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.kenneth_reniel_viovicente;
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CloseButton;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label ShopName;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox UserField;
        private Label label3;
        private TextBox PasswordField;
        private Button LoginBTN;
        private CheckBox ShowPassCheck;
        private Button CleanBTN;
    }
}