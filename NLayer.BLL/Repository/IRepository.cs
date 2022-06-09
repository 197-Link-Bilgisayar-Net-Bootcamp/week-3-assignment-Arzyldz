namespace NLayer.BLL.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Add(TEntity entity);
        Task Edit(TEntity entity);
        Task Del(int id);
    }

}
