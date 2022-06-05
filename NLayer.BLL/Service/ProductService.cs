
using NLayer.BLL.Repository;
using NLayer.DAL.Models;

namespace NLayer.BLL.Service
{
    public class ProductService : CrudService<Product>
    {
        public ProductService(IRepository<Product> iRepo) : base(iRepo)
        {
        }
    }
}
