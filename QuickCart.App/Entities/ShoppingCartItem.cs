namespace QuickCart.App.Entities
{
    public class ShoppingCartItem
    {
        public int Quantity { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
