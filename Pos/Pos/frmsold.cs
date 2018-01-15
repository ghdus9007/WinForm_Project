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
    public partial class frmsold : Form
    {
        public frmsold()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmbarcodecheck().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.label1.Text = label8.Text;
            form1.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmstockmanagement().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frmsoldpresent().Show();
        }

        private void frmsold_Load(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            frmorder fo = new frmorder();
            fo.label10.Text = label8.Text;
            fo.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmtotsold ftt = new frmtotsold();
            ftt.label19.Text = label8.Text;
            ftt.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new frmcardcalc().Show();
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            new frmshipper().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new frmempcheck().Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new frmmail().Show();
        }
    }
}
