using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApiBestPractice.DataAccess.Entities;
using WebApiBestPractice.Domain.Interfaces.Repositories;

namespace WebApiBestPractice.DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository<User>
    {
        #region Private Fields

        private readonly DatabaseContext _context;

        #endregion Private Fields

        #region Public Constructors

        public UserRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }

        #endregion Public Constructors

        #region Public Methods

        public async Task<bool> CheckForUsernameAsync(string username)
        {
            return await _context.Users.AnyAsync(c => c.Username.Equals(username));
        }

        #endregion Public Methods
    }
}