using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SnakeGame
{
    public class Snake
    {
        
        public Point position = new Point(0,0);
       
        public List<Point> snake_body = new List<Point>();
        public Size snake_size = new Size(100,30);

        public void Init_Snake()
        {
            
            for(int i = 0; i < 3; i++)
            {
                position = new Point(position.X+15,position.Y);
                snake_body.Add(position);
                
            }
        }
        public void Move_Snake(int status_key)
        {
            if (status_key == 0)
            {
                
            }
            else if (status_key == 1)
            {

            }
            else if (status_key == 2)
            {

            }
            else if (status_key == 3)
            {

            }


        }

    }
}
