namespace QuickCart.App.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public int UnitPrice { get; set; }
        public int UnitWeight { get; set; }
        public int StockAvailability { get; set; }
        public string? Description { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; } = [];
        public ICollection<ProductReview> ProductReviews { get; set; } = [];
        public ICollection<ShoppingCartItem> ShoppingCarts { get; set; } = [];
    }
}
