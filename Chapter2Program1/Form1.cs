﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String buffer;
            buffer = "Mailing Label:" + Environment.NewLine +
                            Environment.NewLine;
            buffer = buffer + "  Name: " + txtName.Text +
                            Environment.NewLine;
            buffer = buffer + "  Address: " + txtAddress.Text +
                            Environment.NewLine;
            buffer = buffer + "  City: " + txtCity.Text +
                    "State: " + txtState.Text + " Zip: " + txtZip.Text;
            txtDisplayOutPut.Text = buffer;

        }

        private void TextBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
