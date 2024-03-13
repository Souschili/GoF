namespace BookBuilderFluent
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var book=new BookBuilder()
                .Name("Tom Cat")
                .Author("Orkhan")
                .Description("Book for children")
                .Build();

            Console.WriteLine(book);
        }
    }
}
