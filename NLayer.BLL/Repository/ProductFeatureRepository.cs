using NLayer.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.BLL.Repository
{
    public class ProductFeatureRepository : Repository<ProductFeature>
    {
        public ProductFeatureRepository(ApDataContext dbContext) : base(dbContext)
        {
        }
    }
}
