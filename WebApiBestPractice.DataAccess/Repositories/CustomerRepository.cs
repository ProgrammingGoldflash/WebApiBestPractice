using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApiBestPractice.DataAccess.Entities;
using WebApiBestPractice.Domain.Interfaces.Repositories;

namespace WebApiBestPractice.DataAccess.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository<Customer>
    {
        #region Private Fields

        private readonly DatabaseContext _context;

        #endregion Private Fields

        #region Public Constructors

        public CustomerRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Methods

        public async Task<bool> CheckForEmailAsync(string email)
        {
            return await _context.Customers.AnyAsync(c => c.Email.Equals(email));
        }

        #endregion Public Methods
    }
}