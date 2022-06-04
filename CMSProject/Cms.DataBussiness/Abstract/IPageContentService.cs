using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface IPageContentService
    {
        List<PageContent> GetAll(Expression<Func<PageContent, bool>> filter = null);
        List<PageContent> GetByPageContent(int contentid);
        PageContent GetById(int id);
        void Create(PageContent entity);
        void Delete(PageContent entity);
        void Update(PageContent entity);
    }
}
