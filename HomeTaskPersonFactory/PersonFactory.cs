namespace HomeTaskPersonFactory
{
    public class PersonFactory
    { 
        public Person CreatePerson(string name)
        {
            return new Person {Name=name};
        }
    }
}
