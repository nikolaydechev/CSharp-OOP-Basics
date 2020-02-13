using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.RectangleIntersection
{
    public class RectangleIntersection
    {
        public static void Main()
        {
            var rectangles = new List<Rectangle>();
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var numberOfRectangles = input[0];
            var intersectionChecks = input[1];

            for (int i = 0; i < numberOfRectangles; i++)
            {
                string[] data = Console.ReadLine().Split();
                var rectangle = new Rectangle(
                                            data[0],
                                            double.Parse(data[1]),
                                            double.Parse(data[2]),
                                            double.Parse(data[3]),
                                            double.Parse(data[4]));

                rectangles.Add(rectangle);
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                string[] idsData = Console.ReadLine().Split();
                var firstRectangle = rectangles.First(x => x.ID == idsData[0]);
                var secondRectangle = rectangles.First(x => x.ID == idsData[1]);

                Console.WriteLine(firstRectangle.AreTheyIntersecting(secondRectangle) ? "true" : "false");
            }
        }
    }
}

