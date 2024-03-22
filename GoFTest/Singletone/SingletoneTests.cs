using DotNetDesignPatternDemos.Creational.Singleton;

namespace GoFTest.Singletone
{
    [TestFixture]
    public class SingletoneTests
    {
        [Test]
        public void Singletone_OneInstanse_Equal()
        {
            var db=SingletoneDatabase.Instance;
            var db1=SingletoneDatabase.Instance;

            Assert.That(db.Count, Is.EqualTo(1));
            Assert.That(db,Is.EqualTo(db1));
            Assert.That(db.Count, Is.EqualTo(db1.Count));
        }
    }
}
