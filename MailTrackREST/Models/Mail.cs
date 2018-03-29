using System;

namespace MailTrackREST.Models
{
    public class Mail
    {
        public int Id { get; set; }
        public int ServiceProviderId { get; set; }
        public int EmployeeId { get; set; }
        public int FromAddressId { get; set; }
        public DateTime MailSentDateTime { get; set; }
        public DateTime MailScheduledDeliveryDateTime { get; set; }
        public string Comments { get; set; }
        public int AdditionalInfoId { set; get; }
    }
}