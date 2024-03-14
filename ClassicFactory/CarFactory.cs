namespace ClassicFactory
{
    internal class CarFactory : IProductFactory
    {
        public AbstractProduct Create(string name="none")
        {
            return new Car(name);
        }
    }
}
