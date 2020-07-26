using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiBestPractice.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }
        
    }
}
