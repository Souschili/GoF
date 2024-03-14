namespace ClassicBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car=new CarBuilder()
                .SetModel("BMW")
                .SetColor("Black")
                .SetSeat(5)
                .Build();

            Console.WriteLine(car);
        }
    }
}
