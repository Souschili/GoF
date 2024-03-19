namespace HomeTask
{
    public class Point
    {
        public int X, Y;
        // add this
        public Point(int x, int y)
        {
            X = x;
            Y = y;

        }

        public override string ToString()
        {
            return $"X: {this.X}\tY: {this.Y} ";
        }
    }

    public class Line
    {
        public Point Start, End;

        public Line DeepCopy()
        {
            // copy all in less lines of code or we can use serializer
            var over = new Line();
            over.Start = new Point(this.Start.X,this.Start.Y);
            over.End = new Point(this.End.X,this.End.Y);
            return over;

        }
        public override string ToString()
        {
            return $"Start :{Start}\t End: {End}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Line foo1 = new Line();
            foo1.Start = new Point(100, 25);
            foo1.End = new Point(75, 65);

            Line foo2 = foo1.DeepCopy();
            foo2.Start.X = 120;
            foo2.Start.Y = 45;
            Console.WriteLine(foo1);
            Console.WriteLine(foo2);

        }
    }
}
