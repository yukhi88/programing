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
        double num1;//計算用
        double num2;//計算用
        double work;//仮置き用
        double result;//結果用
        String calc_flg = "+";//四則演算判別フラグ
        Boolean flg = false;//計算の上書き回避
        Boolean calc = false;//四則演算が打たれているか判定       
        Boolean equ_flg = false;//=が連続で押されたかの判定(計算結果表示用)
        Boolean calc_equ = false;//=が連続で押されたかの判定(計算式表示用)
        Boolean new_val = false;//新しい計算式
        Boolean clear_flg = false;//クリアボタンが押せるか判定
        Boolean con_flg = false;//連続計算判定






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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
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

            if (new_val == true)
            {
                flg = false;
                num1 = 0;
                num2 = 0;
                calc_textBox.Text = "";
            }
            calc = false;
            clear_flg = false;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {//=ボタン

            if (equ_flg == false)
            {//=ボタンが四則演算をはさんで押されたとき(計算結果表示用)
                if (flg == true)
                {
                    num2 = double.Parse(textresult.Text);
                }
                else
                {
                    num1 = double.Parse(textresult.Text);
                }
            }
            
            if (calc_flg == "+")//足し算
            {
                result = num1 + num2;
            }
            else if (calc_flg == "-")//引き算
            {
                result = num1 - num2;
            }
            else if (calc_flg == "×")//掛け算
            {
                result = num1 * num2;
            }
            else if (calc_flg == "/")//割り算
            {
                result = num1 / num2;
            }

            if (textresult.Text.EndsWith("."))
            {//計算式が小数点で終わっているとき
                textresult.Text = textresult.Text.Remove(textresult.Text.Length - 1, 1);
            }

            if (num2 == 0)
            {
                calc_textBox.Text = textresult.Text + "+0=";
            }
            else if (calc_equ == false)
            {//=ボタンが四則演算をはさんで押されたとき(計算式表示用)
                calc_textBox.Text += textresult.Text + "=";
                calc_equ = true;
            }
            else if (calc_equ == true)
            {//=ボタンが連続で押されたとき(計算式表示用)
                calc_textBox.Text = textresult.Text + calc_flg + num2.ToString() + "=";
            }

            num1 = result;
            flg = false;
            textresult.Text = result.ToString();
            equ_flg = true;
            calc = true;
            new_val = true;
            clear_flg = true;
            con_flg = false;
        }

        private void button_product_Click(object sender, EventArgs e)
        {//×ボタン
            if (textresult.Text == "")
            {
                //連続で押された時の回避用
            }
            else if (flg == false)
            {
                num1 = double.Parse(textresult.Text);                
                flg = true;
            }
            else if (flg == true)
            {
                num2 = double.Parse(textresult.Text);                
                flg = false;
            }

            if (con_flg == true)
            {//連続計算
                if (calc_flg == "+")//足し算
                {
                    result = num1 + num2;
                }
                else if (calc_flg == "-")//引き算
                {
                    result = num1 - num2;
                }
                else if (calc_flg == "×")//掛け算
                {
                    result = num1 * num2;
                }
                else if (calc_flg == "/")//割り算
                {
                    result = num1 / num2;
                }
                num1 = result;
                flg = true;
                textresult.Text = result.ToString();
            }
            if (textresult.Text.EndsWith("."))
            {//計算式が小数点で終わっているとき
                textresult.Text = textresult.Text.Remove(textresult.Text.Length - 1, 1);
            }

            calc_flg = "×";
            calc = true;
            calc_equ = false;
            calc_textBox.Text = textresult.Text + "×";
            new_val = false;
            equ_flg = false;
            con_flg = true;

        }

        private void button_sum_Click(object sender, EventArgs e)
        {//+ボタン
            if (textresult.Text == "")
            {
                //連続で押された時の回避用
            }
            else if (flg == false)
            {
                num1 = double.Parse(textresult.Text);                
                flg = true;
            }
            else if(flg==true)
            {
                num2 = double.Parse(textresult.Text);                
                flg = false;
            }

            if (con_flg == true)
            {//連続計算
                if (calc_flg == "+")//足し算
                {
                    result = num1 + num2;
                }
                else if (calc_flg == "-")//引き算
                {
                    result = num1 - num2;
                }
                else if (calc_flg == "×")//掛け算
                {
                    result = num1 * num2;
                }
                else if (calc_flg == "/")//割り算
                {
                    result = num1 / num2;
                }
                num1 = result;
                flg = true;
                textresult.Text = result.ToString();
            }

            if (textresult.Text.EndsWith("."))
            {//計算式が小数点で終わっているとき
                textresult.Text = textresult.Text.Remove(textresult.Text.Length - 1, 1);
            }

            calc_flg = "+";
            calc = true;
            calc_equ = false;
            calc_textBox.Text = textresult.Text + "+";
            new_val = false;
            equ_flg = false;
            con_flg = true;

        }

        private void button_difference_Click(object sender, EventArgs e)
        {//-ボタン
            if (textresult.Text == "")
            {
                //連続で押された時の回避用
            }
            else if (flg == false)
            {
                num1 = double.Parse(textresult.Text);                
                flg = true;
            }
            else if (flg == true)
            {
                num2 = double.Parse(textresult.Text);                
                flg = false;
            }

            if (con_flg == true)
            {//連続計算
                if (calc_flg == "+")//足し算
                {
                    result = num1 + num2;
                }
                else if (calc_flg == "-")//引き算
                {
                    result = num1 - num2;
                }
                else if (calc_flg == "×")//掛け算
                {
                    result = num1 * num2;
                }
                else if (calc_flg == "/")//割り算
                {
                    result = num1 / num2;
                }
                num1 = result;
                flg = true;
                textresult.Text = result.ToString();
            }

            if (textresult.Text.EndsWith("."))
            {//計算式が小数点で終わっているとき
                textresult.Text = textresult.Text.Remove(textresult.Text.Length - 1, 1);
            }

            calc_flg = "-";
            calc = true;
            calc_equ = false;
            calc_textBox.Text = textresult.Text + "-";
            new_val = false;
            equ_flg = false;
            con_flg = true;
        }

        private void button_quotient_Click(object sender, EventArgs e)
        {//÷ボタン
            if (textresult.Text == "")
            {
                //連続で押された時の回避用
            }
            else if (flg == false)
            {
                num1 = double.Parse(textresult.Text);                
                flg = true;
            }
            else if (flg == true)
            {
                num2 = double.Parse(textresult.Text);                
                flg = false;
            }

            if (con_flg == true)
            {//連続計算
                if (calc_flg == "+")//足し算
                {
                    result = num1 + num2;
                }
                else if (calc_flg == "-")//引き算
                {
                    result = num1 - num2;
                }
                else if (calc_flg == "×")//掛け算
                {
                    result = num1 * num2;
                }
                else if (calc_flg == "/")//割り算
                {
                    result = num1 / num2;
                }
                num1 = result;
                flg = true;
                textresult.Text = result.ToString();
            }

            if (textresult.Text.EndsWith("."))
            {//計算式が小数点で終わっているとき
                textresult.Text = textresult.Text.Remove(textresult.Text.Length - 1, 1);
            }

            calc_flg = "/";
            calc = true;
            calc_equ = false;
            calc_textBox.Text = textresult.Text + "÷";
            new_val = false;
            equ_flg = false;
            con_flg = true;
        } 

        private void percent_button_Click(object sender, EventArgs e)
        {//％ボタン
            work = double.Parse(textresult.Text);
            work /= 100;
            textresult.Text = work.ToString();
            calc_textBox.Text = textresult.Text;
            calc_equ = false;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {//クリアボタン
            num1 = 0;
            num2 = 0;
            textresult.Text = "0";
            calc_flg="+";
            calc_textBox.Text = "";
            work = 0;
            calc_equ = false;
            calc = false;
            equ_flg = false;
            flg = false;


        }

        private void point_button_Click(object sender, EventArgs e)
        {//.ボタン
            if (textresult.Text.Contains(".") == false)
            {
                textresult.Text += ".";
            }
            calc = false;
            calc_equ = false;
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
            calc_equ = false;
        }

        private void back_button_Click(object sender, EventArgs e)
        {//1文字消す
            if (clear_flg == false)
            {
                {
                    if (textresult.Text.Length == 1 || textresult.Text.Length == 2 && textresult.Text.Contains("-"))
                    {
                        textresult.Text = "0";
                    }
                    else
                    {
                        textresult.Text = textresult.Text.Remove(textresult.Text.Length - 1, 1);
                    }
                }
                
            }
            calc_equ = false;
        }

        private void pow_button_Click(object sender, EventArgs e)
        {//累乗
            work = double.Parse(textresult.Text);
            work = Math.Pow(work, 2);
            textresult.Text = work.ToString();
            calc_equ = false;
        }

        private void fraction_button_Click(object sender, EventArgs e)
        {//分数
            work = double.Parse(textresult.Text);
            work = 1/work;
            calc_textBox.Text ="1/"+ textresult.Text;
            textresult.Text = work.ToString();
            calc_equ = false;

        }

        private void root_button_Click(object sender, EventArgs e)
        {//平方根
            work = double.Parse(textresult.Text);
            work = Math.Sqrt(work);
            calc_textBox.Text = "√" + textresult.Text;
            textresult.Text = work.ToString();
            calc_equ = false;
        }

        private void clear_entry_Click(object sender, EventArgs e)
        {//クリアエントリーボタン
            textresult.Text = "0";
        }
    }
}
