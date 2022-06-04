using Cms.Bussiness.Abstract;
using Cms.DataAccess.Abstract;
using Cms.DataAccess.DataContext;
using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Concrete
{
    public class PageTitleManager : IPageTitleService
    {
        private IPageTitleDal _pageTitleDal;
        public PageTitleManager(IPageTitleDal pageTitleDal)
        {
            _pageTitleDal =pageTitleDal;
        }
        public void Create(PageTitle entity)
        {
            _pageTitleDal.Create(entity);
        }

        public void Delete(PageTitle entity)
        {
            _pageTitleDal.Delete(entity);
        }

        public List<PageTitle> GetAll(Expression<Func<PageTitle, bool>> filter = null)
        {
            return _pageTitleDal.GetAll(x => x.isdeleted == false);
        }

        public PageTitle GetById(int id)
        {
            return _pageTitleDal.GetById(id);
        }

        public PageTitle GetByJoin()
        {
            //using (var db = new DatabaseContext())
            //{
            //    var result=from p in db.pae
            //}
            return null;
        }

        public List<PageTitle> GetByPageTitle(int titleid)
        {
            return _pageTitleDal.GetByPageTitle(titleid);
        }

        public void Update(PageTitle entity)
        {
            _pageTitleDal.Update(entity);
        }
    }
}
