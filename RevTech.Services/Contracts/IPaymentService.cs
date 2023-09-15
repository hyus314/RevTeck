using RevTech.Data.User;
using RevTech.Data.ViewModels.Payment;
using Stripe;

namespace RevTech.Core.Contracts
{
    public interface IPaymentService
    {
        public Task<PaymentDetailsViewModel> GeneratePaymentViewModelAsync(string configurationId, RevTeckUser user);
        public Task<ICollection<OrderedPartViewModel>> GetAllOrderedPartsForPayment(string configurationId);
        public Task<PaymentIntent> CreatePaymentIntent(ClientPaymentInfo paymentInfo, string amountString);
    }
}
