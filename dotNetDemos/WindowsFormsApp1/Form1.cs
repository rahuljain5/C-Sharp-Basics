using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Red Rect
            Graphics red = panel1.CreateGraphics();
            Random rnd = new Random();
            Task task = Task.Factory.StartNew(() =>
            {
                for (int i = 1;; i++)
                {
                    ct.ThrowIfCancellationRequested();
                    int x = rnd.Next(panel1.Height);
                    int y = rnd.Next(panel1.Width);
                    red.DrawEllipse(Pens.Red, x, y, 10, 10);
                    Thread.Sleep(100);
                }
            }, ct);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics blue = panel2.CreateGraphics();
            Random rnd = new Random();
            Task task = Task.Factory.StartNew(() =>
            {
             for (int i = 1;; i++)
                {
                    ct.ThrowIfCancellationRequested();
                    int x = rnd.Next(panel2.Height);
                    int y = rnd.Next(panel2.Width);
                    blue.DrawRectangle(Pens.Blue, x, y, 10, 10);
                    Thread.Sleep(100);
                }
            },ct);
        }
        CancellationToken ct;
        private void button3_Click(object sender, EventArgs e)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            ct = cts.Token;
            cts.Cancel();
        }
    }
}
