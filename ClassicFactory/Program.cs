namespace ClassicFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractProduct product = new CarFactory().Create();
            Console.WriteLine(product.GetProductName());
        }
    }
}
