namespace _15.DrawingTool
{
    public class CorDraw
    {
        private Square square;
        private Rectangle rectangle;

        public Square Square { get { return this.square; } }
        public Rectangle Rectangle { get { return this.rectangle; } }

        public CorDraw(Square square)
        {
            this.square = square;
        }

        public CorDraw(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }
    }
}
