using Microsoft.EntityFrameworkCore;
using WebApiBestPractice.DataAccess.Entities;

namespace WebApiBestPractice.DataAccess
{
    public class DatabaseContext : DbContext
    {
        #region Public Constructors

        public DatabaseContext() : base()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion Public Properties
    }
}