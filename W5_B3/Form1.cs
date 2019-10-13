using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5_B3
{
    public partial class Form1 : Form
    {
        string gettimeStart1, gettimeStop1,gettimeStart2, gettimeStop2;


        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            this.btl1ketthuc.Enabled = false;
            this.btnketthuc2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          this.label3.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label4.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }

        private void btn1batdau_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btn1batdau.Enabled = false;
            btl1ketthuc.Enabled = true;
            gettimeStart1 = DateTime.Now.ToString("HH:mm:ss");



        }

        private void btnbatdau2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            btnbatdau2.Enabled = false;
            btnketthuc2.Enabled = true;
            gettimeStart2 = DateTime.Now.ToString("HH:mm:ss");


        }

        private void btl1ketthuc_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            btn1batdau.Enabled = true;
            btl1ketthuc.Enabled = false;
            gettimeStop1 = DateTime.Now.ToString("HH:mm:ss");
            MessageBox.Show("from  "+gettimeStart1.ToString()+" To "+gettimeStop1);
        }

        private void btnketthuc2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            btnbatdau2.Enabled = true;
            btnketthuc2.Enabled = false;
            gettimeStop2 = DateTime.Now.ToString("HH:mm:ss");
            MessageBox.Show("from  " + gettimeStart2.ToString() + " To " + gettimeStop2);

        }
    }
}
