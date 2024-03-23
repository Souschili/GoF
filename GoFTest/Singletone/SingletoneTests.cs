using Autofac;
using DotNetDesignPatternDemos.Creational.Singleton;

namespace GoFTest.Singletone
{
    [TestFixture]
    public class SingletoneTests
    {
        private IContainer _container;
        [SetUp]
        public void SetUp()
        {
            // регистрируем классы и помечаем его как синглтон второй просто регистрируем
            //собираем контейнер теперь они доступны во всех тестах
            var cb = new ContainerBuilder();
            cb.RegisterType<FakeData>()
                .As<IDataBase>()
                .SingleInstance();
 
            cb.RegisterType<ConfigureRecordFinder>();

            _container = cb.Build();
        }

        [TearDown]
        public void TearDown()=>_container.Dispose();

        [Test]
        public void Singletone_OneInstanse_Equal()
        {

            //var db = _container.Resolve<IDataBase>();
            //var db1 = _container.Resolve<IDataBase>();



            var db = SingletoneDatabase.Instance;
            var db1 = SingletoneDatabase.Instance;

            Assert.That(SingletoneDatabase.Count, Is.EqualTo(1));
            Assert.That(db,Is.EqualTo(db1));
        }

        [Test]
        public void DependedTotalPopulationTest()
        {

            //    var db = new FakeData();
            //    var rf=new ConfigureRecordFinder(db);
            var rf = _container.Resolve<ConfigureRecordFinder>();
            Assert.That(
                rf.GetTotalPopulation(new [] {"gamma","alfa"}),
                Is.EqualTo(4));
        }
    }
}
