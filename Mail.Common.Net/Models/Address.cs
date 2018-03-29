namespace Mail.Common.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
    }
}