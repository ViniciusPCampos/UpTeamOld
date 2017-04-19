using System;
using UPTEAM.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace UPTEAM.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
