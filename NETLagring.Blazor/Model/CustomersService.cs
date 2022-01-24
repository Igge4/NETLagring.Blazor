using System;
using System.Collections.Generic;

namespace NETLagring.Blazor.Model
{
    public class CustomersService
    {
        public int Id { get; set; }
        public string Rubric { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastEdited { get; set; }
        public Status Status { get; set; }  
        public int CustomerId { get; set; }
        public string Description { get; set; }

        //The table has a collection of Customer
        public ICollection<Customer> Customer { get; set; }
    }
}
