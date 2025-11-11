using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
            Random rand = new Random();


            InitializeComponent();
            _buttonArray = new TestButton[BUTTON_SIZE_Y, BUTTON_SIZE_X];
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {


                    //インスタンスの生成
                    TestButton btn = new TestButton(this, j, i,
                                         new Point(BUTTON_SIZE_X * j, BUTTON_SIZE_Y * i),
                                         new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),
                                          "あいうえお");


                    // 初期状態をランダムに設定（true か false）
                    bool initialState = rand.Next(2) == 0;
                    btn.SetEnable(initialState);




                    _buttonArray[j, i] = btn;

                    //コントロールにボタンを追加
                    Controls.Add(btn);
                }

            }
            



        }
        private void RandomizeBoard()
        {
            Random rand = new Random();

            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                    bool newState = rand.Next(2) == 0;
                    _buttonArray[i, j].SetEnable(newState);
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
        public void CheckClearByColor()
        {
            
            

             Color firstColor = _buttonArray[0, 0].BackColor;

             for (int i = 0; i < BOARD_SIZE_X; i++)
             {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                     if (_buttonArray[i, j].BackColor != firstColor)
                        return; // 1つでも違えばクリアじゃない
                }
             }

                MessageBox.Show("クリア！全部同じ色です！");
            RandomizeBoard();

        }



    }
}
