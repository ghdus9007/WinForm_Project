﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class frmorder : Form
    {
        public frmorder()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmorder_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(tmrSecond_Tick);
            timer1.Start();
            UpdateNowDateTime();
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            UpdateNowDateTime();
        }

        void UpdateNowDateTime()
        {
            label7.Text = "현재시간 : " + DateTime.Now.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmtotsold ftt = new frmtotsold();
            ftt.label19.Text = label10.Text;
            ftt.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new frmempcheck().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmordercheck foc = new frmordercheck();
            foc.label8.Text = label10.Text;
            foc.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmmail().Show();
        }
    }
}
