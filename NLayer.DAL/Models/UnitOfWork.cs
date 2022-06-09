using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.DAL.Models
{
    public class UnitOfWork
    {
        private readonly MyDataContext _DataContext;

        public UnitOfWork(MyDataContext dataContext)
        {
            _DataContext = dataContext;
        }
        public async Task Commit() {
           await  _DataContext.SaveChangesAsync();
        }
    }
}
