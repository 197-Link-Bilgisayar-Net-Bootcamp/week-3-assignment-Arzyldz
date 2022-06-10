using NLayer.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.BLL.Repository
{
    public class CategoryRepository : Repository<Category>
    {
        private readonly ApDataContext _dbContext;
        public CategoryRepository(ApDataContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public override Task Del(int id)
        {
            using (var tran =_dbContext.Database.BeginTransaction())
            {
              //var cat=  _dbContext.Categories.Where(w => w.Id == id).FirstOrDefault();
              //  if (cat!=null)
              //  {
              //      cat.Products.ForEach(p=>p.ProductFeatures)
              //      cat.Products.RemoveAll(s => s.CategoryId == id);
                    
              //  }

                tran.Commit();
            }



            return base.Del(id);
        }
    }
}
