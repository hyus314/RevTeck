﻿namespace RevTech.Data.User
{
    using RevTech.Data.Models.UserConfiguration;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserPayment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Client))]
        public string ClientId { get; set; } = null!;
        public RevTeckUser Client { get; set; } = null!;
        [ForeignKey(nameof(Configuration))]
        public int ConfigurationId { get; set; }
        public Models.UserConfiguration.Configuration Configuration { get; set; } = null!;
        public decimal Amount { get; set; }
        public string PaymentId { get; set; } = null!;
        public DateTime OrderedDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        public bool IsDelivered { get; set; } = false;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string DeliveryAddress { get; set; } = null!;
    }
}
