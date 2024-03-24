namespace Multitone
{

    public enum SubSystem
    {
        Main,
        Backup
    }

    public class Printer
    {
        private Printer() { }
        public static Printer Get(SubSystem ss)
        {
            if(_instance.ContainsKey(ss))
                return _instance[ss];
            _instance[ss]= new Printer();
            return _instance[ss];
                
        }
        private static readonly IDictionary<SubSystem, Printer> _instance=
            new Dictionary<SubSystem,Printer>();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var pr1=Printer.Get(SubSystem.Main);
            var pr2=Printer.Get(SubSystem.Backup);
            var pr3=Printer.Get(SubSystem.Backup);

            Console.WriteLine(ReferenceEquals(pr2,pr3));
        }
    }
}
