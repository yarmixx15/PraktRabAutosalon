﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormAuto formA = new FormAuto();
            formA.Show();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

        }

        private void reg_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
