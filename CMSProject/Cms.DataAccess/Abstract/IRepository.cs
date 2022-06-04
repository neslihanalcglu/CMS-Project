using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
