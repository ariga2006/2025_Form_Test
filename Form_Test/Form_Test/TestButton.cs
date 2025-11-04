using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public class TestButton : Button
    {
        private Color _onColor = Color.LightBlue;
        private Color _offColor = Color.Wheat;

        private bool _enable;

        private Form1 _form1;

        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
        }

       public TestButton(Form1 form1,Point position , Size size, string text)
        {
            //form1の参照を保管
            _form1 = form1;
            Location = position;
            Size = size;
            Text = text;

            SetEnable(false);

            Click += Click1Event;
        }

        private void Click1Event(object sender, EventArgs e)
        {
            _form1.GetTestButton(1, 1).SetEnable(true);
            

        }
    }
}
