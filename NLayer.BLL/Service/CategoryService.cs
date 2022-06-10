using NLayer.BLL.Repository;
using NLayer.DAL.Models;

namespace NLayer.BLL.Service
{
    public class CategoryService : CrudService<Category>
    {
        public CategoryService(IRepository<Category> iRepo) : base(iRepo)
        {
        }
        public override Task Del(int id)
        {
            




            return base.Del(id);
        }
    }
}
