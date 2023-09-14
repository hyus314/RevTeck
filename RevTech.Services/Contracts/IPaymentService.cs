using RevTech.Data.User;
using RevTech.Data.ViewModels.Payment;

namespace RevTech.Core.Contracts
{
    public interface IPaymentService
    {
        public Task<PaymentDetailsViewModel> GeneratePaymentViewModelAsync(string configurationId, RevTeckUser user);
        public Task<ICollection<OrderedPartViewModel>> GetAllOrderedPartsForPayment(string configurationId);
        public Task ProcessPaymentAsync(ClientPaymentInfo paymentInfo, string amountString);
    }
}
