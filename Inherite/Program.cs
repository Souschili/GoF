using System.Threading.Channels;

namespace Inherite
{

    // super base class
    class Person
    {
        private string _name;
        public string Name { get { return _name; }set { _name = value;} }

        public void Print() => Console.WriteLine(_name);


        public override string ToString()
        {
            return this._name;
        }
    }
    //607 Aida
    // 799-607=192
    class Employee:Person
    {
        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //наследование реализует отношение is-a (является),
            //объект класса Employee также является объектом класса Person:
            Person person = new Person { Name = "Tom" };
            person.Print();   // Tom
            person = new Employee { Name = "Sam" };
            person.Print();   // Sam
        }
    }
}
