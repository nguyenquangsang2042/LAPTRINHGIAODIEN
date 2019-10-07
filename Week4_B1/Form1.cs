using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Đại học hoa sen xin chào các bạn";
            timer1.Enabled = true;
            timer1.Interval = 50;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveleft();
            if (label1.Left < 50)

            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                timer2.Interval = 50;
            }

        }
        void moveright()
        {
            
                label1.Left = label1.Left + 5;
            
            
        }
        void moveleft()
        {
            label1.Left = label1.Left - 5;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            moveright();
            if (label1.Left > 300)

            {
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Interval = 50;
            }
        }
    }
}
