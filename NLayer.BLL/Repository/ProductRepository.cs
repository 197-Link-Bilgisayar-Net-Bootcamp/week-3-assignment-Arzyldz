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
        public List<Product> GetCheapProductTop5()
        {
            List<Product> lstProduct=new List<Product>();
            if (_dbContext.Products != null && _dbContext.Products.Count()>0)
            {
                lstProduct = _dbContext.Products.OrderByDescending(x => x.UnitPrice).Take(5).ToList();
            }
            return lstProduct;
        }
    }
}
