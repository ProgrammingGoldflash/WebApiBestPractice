using System;
using System.Collections.Generic;
using System.Text;
using WebApiBestPractice.Domain.Interfaces.Repositories;

namespace WebApiBestPractice.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
