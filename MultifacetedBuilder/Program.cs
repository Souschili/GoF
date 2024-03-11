namespace MultifacetedBuilder
{
    class Person
    {
        public string StreetAddress, PostCode, City;

        //employee info
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"StreetAddress: {this.StreetAddress} PostCode: {this.PostCode} City: {this.City}" +
                   $"CompanyName: {this.CompanyName} Position:{this.Position} AnnualIncome: {this.AnnualIncome}";
        }

    }

    // Два строителя + корневой строитель
    // один строит инфо про адресс, а второй инфу про компанию
    class PersonBuilder
    {
        protected Person person;
        public PersonBuilder()
        {
            person = new Person();
        }

        public PersonBuilder(Person person)
        {
            this.person = person;
        }

        // мы переиспользуем персон в разных строителях,а не плодим каждый раз новый
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        public PersonJobBuilder Work => new PersonJobBuilder(person);

        //кастуем в персон читай док микрософта
        public static implicit operator Person(PersonBuilder bd)
        {
            return bd.person;
        }

       
    }

    class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person) : base(person) { }

        public PersonAddressBuilder At(string street)
        {
            this.person.StreetAddress = street;
            return this;
        }
        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
        public PersonAddressBuilder Zip(string postcode)
        {
            person.PostCode = postcode;
            return this;
        }
    }

    class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person) : base(person) { }

        public PersonJobBuilder Company(string company)
        {
            person.CompanyName = company;
            return this;
        }
        public PersonJobBuilder Position(string position)
        {
            person.Position = position;
            return this;
        }
        public PersonJobBuilder Income(int income)
        {
            person.AnnualIncome = income;
            return this;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           PersonBuilder pb=new PersonBuilder();
            // override implicict cast from Person Builder to Person
            Person person = pb.Lives
                .At("R Rustamov 42")
                .In("Baku")
                .Zip("1001")
                .Work
                .Company("Fiojo")
                .Position("Worker")
                .Income(1500);
           Console.WriteLine( person.ToString());
        }
    }
}
