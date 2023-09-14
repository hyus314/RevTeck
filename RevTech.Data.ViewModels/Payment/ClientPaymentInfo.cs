
namespace RevTech.Data.ViewModels.Payment
{
    public class ClientPaymentInfo
    {
        public string FirstName{ get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string DeliveryAddress { get; set; } = null!;
        public string PaymentMethodId { get; set; } = null!;
    }
}
