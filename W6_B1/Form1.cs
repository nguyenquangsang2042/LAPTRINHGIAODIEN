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

        private void Button2_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


      

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button2_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button2_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button2_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void Button3_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void Button3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button3_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button3_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button3_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button3_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }
        private void ButtonCong_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void ButtonCong_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ButtonCong_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void ButtonCong_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void ButtonCong_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void ButtonCong_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void buttonCong_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void Button4_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void Button4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button4_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button4_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button4_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button4_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void Button5_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }




        private void Button5_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button5_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button5_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button5_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void Button6_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void Button6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button6_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button6_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button6_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button6_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }
        private void ButtonTru_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void ButtonTru_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ButtonTru_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void ButtonTru_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void ButtonTru_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void ButtonTru_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void buttonTru_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void Button7_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void Button7_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button7_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button7_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button7_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button7_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button7_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void Button8_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }




        private void Button8_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button8_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button8_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button8_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button8_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void Button9_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void Button9_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button9_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button9_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button9_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button9_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button9_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }
        private void ButtonNhan_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void ButtonNhan_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ButtonNhan_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void ButtonNhan_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void ButtonNhan_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void ButtonNhan_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void buttonNhan_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void Button0_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }
        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }
        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }
        private void Button0_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button0_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void Button0_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void Button0_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void Button0_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void Button0_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void ButtonC_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }




        private void ButtonC_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void ButtonC_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void ButtonC_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void ButtonC_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void ButtonC_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void ButtonBang_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void ButtonBang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ButtonBang_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void ButtonBang_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void ButtonBang_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void ButtonBang_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void ButtonBang_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }
        private void ButtonChia_MouseDown(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseDown";
        }


        private void ButtonChia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ButtonChia_MouseEnter(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseEnter";
        }

        private void ButtonChia_MouseHover(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseHover";
        }

        private void ButtonChia_MouseLeave(object sender, EventArgs e)
        {
            labelShow.Text = "Button1_MouseLeave";
        }

        private void ButtonChia_MouseMove(object sender, MouseEventArgs e)
        {
            /*labelShow.Text = "Button1_MouseMove";*/
        }

        private void buttonChia_MouseUp(object sender, MouseEventArgs e)
        {
            labelShow.Text = "Button1_MouseUp";
        }

        private void txtHT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.D1)
            {
                button1.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D2)
            {
                button2.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D3)
            {
                button3.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D4)
            {
                button4.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D5)
            {
                button5.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D6)
            {
                button6.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D7)
            {
                button7.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D8)
            {
                button8.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.D9)
            {
                button9.BackColor = Color.Blue;
            }
            if(e.KeyCode==Keys.Divide)
            {
                buttonChia.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Multiply)
            {
                buttonNhan.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.Add)
            {
                buttonCong.BackColor = Color.Blue;
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                buttonTru.BackColor = Color.Blue;

            }
            if (e.KeyCode == Keys.D0)
            {
                button0.BackColor = Color.Blue;

            }
            if(e.KeyCode==Keys.Multiply)
            {
                buttonCong.BackColor = Color.Blue;
            }
            
        }

        private void txtHT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                button1.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.D2)
            {
                button2.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.D3)
            {
                button3.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.D4)
            {
                button4.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.D5)
            {
                button5.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.D6)
            {
                button6.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.D7)
            {
                button7.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.D8)
            {
                button8.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.D9)
            {
                button9.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.Divide)
            {
                buttonChia.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.Multiply)
            {
                buttonNhan.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.Add)
            {
                buttonCong.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                buttonTru.BackColor = Color.White;

            }
            if (e.KeyCode == Keys.D0)
            {
                button0.BackColor = Color.White;

            }
        }

        private void txtHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D1)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.D2)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.D3)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.D4)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.D5)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.D6)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.D7)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.D8)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.D9)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.Divide)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.Multiply)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.Add)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == (char)Keys.OemMinus)
            {
                MessageBox.Show("Enter key pressed");

            }
            if (e.KeyChar == (char)Keys.D0)
            {
                MessageBox.Show("Enter key pressed");

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
