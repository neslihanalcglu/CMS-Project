using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface ISettingService
    {
        List<Setting> GetAll(Expression<Func<Setting, bool>> filter = null);
        Setting GetById(int id);
        void Create(Setting entity);
        void Delete(Setting entity);
        void Update(Setting entity);
    }
}
