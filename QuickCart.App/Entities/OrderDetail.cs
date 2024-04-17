namespace QuickCart.App.Entities
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Guid OrderId { get; set; }
        public Order? Order { get; set; }

        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
