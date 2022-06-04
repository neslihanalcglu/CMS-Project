using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface IPanelUserService
    {
        List<PanelUser> GetAll(Expression<Func<PanelUser, bool>> filter = null);
        PanelUser GetById(int id);
        void Create(PanelUser entity);
        void Delete(PanelUser entity);
        void Update(PanelUser entity);
    }
}
