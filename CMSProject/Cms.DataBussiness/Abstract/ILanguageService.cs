using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface ILanguageService
    {
        List<Language> GetAll(Expression<Func<Language, bool>> filter = null);
        Language GetById(int id);
        void Create(Language entity);
        void Delete(Language entity);
        void Update(Language entity);
    }
}
