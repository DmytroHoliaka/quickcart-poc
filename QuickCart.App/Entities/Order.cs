namespace QuickCart.App.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? Status { get; set; }
        
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; } = [];
    }
}
