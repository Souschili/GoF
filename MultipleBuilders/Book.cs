namespace MultipleBuilders
{
    public class Book
    {
        public string Name { get; set; } = String.Empty;
        public string Author { get; set; } = String.Empty;
        public string Description { get; set; }= String.Empty;
        public int Pages { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}  Author: {Author} Description: {this.Description}" +
                $"Pages: {this.Pages} Price: {this.Price}";
        }
    }
}
