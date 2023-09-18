namespace RevTech.Data.ViewModels.Payment
{
    public class PaymentIdModel
    {
        public string PaymentId { get; set; } = null!;
        public string? Amount { get; set; } 
        public string? ConfigurationId { get; set; }
        public string? UserId { get; set; }
        public string DeliveryAddress { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
