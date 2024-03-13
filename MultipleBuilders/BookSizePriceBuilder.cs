using MultiplekdBuilders;

namespace MultipleBuilders
{
    public class BookSizePriceBuilder : BookBuilder
    {
        public BookSizePriceBuilder(Book book) : base(book) { }

        public BookSizePriceBuilder AddPages(int size)
        {
            this.book.Pages = size;
            return this;
        }
        public BookSizePriceBuilder AddPrice(decimal price)
        {
            this.book.Price = price;
            return this;
        }
    }
}
