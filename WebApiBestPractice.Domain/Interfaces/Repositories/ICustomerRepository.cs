using System.Threading.Tasks;

namespace WebApiBestPractice.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository<T> : IRepository<T> where T : class
    {
        #region Public Methods

        Task<bool> CheckForEmailAsync(string email);

        #endregion Public Methods
    }
}