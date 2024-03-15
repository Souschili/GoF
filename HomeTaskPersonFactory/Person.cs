namespace HomeTaskPersonFactory
{
    public class Person
    {
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Person()
        {
            this.Id = _id;
            _id++;
        }
    }
}
