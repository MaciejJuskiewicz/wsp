﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wsp
{
    public partial class Form1 : Form
    {
            

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "hello world";
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
