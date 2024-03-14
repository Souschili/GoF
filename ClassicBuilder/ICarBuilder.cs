namespace ClassicBuilder
{
    internal interface ICarBuilder
    {
        ICarBuilder SetModel(string model);
        ICarBuilder SetColor(string color);
        ICarBuilder SetSeat(int seat);
        Car Build();
    }
}
