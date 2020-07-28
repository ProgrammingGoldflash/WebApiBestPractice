using System;

namespace WebApiBestPractice.Domain.Models
{
    public class Customer
    {
        #region Public Properties

        public DateTime Created { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }

        #endregion Public Properties
    }
}