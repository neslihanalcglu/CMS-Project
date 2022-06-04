using Cms.DataAccess.Abstract;
using Cms.DataAccess.DataContext;
using Cms.Entities.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAccess.Concrete
{
    public class PageContentDal : GenericRepository<PageContent, DatabaseContext>, IPageContentDal

    {
        public List<PageContent> GetByPageContents(int container)
        {
            using(var db=new DatabaseContext())
            {
                //return db.pagecontents.Include(x => x.contentcontainer)
                //    .ThenInclude(x => x.pageContent)
                //    .Where(x => x.Id == container).ToList();
                return db.pagecontents.Where(x => x.id == container).Include(x => x.contentcontainer)
                   .ThenInclude(x => x.pageContainer).ToList();
                   
            }
        }
        public List<PageContent> GetByPageContent(int title)
        {
            using (var db = new DatabaseContext())
            {
                //return db.pagecontents.Include(x => x.contentcontainer)
                //    .ThenInclude(x => x.pageContent)
                //    .Where(x => x.Id == container).ToList();
                return db.pagecontents.Where(x => x.id == title).Include(x => x.titleContents)
                   .ThenInclude(x => x.pageTitle).ToList();

            }
        }
    }
}
