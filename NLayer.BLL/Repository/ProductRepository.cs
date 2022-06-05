using NLayer.DAL.Models;

namespace NLayer.BLL.Repository
{
    public class ProductRepository : Repository<Product>
    {
        private readonly MyDataContext _dbContext;

        public ProductRepository(MyDataContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
       
    }
}
