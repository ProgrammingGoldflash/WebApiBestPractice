using System;

namespace WebApiBestPractice.Domain.Models
{
    public class User
    {
        #region Public Properties

        public DateTime Created { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        #endregion Public Properties
    }
}