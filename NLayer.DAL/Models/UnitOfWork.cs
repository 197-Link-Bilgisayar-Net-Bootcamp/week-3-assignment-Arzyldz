using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.DAL.Models
{
    public class UnitOfWork
    {
        private readonly ApDataContext _DataContext;

        public UnitOfWork(ApDataContext dataContext)
        {
            _DataContext = dataContext;
        }
        public async Task Commit() {
           await  _DataContext.SaveChangesAsync();
        }
    }
}
