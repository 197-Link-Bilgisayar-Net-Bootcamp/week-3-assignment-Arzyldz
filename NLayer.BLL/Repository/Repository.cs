
using Microsoft.EntityFrameworkCore;
using NLayer.DAL.Models;

namespace NLayer.BLL.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly MyDataContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;
        public Repository(MyDataContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }
       
        public async Task Add(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            //_dbContext.Entry(entity).State = EntityState.Added;
        }
        public async Task Del(int id)
        {
            TEntity? entity = await _dbSet.FindAsync(id);
            if (entity == null) return;
            else
            {
                var dbEntityEntry = _dbContext.Entry(entity);
                //var currentState = _dbContext.Entry(entity).State;
                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                else
                {
                    _dbSet.Attach(entity);
                    _dbSet.Remove(entity);
                }
            }
        }

        public async Task Edit(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
          
        }
        public async  Task<IList<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return  await _dbSet.FindAsync(id);
        }
    }
}
