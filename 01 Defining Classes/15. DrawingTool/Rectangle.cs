using System;
using System.Linq;

namespace _15.DrawingTool
{
    public class Rectangle
    {
        private int length;
        private int sideLength;

        public Rectangle(int length, int sideLength)
        {
            this.length = length;
            this.sideLength = sideLength;
        }

        public void Draw(int length, int sideLength)
        {
            Console.WriteLine('|' + new string('-', length) + '|');

            for (int i = 0; i < sideLength - 2; i++)
            {
                Console.WriteLine('|' + new string(' ', length) + '|');
            }

            Console.WriteLine('|' + new string('-', length) + '|');
        }
    }
}
