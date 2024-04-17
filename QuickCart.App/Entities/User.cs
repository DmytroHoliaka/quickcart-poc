namespace QuickCart.App.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public Guid? AddressId { get; set; }
        public Address? Address { get; set; }

        public ICollection<ShoppingCartItem>? ShoppingCart { get; set; }
        public ICollection<Order> Orders { get; set; } = [];
        public ICollection<ProductReview> ProductReviews { get; set; } = [];
    }
}
