using Cms.DataAccess.Abstract;
using Cms.DataAccess.DataContext;
using Cms.Entities.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAccess.Concrete
{
    public class PageContainerDal : GenericRepository<PageContainer, DatabaseContext>, IPageContainerDal
    {
        public List<PageContainer> GetByPageContainer(int containerid)
        {
           using(var db=new DatabaseContext())
            {
                return db.pagecontainers
                    .Where(x => x.id == containerid)
                    .Include(x =>x.contentContainers)
                    .ThenInclude(X => X.pageContent)
                    .ToList();
            }
        }
    }
}
