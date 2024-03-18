namespace Cloneabel
{
    // This bad variant but...

    class Address : ICloneable
    {
        public string StreetName;
        public int Home;

        public Address(string streetName, int home)
        {
            StreetName = streetName;
            Home = home;
        }

        public object Clone()
        {
            // shallow copy
            //return MemberwiseClone();
            // we need by our self create new object
            return new Address(StreetName, Home);

        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {this.StreetName}\t{nameof(Home)}: {this.Home}";
        }
    }
    class Person : ICloneable
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public object Clone()
        {
            //shallow copy
            // return MemberwiseClone();

            // create object by our self
            string[] copyName = new string[Names.Length];
            Array.Copy(Names, copyName, Names.Length);
            return new Person(copyName, (Address)Address.Clone());
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

                var jane = (Person)john.Clone();
                jane.Names[0] = "Aida";
                jane.Address.Home = 111;

                // names didn't copy
                // fix chec cloneable method
                Console.WriteLine(john);
                Console.WriteLine(jane);
            }
        }
    
}
