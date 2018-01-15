using System;
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
    public partial class frmtotsold : Form
    {
        public frmtotsold()
        {
            InitializeComponent();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            label5.Text = "조회항목 : " + button7.Text;
            comboBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "조회항목 : " + button6.Text;
            comboBox1.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label6.Text = "조회항목 : " + button9.Text;
            comboBox2.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label6.Text = "조회항목 : " + button8.Text;
            comboBox2.Show();
        }

        private void frmtotsold_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(tmrSecond_Tick);
            timer1.Start();
            UpdateNowDateTime();
            comboBox1.Hide();
            comboBox2.Hide();
            label1.Text = "조회날짜 : " + DateTime.Now.ToShortDateString();
            label10.Text = "조회날짜 : " + DateTime.Now.ToShortDateString();
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            UpdateNowDateTime();
        }

        void UpdateNowDateTime()
        {
            label12.Text = "현재시간 : " + DateTime.Now.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmorder fo = new frmorder();
            fo.label10.Text = label19.Text;
            fo.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new frmtotsold().Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new frmempcheck().Show();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            new frmmail().Show();
        }
    }
}
