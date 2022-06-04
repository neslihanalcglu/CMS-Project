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
    public class LanguageManager : ILanguageService
    {
        private ILanguageDal _languageDal;
        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }
        public void Create(Language entity)
        {
            _languageDal.Create(entity);
        }

        public void Delete(Language entity)
        {
            _languageDal.Delete(entity);
        }

        public List<Language> GetAll(Expression<Func<Language, bool>> filter = null)
        {
            return _languageDal.GetAll(x => x.IsDeleted == false);
        }

        public Language GetById(int id)
        {
            return _languageDal.GetById(id);
        }

        public void Update(Language entity)
        {
            _languageDal.Update(entity);
        }
    }
}
