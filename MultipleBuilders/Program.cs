
using MultiplekdBuilders;

namespace MultipleBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bd=new BookBuilder();
           Book book= bd.MainInfo.AddName("Demo builder")
                .AddAuthor("Orkhan")
                .Description("test myself")
                .NotMain
                .AddPages(500)
                .AddPrice(15.70m);
            Console.WriteLine(book);
        }
    }
}
