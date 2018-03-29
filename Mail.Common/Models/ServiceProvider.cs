namespace Mail.Common.Models
{
    public class ServiceProvider
    {
        public int Id { get; set; }
        public string ServiceProviderName { get; set; }
        public string ServiceProviderDescription { get; set; }
        public string ServiceProviderImagePath { get; set; }
        public Address ServiceProviderAddress { get; set; }
    }
}