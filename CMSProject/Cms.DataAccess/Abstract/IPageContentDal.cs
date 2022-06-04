using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAccess.Abstract
{
  public  interface IPageContentDal:IRepository<PageContent>
    {
        List<PageContent> GetByPageContent(int container);
    }
}
