using Cms.Bussiness.Abstract;
using Cms.DataAccess.Abstract;
using Cms.DataAccess.Concrete;
using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Concrete
{
    public class Vw_TitleContainerManager : IVw_TitleContainerService
    {
        private IVw_TitleContainerDal _vw_TitleContainerDal;
        public Vw_TitleContainerManager(IVw_TitleContainerDal vw_TitleContainerDal)
        {
            _vw_TitleContainerDal = vw_TitleContainerDal;
        }
        public void Create(Vw_TitleContainer entity)
        {
            _vw_TitleContainerDal.Create(entity);
        }

        public void Delete(Vw_TitleContainer entity)
        {
            _vw_TitleContainerDal.Delete(entity);
        }

        public List<Vw_TitleContainer> GetAll(Expression<Func<Vw_TitleContainer, bool>> filter = null)
        {
            return _vw_TitleContainerDal.GetAll();
        }

        public Vw_TitleContainer GetById(int id)
        {
            return _vw_TitleContainerDal.GetById(id);
        }

        public void Update(Vw_TitleContainer entity)
        {
            _vw_TitleContainerDal.Update(entity);
        }
    }
}
