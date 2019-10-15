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
        float h_1start, h_1stop, m_1stop, m_1start, h_2start, h_2stop, m_2stop, m2_start;

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
            h_1start = DateTime.Now.Hour;
            m_1start = DateTime.Now.Minute;




        }

        private void btnbatdau2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            btnbatdau2.Enabled = false;
            btnketthuc2.Enabled = true;
            gettimeStart2 = DateTime.Now.ToString("HH:mm:ss");
            h_2start = DateTime.Now.Hour;
            m2_start = DateTime.Now.Minute;

        }

        private void btl1ketthuc_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            btn1batdau.Enabled = true;
            btl1ketthuc.Enabled = false;
            gettimeStop1 = DateTime.Now.ToString("HH:mm:ss");
            h_1stop = DateTime.Now.Hour;
            m_1stop = DateTime.Now.Minute;
            MessageBox.Show("Bạn chơi từ"+gettimeStart1+" đến "+gettimeStop1+"\n Số tiền phải trả là"+tinhtien_Compputer1().ToString());
        }

        private void btnketthuc2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            btnbatdau2.Enabled = true;
            btnketthuc2.Enabled = false;
            gettimeStop2 = DateTime.Now.ToString("HH:mm:ss");
            h_2stop = DateTime.Now.Hour;
            m_2stop = DateTime.Now.Minute;
            MessageBox.Show("Bạn chơi từ" + gettimeStart2 + " đến " + gettimeStop2 + "\n Số tiền phải trả là" + tinhtien_Compputer2().ToString());


        }
        private float convert_Minute_To_Hour_Computer1_start()
        {
            return h_1start + (m_1start / 60);
        }
        private float convert_Minute_To_Hour_Computer2_start()
        {
            return h_2start + (m2_start / 60);
        }
        private float convert_Minute_To_Hour_Computer1_stop()
        {
            return h_1stop + (m_1stop / 60);
        }
        private float convert_Minute_To_Hour_Computer2_stop()
        {
            return h_2stop + (m_2stop / 60);
        }

        private float tinhtien_Compputer1()
        {

            return (convert_Minute_To_Hour_Computer1_stop() - convert_Minute_To_Hour_Computer1_start())*3000;
        }
        private float tinhtien_Compputer2()
        {

            return (convert_Minute_To_Hour_Computer2_stop() - convert_Minute_To_Hour_Computer2_start()) * 3000;
        }

    }
}
