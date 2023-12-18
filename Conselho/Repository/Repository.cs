using Conselho.API.Data;
using Conselho.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Conselho.API.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ConselhoDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ConselhoDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

    }
}
