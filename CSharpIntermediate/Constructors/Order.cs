namespace Constructors
{
    public class Order
    {
        public int Id;
        public string ProductName;

        public Order(int id, string productName)
        {
            this.Id = id;
            this.ProductName = productName;
        }
    }
}
