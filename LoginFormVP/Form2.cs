﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormVP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();

            form.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();

            form.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();

            form.Show();

            this.Hide();
        }
    }
}
