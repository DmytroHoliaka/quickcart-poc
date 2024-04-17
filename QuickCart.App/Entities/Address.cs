namespace QuickCart.App.Entities
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? Street { get; set; }
        public int BuildingNumber { get; set; }
        public string? PostalCode { get; set; }

        public Address? User { get; set; }
    }
}
