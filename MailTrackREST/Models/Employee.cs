namespace MailTrackREST.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string TelephoneNumber { get; set; }
        public Department Department { get; set; }
        public Role Role { get; set; }
        public Employee Manager { get; set; }
    }

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Payscale { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee Director { get; set; }
        public string Location { get; set; }
    }
}