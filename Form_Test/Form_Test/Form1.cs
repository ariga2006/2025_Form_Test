using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        //const をつけると初期値のみ値の変更をすることができる
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOATD_SIZE_X = 3;
        const int BOATD_SIZE_Y = 3;

        private TestButton[,] _buttonArray;



        public Form1()
        {
            InitializeComponent();
            _buttonArray = new TestButton[BUTTON_SIZE_Y, BUTTON_SIZE_X];
            for (int i = 0; i < BOATD_SIZE_X; i++)
            {
                for (int j = 0; j < BOATD_SIZE_Y; j++)
                {


                    //インスタンスの生成
                    TestButton testButton = new TestButton(this, i, j, new Point(BUTTON_SIZE_X * j, BUTTON_SIZE_Y * i),
                        new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),"あいうえお");
                   
                    _buttonArray[j, i] = testButton;

                    //コントロールにボタンを追加
                    Controls.Add(testButton);
                }

            }
            



        }

        public TestButton GetTestButton(int x, int y)
        {
            return _buttonArray[x, y];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ！");

        }
    }
}
