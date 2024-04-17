namespace QuickCart.App.Entities
{
    public class ProductReview
    {
        public Guid ProductReviewId { get; set; }
        public double Rating { get; set; }
        public string? Comment { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
