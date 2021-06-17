using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration整合
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Dilbert = 790621, Valentine = 20131030, WeddingDay = 20201010;

            //int Dilbert = 790621;
            //int Valentine = 20131030;
            //int WeddingDay = 20201010;

            MessageBox.Show( " Dilbert = " + Dilbert);
            MessageBox.Show( " Valentine = " + Valentine);
            MessageBox.Show( " WeddingDay = " + WeddingDay);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Zero = " 這是一張小紙條 ";
            string One = " 準備好要看了嗎？ ";
            string Two = " 哈囉！小胖 " + "\n" + " 有句話想跟你說 ";
            string Three = " 謝謝你，非常謝謝你 " + "\r\n" + " 來到我的生命裡。" ;
            string Four = " 陪伴我，豐富我的日常。 ";
            string Five = " 這句話，我很少對你說，" + "但是 ";
            string Six = " This is what I have been doing ";
            string Sevem = " 我愛你 ";

            MessageBox.Show(Zero);
            MessageBox.Show(One);
            MessageBox.Show(Two);
            MessageBox.Show(Three);
            MessageBox.Show(Four);
            MessageBox.Show(Five);
            MessageBox.Show(Six);
            MessageBox.Show(Sevem);
        }
        int times = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            times = times + 1;
            //times ++ ;
            //times +=1 ;

            timesLable.Text = " 你愛我 ... " + times + " 下 ";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            times = 0;

            timesLable.Text = " 你愛我 ... " + times + " 下 ";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Draw(int row, string mark)
        {
            //int row = (int)rowChooser.Value;     →可合併的寫法，把 "Draw" 寫成 Method (方法)
            string result = "";

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += mark;
                }
                result = result + "\n";
            }
            MessageBox.Show(result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int row = (int)rowChooser.Value;
            Draw(row, "\\");
            //string result = "";

            //for ( int i = 1; i <= row; i++)
            //{
            //    for (int j = 1; j <= i ; j++)
            //    {
            //        result += "^";
            //    }
            //    result = result + "\n";
            //}
            //MessageBox.Show(result);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int row = (int)rowChooser.Value;
            Draw(row, "$");
            //string result = "";  →可合併的寫法，把 "Draw" 寫成 Method (方法)

            //for (int i = 1; i <= row; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        result += "$";
            //    }
            //    result = result + "\n";
            //}
            //MessageBox.Show(result);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string text = "";

            for ( int A = 1; A <= 9; A++)
            {
                for ( int B = 1; B <= 9; B++)
                {
                    text = text +  A + "x" + B + "=" + A * B;
                }
                text += "\n";
            }
            MessageBox.Show(text);
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            int a = 3;
            int b = 5;
            MessageBox.Show("a=" + a + ",b=" + b);

            

            //something.....
            int c = a;//c=3
            a = b;//a=5
            b = c;
            //.............
            MessageBox.Show("a=" + a + ",b=" + b);

        }

        int A = 0, B = 50, ans = 28;


        private void Form1_Load(object sender, EventArgs e)
        {
            RangeNumber.Text = A + " ～ " + B;
            panel0.BorderStyle = BorderStyle.FixedSingle;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderStyle = BorderStyle.FixedSingle; 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(GuessNumber.Text);

            if(guess == ans)
            {
                MessageBox.Show(" Bingo！ ");
                MessageBox.Show(" 再玩一次？ ");
                A = 0;
                B = 50;
                RangeNumber.Text = A + " ～ " + B;
                GuessNumber.Text = " 0 ";
            }
            else if (guess < ans)
            {
                A = guess;
                RangeNumber.Text = A + " ～ " + B;

            }
            else if (guess > ans)
            {
                B = guess;
                RangeNumber.Text = A + " ～ " + B;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            A = 0;
            B = 50;
            RangeNumber.Text = A + " ～ " + B;
            GuessNumber.Text = " 0 ";
        }

    }
}
