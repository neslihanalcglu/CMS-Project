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
    public class SettingManager : ISettingService
    {
        private ISettingDal _settingDal;
        public SettingManager(ISettingDal settingDal)
        {
            _settingDal = settingDal;
        }
        public void Create(Setting entity)
        {
            _settingDal.Create(entity);
        }

        public void Delete(Setting entity)
        {
            _settingDal.Delete(entity);
        }

        public List<Setting> GetAll(Expression<Func<Setting, bool>> filter = null)
        {
            return _settingDal.GetAll(x => x.IsDeleted == false);
        }

        public Setting GetById(int id)
        {
            return _settingDal.GetById(id);
        }

        public void Update(Setting entity)
        {
            _settingDal.Update(entity);
        }
    }
}
