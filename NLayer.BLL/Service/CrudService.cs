
using NLayer.BLL.Repository;

namespace NLayer.BLL.Service
{
    public abstract class CrudService<TDto> : ICrudService<TDto> where TDto : class
    {
        private readonly IRepository<TDto> _iRepo;

        public CrudService(IRepository<TDto> iRepo)
        {
            _iRepo = iRepo;
        }
        public async Task Add(TDto entity)
        {
           await _iRepo.Add(entity);
        }

        public async Task Del(int id)
        {
            await _iRepo.Del(id);
        }

        public async Task Edit(TDto entity)
        {
            await _iRepo.Edit(entity);
        }

        public IList<TDto> GetAll()
        {
          return  _iRepo.GetAll();
        }

        public async Task<TDto> GetById(int id)
        {
          return await  _iRepo.GetById(id);
        }
    }
}
