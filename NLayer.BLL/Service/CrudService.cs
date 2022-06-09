
using NLayer.BLL.Repository;
using NLayer.DAL.Models;

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

        public async Task<Response<IList<TDto>>> GetAll()
        {
            var lst = await _iRepo.GetAll();

            if (!lst.Any())
            {
                return new Response<IList<TDto>>()
                {
                    Data = null,
                    Errors = new List<string>() { "Kayıt bulunamadı" },
                    Status = 404
                };
            }

            return new Response<IList<TDto>>()
            {
                Data = lst,
                Errors = null,
                Status = 200
            };
        }

        public async Task<Response<TDto>> GetById(int id)
        {
            var tdto = await _iRepo.GetById(id);

            if (tdto != null)
            {
                return new Response<TDto>()
                {
                    Data = null,
                    Errors = new List<string>() { "Kayıt bulunamadı" },
                    Status = 404
                };
            }

            return new Response<TDto>()
            {
                Data = tdto,
                Errors = null,
                Status = 200
            };
        }
    }
}
