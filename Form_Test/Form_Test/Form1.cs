﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {


                    //インスタンスの生成
                    TestButton testButton = new TestButton(new Point(50 * i, 50 * j),new Size(50, 50),"あいうえお");
          
                    //コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ！");

        }
    }
}
