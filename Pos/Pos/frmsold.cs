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
            this.Dispose();
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
            new frmorder().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new frmtotsold().Show();
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
    }
}
