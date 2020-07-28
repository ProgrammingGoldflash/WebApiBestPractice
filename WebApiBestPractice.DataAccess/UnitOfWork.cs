using System;
using WebApiBestPractice.Domain.Interfaces;

namespace WebApiBestPractice.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Public Methods

        public int Complete()
        {
            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods
    }
}