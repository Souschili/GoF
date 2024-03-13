namespace InheriteBuilderWithGeneric
{
    public class Person
    {
        public string Name;

        public string Position;

        public static PersonInfoBuilder New => new PersonInfoBuilder();
    }

    public abstract class PersonBuilder
    {
        protected Person person=new Person();

        public Person Build()
        {
            return person;
        }
    }

    public class PersonInfoBuilder : PersonBuilder
    {
        public PersonBuilder AddName(string name)
        {
            this.person.Name = name;
            return this;
        }
    }

   // public class PersonJobBuilder:

    internal class Program
    {
        static void Main(string[] args)
        {
            var me=Person.New.AddName("Aida");
        }
    }
}
