using System;

namespace WebApiBestPractice.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        #region Public Methods

        int Complete();

        #endregion Public Methods
    }
}