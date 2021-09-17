using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiDifferenceHunt
{
    public partial class FormGame : Form
    {
        string correctText = "塊";//正解の文字
        string mistakeText = "魂";//間違いの文字
        double nowTime;//経過時間
        public FormGame()
        {
            InitializeComponent();
        }
        //25個のボタンのいずれかをクリックしたとき
        private void buttons_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == correctText)
            {
                timer1.Stop();//時間の計測終了
            }
            else
            {
                nowTime = nowTime + 10;//ペナルティー
            }
        }
        //スタートをクリッくしたとき
        private void buttonStart_Click(object sender, EventArgs e)
        {
            textHunt.Text = correctText;
            Random rnd = new Random();
            int randomeResult = rnd.Next(25);

            for(int i = 0; i < splitContainer1.Panel2.Controls.Count; i++)
            {
                splitContainer1.Panel2.Controls[i].Text = mistakeText;
            }
            splitContainer1.Panel2.Controls[randomeResult].Text = correctText;

            //タイマースタート
            nowTime = 0;//タイマーの初期化
            timer1.Start();
        }
        //0.02秒置きに呼ばれるタイマーのイベントハンドラ
        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime = nowTime + 0.02;
            textTimer.Text = nowTime.ToString("0.00");
        }
    }
}
