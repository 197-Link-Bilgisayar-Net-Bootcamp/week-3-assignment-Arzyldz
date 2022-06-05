
using NLayer.BLL.Repository;
using NLayer.DAL.Models;

namespace CrudOperations.API.Service
{
    public class CategoryService : CrudService<Category>
    {
        public CategoryService(IRepository<Category> iRepo) : base(iRepo)
        {
        }
    }
}
