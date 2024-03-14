namespace ClassicBuilder
{
    internal class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }

        public override string ToString()
        {
            return $"Model : {this.Model}\t Color : {this.Color}\t Seat : {this.Seats} ";
        }
    }
}
