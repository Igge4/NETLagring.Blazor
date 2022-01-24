namespace NETLagring.Blazor.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Mail { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; } 



        public CustomersService CustomersService { get; set; }
    }
}
