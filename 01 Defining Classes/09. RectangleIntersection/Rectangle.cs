namespace _09.RectangleIntersection
{
    public class Rectangle
    {
        private readonly string id;
        private readonly double width;
        private readonly double height;
        private readonly double x;
        private readonly double y;

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public string ID { get { return this.id; } }
        public double Width { get { return this.width; } }
        public double Height { get { return this.height; } }
        public double X { get { return this.x; } }
        public double Y { get { return this.y; } }

        public bool AreTheyIntersecting(Rectangle rectangle)
        {
            if (Width + X < rectangle.X || rectangle.Width + rectangle.X < X || Y + Height < rectangle.Y || rectangle.Y + rectangle.Height < Y)
            {
                return false;
            }
            return true;
        }
    }
}
