namespace BookBuilderFluent
{
    public  class Book
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }=String.Empty;
        public string Author { get; set; }=string.Empty;
        public override string ToString()
        {
            return $"Author : {this.Author} Description : {this.Description} Name : {this.Name}";
        }
    }
}
