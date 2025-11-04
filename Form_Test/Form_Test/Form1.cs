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

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        private TestButton[,] _buttonArray;



        public Form1()
        {
            InitializeComponent();
            _buttonArray = new TestButton[BUTTON_SIZE_Y, BUTTON_SIZE_X];
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {


                    //インスタンスの生成
                    TestButton testButton = new TestButton(this, j, i, new Point(BUTTON_SIZE_X * j, BUTTON_SIZE_Y * i),
                        new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),"あいうえお");

                    _buttonArray[j, i] = testButton;

                    //コントロールにボタンを追加
                    Controls.Add(testButton);
                }

            }
            



        }

        public TestButton GetTestButton(int x, int y)
        {
            if (x < 0 || x >= BOARD_SIZE_X) return null;
            if (y < 0 || y >= BOARD_SIZE_Y) return null;

            return _buttonArray[x, y];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ！");

        }
    }
}
