using Microsoft.EntityFrameworkCore;
using SandBoxRestApiUdemy.Model.Base;
using SandBoxRestApiUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBoxRestApiUdemy.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly SqlServerContext _context;
        private DbSet<T> dbSet;

        public GenericRepository(SqlServerContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public T Create(T entity)
        {
            try
            {
                dbSet.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Delete(int id)
        {
            var result = dbSet.SingleOrDefault(s => s.Id.Equals(id));

            try
            {
                if (result != null) dbSet.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Exist(int? id)
        {
            return dbSet.Any(a => a.Id == id);
        }

        public List<T> FindAll()
        {
            return dbSet.ToList();
        }

        public T FindById(int id)
        {
            return dbSet.SingleOrDefault(s => s.Id.Equals(id));
        }

        public T Update(T entity)
        {
            if (!Exist(entity.Id)) return null;

            var result = dbSet.SingleOrDefault(s => s.Id.Equals(entity.Id));

            try
            {
                _context.Entry(result).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return entity;
        }
    }
}
