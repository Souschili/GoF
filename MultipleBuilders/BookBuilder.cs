using MultipleBuilders;

namespace MultiplekdBuilders
{
    public class BookBuilder
    {
        protected Book book;
        public BookBuilder()=> book = new Book();

        public BookBuilder(Book book) => this.book = book;

        // call concrete builder
        public BookMainInfoBuilder MainInfo => new BookMainInfoBuilder(book);
        public BookSizePriceBuilder NotMain => new BookSizePriceBuilder(book);

        // implicit cast or we can use Build method 2 alternative variant
        public Book Build ()
        {
            return book;
        }
        public static implicit operator Book(BookBuilder bd)
        {
            return bd.book;
        }
    }
}
