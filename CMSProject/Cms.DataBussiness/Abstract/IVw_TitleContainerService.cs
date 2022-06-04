using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface IVw_TitleContainerService
    {
        List<Vw_TitleContainer> GetAll(Expression<Func<Vw_TitleContainer, bool>> filter = null);
        Vw_TitleContainer GetById(int id);
        void Create(Vw_TitleContainer entity);
        void Delete(Vw_TitleContainer entity);
        void Update(Vw_TitleContainer entity);
    }
}
