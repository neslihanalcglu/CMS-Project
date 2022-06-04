using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface IPageTitleService
    {
        List<PageTitle> GetAll(Expression<Func<PageTitle, bool>> filter = null);
        List<PageTitle> GetByPageTitle(int titleid);
        PageTitle GetById(int id);
        void Create(PageTitle entity);
        void Delete(PageTitle entity);
        void Update(PageTitle entity);
        PageTitle GetByJoin();
    }
}
