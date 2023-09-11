namespace RevTech.Data.ViewModels.Payment
{
    public class PaymentDetailsViewModel
    {
        public string ConfigurationId { get; set; } = null!;
        public string UserCarDetails { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string CardNumber { get; set; } = null!;
        public string ExpiryDate { get; set; } = null!;
        public string CVC { get; set; } = null!;
        public decimal Amount { get; set; } 
    }
}
