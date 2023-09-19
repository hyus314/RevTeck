using System.Text.RegularExpressions;

namespace RevTech.Data.ViewModels.Payment
{
    public class PaymentIdModel
    {
        public string PaymentMethodId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? Amount { get; set; } 
        public string DeliveryAddress { get; set; } = null!;
        public string? ConfigurationId { get; set; }
        public string? UserId { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(PaymentMethodId) ||
                string.IsNullOrEmpty(FirstName) ||
                string.IsNullOrEmpty(LastName) ||
                string.IsNullOrEmpty(City) ||
                string.IsNullOrEmpty(Country) ||
                string.IsNullOrEmpty(DeliveryAddress))
            {
                return false;
            }

            if (!decimal.TryParse(Amount, out decimal amount) || amount <= 0)
            {
                return false;
            }

            if (!Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") ||
                !Regex.IsMatch(LastName, @"^[a-zA-Z]+$"))
            {
                return false;
            }

            if (!Regex.IsMatch(City, @"^[a-zA-Z\s]+$") ||
                !Regex.IsMatch(Country, @"^[a-zA-Z\s]+$"))
            {
                return false;
            }

            return true;
        }


    }
}
