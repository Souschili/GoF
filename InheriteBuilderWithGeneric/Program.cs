namespace InheriteBuilderWithGeneric
{
    public class Person
    {
        public string Name;

        public string Position;

        public int Money;


        // not SOLID ? if we add new field and add new builder
        // we need change PersonMoney to las builder class
        public class Builder:PersonMoneyBuilder<Builder>
        {
            internal Builder() { }
        }

        public static Builder New=> new Builder();
    }

    public abstract class PersonBuilder
    {
        protected Person person=new Person();

        public Person Build()
        {
            return person;
        }
    }

    public class PersonInfoBuilder<SELF> : PersonBuilder
        where SELF : PersonInfoBuilder<SELF>
    {
        public SELF AddName(string name)
        {
            this.person.Name = name;
            return (SELF)this;
        }
    }

    public class PersonJobBuilder<SELF>: PersonInfoBuilder<SELF>
        where SELF:PersonJobBuilder<SELF>
    {
        public SELF Position(string position)
        {
            this.person.Position = position;
            return (SELF)this;
        }
    }

    public class PersonMoneyBuilder<SELF>:PersonJobBuilder<SELF>
        where SELF:PersonMoneyBuilder<SELF>
    {
        public SELF Money(int money)
        {
            this.person.Money = money;
            return (SELF)this;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // recursive generics fluent builder
            var me = Person.New
                .AddName("sauron")
                .Position("King")
                .Money(500)
                .Build();
        }
    }
}
