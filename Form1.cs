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

namespace MultiThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rd; //Se declara la variable rd.

        private void btnHilo1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(t =>
              {
                  for (int i = 0; i < 100; i++)
                  {
                      int width = rd.Next(0, this.Width);
                      int height = rd.Next(50, this.Height);
                      this.CreateGraphics().DrawEllipse(new Pen(Brushes.Red, 2), new Rectangle(width, height, 10, 10));
                      //Delay
                      Thread.Sleep(100);
                  } 
              })
            { IsBackground = true };
            thread.Start();
        }

        private void btnHilo2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(testc =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 2), new Rectangle(width, height, 15, 15));
                    //Delay
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            rd = new Random();
        }

        private void btnHilo3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(testc =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Green, 2), new Rectangle(width, height, 15, 15));
                    //Delay
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            thread.Start();
        }
    }
}