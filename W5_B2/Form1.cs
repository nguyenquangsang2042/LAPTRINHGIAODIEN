using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace W5_B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;

             
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (this.progressBar1.Value == 3)
            {
                this.timer1.Enabled = false;
                this.Hide();

                W5_B3.Form1 form = new W5_B3.Form1();
                form.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            W5_B3.Form1 form=new W5_B3.Form1();
            form.ShowDialog();
            this.Close();
          
        }
    }
}
