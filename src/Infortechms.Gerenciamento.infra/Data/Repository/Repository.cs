using Infortechms.Gerenciamento.Business.Core.Data;
using Infortechms.Gerenciamento.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.infra.Data.Context;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly InfortechMSContext Db;
        protected readonly DbSet<TEntity> Dbset;

        protected Repository()
        {
            Db = new InfortechMSContext();
            Dbset = Db.Set<TEntity>();
        }

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await Dbset.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await Dbset.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await Dbset.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            Dbset.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            await SaveChanges();
        }

        public virtual async Task Remover(Guid id)
        {
            Db.Entry(new TEntity{Id = id}).State = EntityState.Deleted;
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}