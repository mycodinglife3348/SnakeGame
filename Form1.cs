using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private Snake snake = new Snake();
        Size snake_size;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Width = 800;
            this.Height = 600;
            snake.Init_Snake();
            snake_size = snake.snake_size;
            Thread thread = new Thread(()=> {
                while (true)
                {
                    this.Invalidate();
                    Thread.Sleep(50);

                }
            });
            thread.Start();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(0,0,800,600));
            foreach(Point position in snake.snake_body)
            {
                e.Graphics.FillRectangle(Brushes.Black,new Rectangle(position.X, position.Y, snake_size.Width, snake_size.Height));
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                snake.Move_Snake(0);
                return;
            }
            else if(e.KeyCode == Keys.Down)
            {
                snake.Move_Snake(1);

                return;
            }
            else if(e.KeyCode == Keys.Left)
            {
                snake.Move_Snake(2);

                return;
            }
            else if(e.KeyCode == Keys.Right)
            {
                snake.Move_Snake(3);


                return;
            }
        }
    }
}
