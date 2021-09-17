using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }
        double num1;
        double num2;
        int flg = 0;//計算の上書き回避
        String calc_flg;//四則演算判別フラグ
        double result;//結果用
        Boolean calc = false;//四則演算が打たれているか判定
        double work;//仮置き用
        
        
        
        
       
        private void button1_Click(object sender, EventArgs e)
        {//1ボタン

            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "1";                
            }
            else
            {
                textresult.Text += "1";               
            }
            calc = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {//2ボタン
            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "2";                
            }
            else
            {
                textresult.Text += "2";                
            }
            calc = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {//3ボタン
            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "3";               
            }
            else
            {
                textresult.Text += "3";                
            }
            calc = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {//4ボタン
            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "4";                
            }
            else
            {
                textresult.Text += "4";               
            }
            calc = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {//5ボタン
            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "5";                
            }
            else
            {
                textresult.Text += "5";               
            }
            calc = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {//6ボタン
            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "6";                
            }
            else
            {
                textresult.Text += "6";                
            }
            calc = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {//7ボタン
            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "7";                
            }

            else
            {
                textresult.Text += "7";                
            }
            calc = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {//8ボタン
            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "8";
            }
            else
            {
                textresult.Text += "8";
            }
            calc = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {//9ボタン
            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "9";                
            }
            else
            {
                textresult.Text += "9";                
            }
            calc = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {//0ボタン
            if (textresult.Text == "0" || calc == true)
            {
                textresult.Text = "0";                
            }
            else
            {
                textresult.Text += "0";
            }
            calc = false;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {//=ボタン
            calc_textBox.Text += textresult.Text+"=";
            if (flg == 1)
            {
                num2 = double.Parse(textresult.Text);
            }
            if (calc_flg == "+")//足し算
            {
                result = num1 + num2;
            }
            else if (calc_flg == "-")//引き算
            {
                result = num1 - num2;
            }
            else if (calc_flg == "*")//掛け算
            {
                result = num1 * num2;
            }
            else if (calc_flg == "/")//割り算
            {
                result = num1 / num2;
            }
            num1 = result;
            flg = 1;
            textresult.Text = result.ToString();
            
            
           
            calc = true;

        }

        private void button_product_Click(object sender, EventArgs e)
        {//×ボタン
            if (textresult.Text == "")
            {
                //連続で押された時の回避用
            }
            else if (flg == 0)
            {
                num1 = double.Parse(textresult.Text);                
                flg = 1;
            }
            else if (flg == 1)
            {
                num2 = double.Parse(textresult.Text);                
                flg = 0;
            }
            calc_flg = "*";
            calc = true;
            calc_textBox.Text = textresult.Text + "×";

        }

        private void button_sum_Click(object sender, EventArgs e)
        {//+ボタン
            if (textresult.Text == "")
            {
                //連続で押された時の回避用
            }
            else if (flg == 0)
            {
                num1 = double.Parse(textresult.Text);                
                flg = 1;
            }
            else if(flg==1)
            {
                num2 = double.Parse(textresult.Text);                
                flg = 0;
            }
            calc_flg = "+";
            calc = true;
            calc_textBox.Text = textresult.Text + "+";



        }

        private void button_difference_Click(object sender, EventArgs e)
        {//-ボタン
            if (textresult.Text == "")
            {
                //連続で押された時の回避用
            }
            else if (flg == 0)
            {
                num1 = double.Parse(textresult.Text);                
                flg = 1;
            }
            else if (flg == 1)
            {
                num2 = double.Parse(textresult.Text);                
                flg = 0;
            }
            calc_flg = "-";
            calc = true;
            calc_textBox.Text = textresult.Text + "-";

        }

        private void button_quotient_Click(object sender, EventArgs e)
        {//÷ボタン
            if (textresult.Text == "")
            {
                //連続で押された時の回避用
            }
            else if (flg == 0)
            {
                num1 = double.Parse(textresult.Text);                
                flg = 1;
            }
            else if (flg == 1)
            {
                num2 = double.Parse(textresult.Text);                
                flg = 0;
            }
            calc_flg = "/";
            calc = true;
            calc_textBox.Text = textresult.Text + "÷";

        } 

        private void percent_button_Click(object sender, EventArgs e)
        {//％ボタン
            work = double.Parse(textresult.Text);
            work /= 100;
            textresult.Text = work.ToString();
            calc_textBox.Text = textresult.Text;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {//クリアボタン
            num1 = 0;
            num2 = 0;
            textresult.Text = "0";
            calc_flg="";
            calc_textBox.Text = "";
           
        }

        private void point_button_Click(object sender, EventArgs e)
        {//.ボタン
            if (textresult.Text.Contains(".") == false)
            {
                textresult.Text += ".";
            }
            calc = false;
        }

        private void plus_minus_Click(object sender, EventArgs e)
        {//プラスとマイナス変換
            if (textresult.Text.Contains("-") == false && textresult.Text != "0")
            {
                textresult.Text = textresult.Text.Insert(0, "-");
            }                  
            
            else
            {
                textresult.Text = textresult.Text.Trim('-');
                
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {//1文字消す
            calc_textBox.Text = "";
            if (textresult.Text.Length == 1|| textresult.Text.Length==2&&textresult.Text.Contains("-"))
            {
                textresult.Text = "0";
            }
            else
            {
                textresult.Text = textresult.Text.Remove(textresult.Text.Length - 1, 1);
            }
        }

        private void pow_button_Click(object sender, EventArgs e)
        {//累乗
            work = double.Parse(textresult.Text);
            work = Math.Pow(work, 2);
            textresult.Text = work.ToString();
        }

        private void fraction_button_Click(object sender, EventArgs e)
        {//分数
            work = double.Parse(textresult.Text);
            work = 1/work;
            calc_textBox.Text ="1/"+ textresult.Text;
            textresult.Text = work.ToString();
            
        }

        private void root_button_Click(object sender, EventArgs e)
        {//平方根
            work = double.Parse(textresult.Text);
            work = Math.Sqrt(work);
            calc_textBox.Text = "√" + textresult.Text;
            textresult.Text = work.ToString();
        }
    }
}
