﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryDiscountApp
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Confirmation confirmation = new Confirmation();

            confirmation.Show();

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubTotalLabel_Click_1(object sender, EventArgs e)
        {

        }

        

    }
}
