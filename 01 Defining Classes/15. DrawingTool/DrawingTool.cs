using System;

namespace _15.DrawingTool
{
    public class DrawingTool
    {
        public static void Main()
        {
            var typeFigure = Console.ReadLine();

            switch (typeFigure)
            {
                case "Square":
                    var length = int.Parse(Console.ReadLine());
                    var corDraw = new CorDraw(new Square(length));
                    corDraw.Square.Draw(length);
                    break;

                case "Rectangle":
                    length = int.Parse(Console.ReadLine());
                    var sideLength = int.Parse(Console.ReadLine());
                    corDraw = new CorDraw(new Rectangle(length, sideLength));
                    corDraw.Rectangle.Draw(length, sideLength);
                    break;
            }
        }
    }
}
