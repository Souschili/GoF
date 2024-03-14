namespace SimpleFactory
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            // generate console output  
            var point = Point.PointFactory.NewCartezianPoint(100, 45);

        }
    }
}
