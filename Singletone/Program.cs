using System;

namespace DotNetDesignPatternDemos.Creational.Singleton
{
    public class FakeData:IDataBase
    {
        //imitation of real database
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

        // for unit testing stable data set
        public int GetPopulation(string city)
        {
            return new Dictionary<string, int>
            {
                ["alfa"] = 1,
                ["beta"] = 2,
                ["gamma"] = 3
            }[city]; 
            // тут мы сразу получаем значение например если сити гамма то ответ 3
        }
    }

    // высокоуровневая абстракция 
    public interface IDataBase
    {
        int GetPopulation(string city);
    }



    public class SingletoneDatabase:IDataBase
    {
        private IDictionary<string, int> _capitals = new Dictionary<string, int>();

        // для проверки сколько инстансов созданно
        private static int _instanceCount = 0;
        public static int Count => _instanceCount;

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

        public int TotalPopulation(IEnumerable<string> names)
        {
            int result=0;
            foreach (var name in names)
            {
                result += Instance.GetPopulation(name);
            }
            return result;
        }


        // возвращаем в публичном методе
        public static SingletoneDatabase Instance => _instance.Value;
    }

    // here we use DI for singletone
    public class ConfigureRecordFinder
    {
        private IDataBase _db;
        public ConfigureRecordFinder(IDataBase db)
        {
            this._db=db;
        }

        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result=0;
            foreach (var name in names)
            {
                result += _db.GetPopulation(name);
            }
            return result;
        }
    }
    public class Program
    {
        static void Main()
        {
       
            //var db = SingletoneDatabase.Instance;

            //var city = "Baku";
            //Console.WriteLine($"{city} has population {db.GetPopulation(city)}");
        }
    }

    

}
