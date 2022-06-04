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
    public class PageContainerManager : IPageContainerService
    {
        private IPageContainerDal _pageContainerDal;
        public PageContainerManager(IPageContainerDal pageContainerDal)
        {
            _pageContainerDal = pageContainerDal;
        }
        public void Create(PageContainer entity)
        {
            _pageContainerDal.Create(entity);
        }

        public void Delete(PageContainer entity)
        {
            _pageContainerDal.Delete(entity);
        }

        public List<PageContainer> GetAll(Expression<Func<PageContainer, bool>> filter = null)
        {
            return _pageContainerDal.GetAll(x => x.isdeleted == false);
        }

        public PageContainer GetById(int id)
        {
            return _pageContainerDal.GetById(id);
        }

        public List<PageContainer> GetByPageContainer(int containerid)
        {
            return _pageContainerDal.GetByPageContainer(containerid);
        }

        public void Update(PageContainer entity)
        {
            _pageContainerDal.Update(entity);
        }

   
    }
}
