using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
