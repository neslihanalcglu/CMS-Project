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
    public class Vw_TitleContentManager : IVw_TitleContentService
    {
        private IVw_TitleContentDal _vw_TitleContentDal;
        public Vw_TitleContentManager(IVw_TitleContentDal vw_TitleContentDal)
        {
            _vw_TitleContentDal = vw_TitleContentDal;
        }
        public void Create(Vw_TitleContent entity)
        {
            _vw_TitleContentDal.Create(entity);
        }

        public void Delete(Vw_TitleContent entity)
        {
            _vw_TitleContentDal.Delete(entity);
        }

        public List<Vw_TitleContent> GetAll(Expression<Func<Vw_TitleContent, bool>> filter = null)
        {
            return _vw_TitleContentDal.GetAll(x => x.isdeleted == false);
        }

        public Vw_TitleContent GetById(int id)
        {
            return _vw_TitleContentDal.GetById(id);
        }

        public void Update(Vw_TitleContent entity)
        {
            _vw_TitleContentDal.Update(entity);
        }
    }
}
