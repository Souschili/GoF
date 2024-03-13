namespace BookBuilderFluent
{
    public class BookBuilder
    {
        private Book Book;
        public BookBuilder()
        {
            this.Book = new Book();
        }

        // fluent builder method
        public BookBuilder Name(string name)
        {
            this.Book.Name = name;
            return this;
        }
        public BookBuilder Description(string description)
        {
            this.Book.Description = description;
            return this;
        }
        public BookBuilder Author(string author)
        {
            this.Book.Author = author;
            return this;
        }

        public Book Build()
        {
            return this.Book;
        }
    }
}
