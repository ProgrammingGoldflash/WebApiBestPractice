using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBestPractice.DataAccess.Entities
{
    public class User
    {
        #region Public Properties

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Username { get; set; }

        #endregion Public Properties
    }
}