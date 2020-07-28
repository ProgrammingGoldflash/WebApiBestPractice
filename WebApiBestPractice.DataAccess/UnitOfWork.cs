using System;
using WebApiBestPractice.Domain.Interfaces;

namespace WebApiBestPractice.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Public Methods

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods
    }
}