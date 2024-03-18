namespace CopyConstructor
{
    class Address 
    {
        public string StreetName;
        public int Home;

        public Address(Address other)
        {
            this.StreetName = other.StreetName;
            this.Home = other.Home;
        }

        public Address(string streetName, int home)
        {
            StreetName = streetName;
            Home = home;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {this.StreetName}\t{nameof(Home)}: {this.Home}";
        }
    }
    class Person 
    {
        public string[] Names;
        public Address Address;

        public Person(Person other)
        {
            Names = new string[other.Names.Length];
            Array.Copy(other.Names, Names,other.Names.Length);
            Address = new Address(other.Address);
        }

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {String.Join(' ', Names)}\t {nameof(Address)}: {Address} ";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] { "John,Smith" },
                   new Address("Backer street ", 123));

            var jane = new Person(john);
            jane.Names[0] = "Aida";
            jane.Address.Home = 111;

            // names didn't copy
            // fix chec cloneable method
            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}
