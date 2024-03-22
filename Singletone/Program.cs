using System;

namespace DotNetDesignPatternDemos.Creational.Singleton
{
    public class FakeData
    {
        public static IDictionary<string, int> GetData() =>
            new Dictionary<string, int>
            {
                {"Baku",2000000 },
                {"Moscow",8000000 },
                {"Deli",14500000 },
                {"Tokio",17500000 },
                {"Oslo",750000 },
                {"Riga",840000 },

            };
    }

    public class SingletoneDatabase
    {
        private IDictionary<string, int> _capitals = new Dictionary<string, int>();

        // для проверки сколько инстансов созданно
        private static int _instanceCount = 0;
        public int Count => _instanceCount;

        // загружаем фейковые данные из генератора фейков (каламбур)
        public SingletoneDatabase()
        {
            _capitals = FakeData.GetData();
        }

        public int GetPopulation(string city) =>
            _capitals[city];

        private static Lazy<SingletoneDatabase> _instance =
             new Lazy<SingletoneDatabase>(() =>
             {
                 _instanceCount++; //счетчик объектов
                 return new SingletoneDatabase();
             });

        // возвращаем в публичном методе
        public static SingletoneDatabase Instance => _instance.Value;
    }
    public class Program
    {
        static void Main()
        {
            var db = SingletoneDatabase.Instance;
            var city = "Baku";
            Console.WriteLine($"{city} has population {db.GetPopulation(city)}");
        }
    }

}
