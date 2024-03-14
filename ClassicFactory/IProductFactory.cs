namespace ClassicFactory
{
    internal interface IProductFactory
    {
        AbstractProduct Create(string name);
    }
}
