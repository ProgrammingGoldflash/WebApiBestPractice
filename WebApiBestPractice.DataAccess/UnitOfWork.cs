using System;
using System.Collections.Generic;
using System.Text;
using WebApiBestPractice.Domain.Interfaces;

namespace WebApiBestPractice.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
