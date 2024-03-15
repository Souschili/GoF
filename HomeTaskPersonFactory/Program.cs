namespace HomeTaskPersonFactory
{
    /*
     реализуйте нестатическую фабрику PersonFactory
    у которой есть метод CreatePerson()  который принимает имя человека.
    Поле Id этого человека должно быть инициализированно счетчиком (начиная с нуля)
    объекта по мере создания. 
    Иначе говоря, первый человек получает Id=0, второй Id=1, и так далее.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            var factory = new PersonFactory();
            for (int i = 0; i < 10; i++)
            {
                // give all person name +postfix
                list.Add(factory.CreatePerson($"Person{i}"));
            }

            //check id
            foreach (var item in list)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} ");
            }

        }
    }
}
