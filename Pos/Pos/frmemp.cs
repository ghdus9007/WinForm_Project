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
    public partial class frmemp : Form
    {
        public frmemp()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmempadd().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.Text == "수정완료")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                button6.Enabled = false;
                button4.Text = "정보수정";
            } else
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                button6.Enabled = true;
                button4.Text = "수정완료";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
