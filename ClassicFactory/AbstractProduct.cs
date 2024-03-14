namespace ClassicFactory
{
    internal abstract class AbstractProduct
    {
        protected string _productName;
        public string GetProductName() => this._productName;
    }
   
}
