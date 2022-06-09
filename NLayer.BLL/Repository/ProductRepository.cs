using NLayer.DAL.Models;

namespace NLayer.BLL.Repository
{
    public class ProductRepository : Repository<Product>
    {
        private readonly ApDataContext _dbContext;

        public ProductRepository(ApDataContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
       
    }
}
