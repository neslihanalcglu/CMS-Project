using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAccess.Abstract
{
  public  interface IPageContainerDal:IRepository<PageContainer>
    {
        List<PageContainer> GetByPageContainer(int containerid);

    }
}
