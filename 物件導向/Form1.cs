using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 物件導向
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class test
        {
            public int H;
            public int W;

            public double HW()
            {
               return H * W;
            }

            public double HW1()
            {
                return H + W;
            }

            public double HW2()
            {
                return H - W;
            }

            public double HW3()
            {
                return H / W;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            test a = new test();
            a.H = Convert.ToInt32(textBox1.Text);
            a.W = Convert.ToInt32(textBox2.Text);
            Console.WriteLine("運算結果 = " + a.HW());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test a = new test();
            a.H = Convert.ToInt32(textBox1.Text);
            a.W = Convert.ToInt32(textBox2.Text);
            Console.WriteLine("運算結果 = " + a.HW1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test a = new test();
            a.H = Convert.ToInt32(textBox1.Text);
            a.W = Convert.ToInt32(textBox2.Text);
            Console.WriteLine("運算結果 = " + a.HW2());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            test a = new test();
            a.H = Convert.ToInt32(textBox1.Text);
            a.W = Convert.ToInt32(textBox2.Text);
            Console.WriteLine("運算結果 = " + a.HW3());
        }
    }
}
