namespace Monostate
{
    // нужен в ситуации когда надо превратить класс в синглтон 
    // То есть в коде много обьектов new SuperOfficeRules()
    // ,а надо ничего неизменяя сделать
    // так чтобы везде использовался один  инстанс класса везде в коде

    public class MainConfigState
    {
        private static bool _isActive;
        private static string _name=string.Empty;

        // связываем публичные поля со статическими
        public bool isActive {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        // конструктор по умолчанию присутствует но не инициализирует поля
        // используется свойство через точечную аннотацию для инициализации
    }



    
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1=new MainConfigState();
            t1.Name = "temp1";
            t1.isActive = true;
            var t2=new MainConfigState();
            Console.WriteLine($"{t2.Name} {t2.isActive}");
        }
    }
}
