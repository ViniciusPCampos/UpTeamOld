using System;
using UPTEAM.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using UPTEAM.Domain.RepositoryInterfaces;
using System.Data.Entity;

namespace UPTEAM.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected UpTeamContext Db = new UpTeamContext();
        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();

        }
    }
}
