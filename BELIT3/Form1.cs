﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BELIT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void BtnOpen3_Click(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }

        private void BtnOpen4_Click(object sender, EventArgs e)
        {
            fSub4 _dlg = new fSub4();
            _dlg.ShowDialog();

        }

        private void BtnOpen5_Click(object sender, EventArgs e)
        {
            fSub5 _dlg = new fSub5();
            _dlg.ShowDialog();

        }

      }
}
