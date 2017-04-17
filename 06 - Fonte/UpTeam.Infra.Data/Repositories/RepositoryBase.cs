using System;
using System.Collections.Generic;
using UpTeam.Domain.Interfaces;

namespace UpTeam.Infra.Data.Repositories
{
    class RepositoryBase<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        bdupteamModel.bdupteamEntities db = new bdupteamModel.bdupteamEntities();

        public void Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
