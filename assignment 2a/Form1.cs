﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2a
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, RT;
            
            try
            {
                R1 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect Input.");
                R1 = 0.0;
            }
            try
            {
                R2 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect Input.");
                R2 = 0.0;
            }
            try
            {
                R3 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect Input.");
                R3 = 0.0;
            }
            RT = R1 + R2 + R3;
            label1.Text = "RT =" + RT;
            //comment
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
