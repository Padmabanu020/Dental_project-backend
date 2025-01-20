namespace Dental_project.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public required string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Timing { get; set; }
        public string EmailId { get; set; }
        public bool IsFooter { get; set; }
        public bool IsHeader { get; set; }
        
    }
}
