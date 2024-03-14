namespace SimpleFactory
{
    public class Point
    {
        private double x, y;

        private Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        // add new static  instance
        // now we not use Point.PointFactory ...
        // we can use Point.Factory.CartesianPoint(x,y)
        public static PointFactory Factory = new PointFactory();

        // include factory into Point class and make ctor private :0)
        public class PointFactory
        {
            public static Point NewCartezianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Sin(rho), theta * Math.Sin(theta));
            }
        }

    }
}
