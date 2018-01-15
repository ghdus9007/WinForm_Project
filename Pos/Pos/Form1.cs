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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmsold fs = new frmsold();
            fs.label8.Text = label1.Text;
            fs.ShowDialog();
            this.Close();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmlogin().ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmemp().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmoption().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmtotsold ftt = new frmtotsold();
            ftt.label19.Text = label1.Text;
            ftt.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            fo.label10.Text = label1.Text;
            fo.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new frmshipper().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new frmempcheck().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            new frmpayupdate().Show();
=======
            new frmownercheck().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmmail().Show();
>>>>>>> 5b09e592626262352de4ccd24febeebc9c38fdf9
        }
    }
}
