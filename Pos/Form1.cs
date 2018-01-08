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
            new frmsold().Show();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private static System.Drawing.Drawing2D.GraphicsPath ButtonStyle()
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            myGraphicsPath.AddEllipse(10, 10, 80, 80);
            return myGraphicsPath;
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = ButtonStyle();
            button1.Size = new System.Drawing.Size(100, 100);
            button1.Region = new Region(myGraphicsPath);
        }
        
        private void button2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = ButtonStyle();
            button2.Size = new System.Drawing.Size(100, 100);
            button2.Region = new Region(myGraphicsPath);
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = ButtonStyle();
            button3.Size = new System.Drawing.Size(100, 100);
            button3.Region = new Region(myGraphicsPath);
        }

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = ButtonStyle();
            button4.Size = new System.Drawing.Size(100, 100);
            button4.Region = new Region(myGraphicsPath);
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = ButtonStyle();
            button5.Size = new System.Drawing.Size(100, 100);
            button5.Region = new Region(myGraphicsPath);
        }

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = ButtonStyle();
            button6.Size = new System.Drawing.Size(100, 100);
            button6.Region = new Region(myGraphicsPath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmemp().Show();
        }
    }
}
