using Cms.Bussiness.Abstract;
using Cms.DataAccess.Abstract;
using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Concrete
{
    public class PageContentManager : IPageContentService
    {
        private IPageContentDal _pageContentDal;
        public PageContentManager(IPageContentDal pageContentDal)
        {
            _pageContentDal = pageContentDal; 
        }
        public void Create(PageContent entity)
        {
            _pageContentDal.Create(entity);
        }

        public void Delete(PageContent entity)
        {
            _pageContentDal.Delete(entity);
        }

        public List<PageContent> GetAll(Expression<Func<PageContent, bool>> filter = null)
        {
            return _pageContentDal.GetAll(x => x.isdeleted == false);
        }

        public PageContent GetById(int id)
        {
            return _pageContentDal.GetById(id);
        }

        public List<PageContent> GetByPageContent(int contentid)
        {
            return _pageContentDal.GetByPageContent(contentid);
        }

        public void Update(PageContent entity)
        {
            _pageContentDal.Update(entity);
        }
    }
}
