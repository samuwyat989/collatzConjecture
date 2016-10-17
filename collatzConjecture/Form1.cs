using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace collatzConjecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Graphics col = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            Font font = new Font("TimeNewRoman", 9);

            
            col.DrawString("INPUT NUMBER:" + inputButton.Text, font, brush, 20, 20);
            int loopNumber = 100;
            int x = Convert.ToInt32(inputButton.Text);
            int y = 50;

            for (int i = 0; i < loopNumber; i++)
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                    col.DrawString(Convert.ToString(x), font, brush, 20, y);
                    y = y + 20;
                    Thread.Sleep(1000);
                }

                else if (x == 1) 
                {
                    Thread.Sleep(3000);
                    col.Clear(Color.White);
                    break;  
                } 

                else
                {
                    x = 3 * x + 1;
                    col.DrawString(Convert.ToString(x), font, brush, 20, y);
                    y = y + 20;
                    Thread.Sleep(1000);
                }
            }


            
        }
    }
}
