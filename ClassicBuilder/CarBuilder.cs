namespace ClassicBuilder
{
    internal class CarBuilder : ICarBuilder
    {
        private Car _car;
        public CarBuilder() { this._car = new Car(); }

        public Car Build()
        {
           return this._car;
        }

        public ICarBuilder SetColor(string color)
        {
            this._car.Color = color;
            return this;
        }

        public ICarBuilder SetModel(string model)
        {
            this._car.Model = model;
            return this;
        }

        public ICarBuilder SetSeat(int seat)
        {
            this._car.Seats=seat;
            return this;
        }
    }
}
