using NLayer.DAL.Models;

namespace NLayer.BLL.Service
{
    public interface ICrudService<TDto> where TDto : class
    {
        Task<Response<IList<TDto>>> GetAll();
        Task<Response<TDto>> GetById(int id);
        Task Add(TDto entity);
        Task Edit(TDto entity);
        Task Del(int id);
    }
}
