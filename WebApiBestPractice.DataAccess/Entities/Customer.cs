using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBestPractice.DataAccess.Entities
{
    public class Customer
    {
        #region Public Properties

        public string Email { get; set; }

        public string FirstName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        #endregion Public Properties
    }
}