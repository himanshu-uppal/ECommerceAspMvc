﻿using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Core;
using EarthMarket.DataAccess.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EarthMarket.DataAccess.Concrete
{
    public class EntityRepository<T> : IEntityRepository<T>
 where T : class, IEntity, new()
    {
        readonly DbContext _entitiesContext;
        public EntityRepository(DbContext entitiesContext)
        {
            if (entitiesContext == null)
            {
                throw new ArgumentNullException("entitiesContext");
            }
            _entitiesContext = entitiesContext;
        }
        public virtual IQueryable<T> GetAll()
        {
            return _entitiesContext.Set<T>();
        }
        public virtual IQueryable<T> All
        {
            get
            {
                return GetAll();
            }
        }
        public virtual IQueryable<T> AllIncluding(
 params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _entitiesContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }
        public T GetSingle(Guid key)
        {
            return GetAll().FirstOrDefault(x => x.Key == key);
        }
        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _entitiesContext.Set<T>().Where(predicate);
        }
        public virtual PaginatedList<T> Paginate<TKey>(
        int pageIndex, int pageSize,
        Expression<Func<T, TKey>> keySelector)
        {
            return Paginate(pageIndex, pageSize, keySelector, null);
        }
        public virtual PaginatedList<T> Paginate<TKey>(
 int pageIndex, int pageSize,
 Expression<Func<T, TKey>> keySelector,
 Expression<Func<T, bool>> predicate,
 params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query =
            AllIncluding(includeProperties).OrderBy(keySelector);
            query = (predicate == null)
            ? query
            : query.Where(predicate);
            return query.ToPaginatedList(pageIndex, pageSize);
        }
        public virtual void Add(T entity)
        {
            DbEntityEntry dbEntityEntry = _entitiesContext.Entry<T>(entity);
            _entitiesContext.Set<T>().Add(entity);
            
            Debug.WriteLine(_entitiesContext.Set<T>().Add(entity));
        }
        public virtual void Edit(T entity)
        {
            DbEntityEntry dbEntityEntry = _entitiesContext.Entry<T>(entity);

            

            dbEntityEntry.State = EntityState.Modified;

            Debug.WriteLine(_entitiesContext.Entry<T>(entity));
        }
        public virtual void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = _entitiesContext.Entry<T>(entity);      


            dbEntityEntry.State = EntityState.Deleted;

            Debug.WriteLine(_entitiesContext.Entry<T>(entity));
        }
        public virtual void Save()
        {
            _entitiesContext.SaveChanges();

            Debug.WriteLine(_entitiesContext.SaveChanges());
        }
    }
}
