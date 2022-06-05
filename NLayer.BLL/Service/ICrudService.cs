namespace CrudOperations.API.Service
{
    public interface ICrudService<TDto> where TDto : class
    {
        IList<TDto> GetAll();
        Task<TDto> GetById(int id);
        Task Add(TDto entity);
        Task Edit(TDto entity);
        Task Del(int id);
        Task SaveChangesAsync();
    }
}
