using System;
using System.Linq;

namespace _15.DrawingTool
{
    public class Square
    {
        private int length;

        public Square(int legnth)
        {
            this.length = legnth;
        }

        public void Draw(int length)
        {
            Console.WriteLine('|' + new string('-', length) + '|');

            for (int i = 0; i < length - 2; i++)
            {
                Console.WriteLine('|' + new string(' ', length) + '|');
            }

            Console.WriteLine('|' + new string('-', length) + '|');
        }
    }
}
