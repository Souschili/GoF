using MultiplekdBuilders;

namespace MultipleBuilders
{
    public  class BookMainInfoBuilder:BookBuilder
    {
        public BookMainInfoBuilder(Book book):base(book) { }
        
        public BookMainInfoBuilder AddName(string name)
        {
            this.book.Name = name;
            return this;
        }
        public BookMainInfoBuilder AddAuthor(string name)
        {
            this.book.Author = name;
            return this;
        }
        public BookMainInfoBuilder Description(string description)
        {
            this.book.Description = description;
            return this;
        }
    }
}
