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
    public class PageTitleDal : GenericRepository<PageTitle, DatabaseContext>, IPageTitleDal
    {
        public List<PageTitle> GetByPageTitle(int titleid)
        {
            using (var db = new DatabaseContext())
            {
                return db.pagetitles
                    .Where(x => x.id == titleid)
                    .Include(x => x.titleContents)
                    .ThenInclude(x => x.pageContent)
                    .ToList();
            }
        }

        PageTitle IPageTitleDal.GetByPageTitles(int titleid)
        {
            using (var db = new DatabaseContext())
            {
                return db.pagetitles
                    .Where(x => x.id == titleid)
                    .Include(x => x.titleContents)
                    .ThenInclude(x => x.pageContent)
                    .FirstOrDefault();
            }
        }
    }
}
