using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W6_B1
{
    public partial class Form1 : Form
    {
        double so1=0, so2=0;
        double kq = 0;
        char pt;
        char Eror = 'E';

        private void Button1_Click(object sender, EventArgs e)
        {
            txtHT.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtHT.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtHT.Text += "3";
        }

        private void ButtonCong_Click(object sender, EventArgs e)
        {
            pt = '+';
            so1 = Double.Parse(txtHT.Text);
            txtHT.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtHT.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            txtHT.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            txtHT.Text += "6";
        }

        private void ButtonTru_Click(object sender, EventArgs e)
        {
            pt = '-';
            so1 = Double.Parse(txtHT.Text);
            txtHT.Text = "";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            txtHT.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            txtHT.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            txtHT.Text += "9";
        }

        private void ButtonNhan_Click(object sender, EventArgs e)
        {
            pt = '*';
            so1 = Double.Parse(txtHT.Text);
            txtHT.Text = "";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            txtHT.Text += "0";
        }

        private void ButtonChia_Click(object sender, EventArgs e)
        {
            pt = '/';
            so1 = Double.Parse(txtHT.Text);
            txtHT.Text = "";
        }

      

        private void ButtonBang_Click(object sender, EventArgs e)
        {
            so2 = double.Parse(txtHT.Text);
            tinh(so1, so2, pt);
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            txtHT.Text = "";
        }
        

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           switch(e.KeyCode.ToString())
            {
                case "+":
                    pt = '+';
                    so1 = Double.Parse(txtHT.Text);
                    txtHT.Text = "";
                    break;
                case "-":
                    pt = '-';
                    so1 = Double.Parse(txtHT.Text);
                    txtHT.Text = "";
                    break;
                case "/":
                    pt = '*';
                    so1 = Double.Parse(txtHT.Text);
                    txtHT.Text = "";
                    break;

            }
            e.Handled=true;
        }

        private void ButtonCong_KeyDown(object sender, KeyEventArgs e)
        {
            pt = '+';
            so1 = Double.Parse(txtHT.Text);
            txtHT.Text = "";
        }

        private void tinh(double n1,double n2, char pt)
        {
            switch(pt)
            {
                case '+': kq = n1 + n2;
                    txtHT.Text = kq.ToString();
                    break;
                case '-':
                    kq = n1 - n2;
                    txtHT.Text = kq.ToString();
                    break;
                case '*':
                    kq = n1 * n2;
                    txtHT.Text = kq.ToString();
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        MessageBox.Show("Mau so phai lon hon 0");
                    }
                    else
                    {
                        kq = n1 / n2;
                        txtHT.Text = kq.ToString();
                    }
                    break;



            }
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void Button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
