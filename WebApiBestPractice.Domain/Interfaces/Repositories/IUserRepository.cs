using System.Threading.Tasks;

namespace WebApiBestPractice.Domain.Interfaces.Repositories
{
    public interface IUserRepository<T> : IRepository<T> where T : class
    {
        #region Public Methods

        Task<bool> CheckForUsernameAsync(string username);

        #endregion Public Methods
    }
}