using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface IVw_TitleContentService
    {
        List<Vw_TitleContent> GetAll(Expression<Func<Vw_TitleContent, bool>> filter = null);
        Vw_TitleContent GetById(int id);
        void Create(Vw_TitleContent entity);
        void Delete(Vw_TitleContent entity);
        void Update(Vw_TitleContent entity);
    }
}
