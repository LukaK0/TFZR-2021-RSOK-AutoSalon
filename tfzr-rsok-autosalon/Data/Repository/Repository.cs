using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using tfzr_rsok_autosalon.Models;

namespace tfzr_rsok_autosalon.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        protected readonly DbContext _context;
        internal DbSet<T> DbSet;

        public Repository(DbContext context)
        {
            _context = context;
            DbSet = context.Set<T>();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty.Trim());
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = DbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.FirstOrDefault();
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var entity = DbSet.Find(id);
            Remove(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var model = DbSet.Find(entity.Id);
            if (model == null)
            {
                return;
            }
            
            _context.Entry(model).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}