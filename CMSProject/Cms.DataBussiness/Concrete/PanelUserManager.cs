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
    public class PanelUserManager : IPanelUserService
    {
        IPanelUserDal _panelUserDal;
        public PanelUserManager(IPanelUserDal panelUserDal)
        {
            _panelUserDal = panelUserDal;
        }
        public void Create(PanelUser entity)
        {
            _panelUserDal.Create(entity);
        }

        public void Delete(PanelUser entity)
        {
            _panelUserDal.Delete(entity);
        }

        public List<PanelUser> GetAll(Expression<Func<PanelUser, bool>> filter = null)
        {
            return _panelUserDal.GetAll(x => x.IsDeleted == false);
        }

        public PanelUser GetById(int id)
        {
            return _panelUserDal.GetById(id);
        }

        public void Update(PanelUser entity)
        {
            _panelUserDal.Update(entity);
        }
    }
}
