namespace MailTrackREST.Models
{
    public class MailAdditionalInfo
    {
        public int Id { get; set; }
        public bool SignatureRequired { get; set; }
        public bool HoldMail { get; set; }
        public bool LeaveAtDesk { get; set; }
        public int NumberOfDeliveryAttempts { get; set; }
        public int HoldMailInDays { get; set; }
    }
}