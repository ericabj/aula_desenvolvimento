﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaveFacil
{
    public partial class Form2 : Form
    {
        public static string a ;
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox1.Text;
            MessageBox.Show(a);
            this.Close();
        }
    }
}
