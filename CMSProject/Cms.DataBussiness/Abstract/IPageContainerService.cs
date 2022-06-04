using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface IPageContainerService
    {
        List<PageContainer> GetAll(Expression<Func<PageContainer, bool>> filter = null);
        List<PageContainer> GetByPageContainer(int containerid);
        PageContainer GetById(int id);
        void Create(PageContainer entity);
        void Delete(PageContainer entity);
        void Update(PageContainer entity);
    }
}
