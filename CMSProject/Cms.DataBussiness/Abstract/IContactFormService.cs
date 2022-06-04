using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface IContactFormService
    {
        List<ContactForm> GetAll(Expression<Func<ContactForm, bool>> filter = null);
        ContactForm GetById(int id);
        void Create(ContactForm entity);
        void Delete(ContactForm entity);
        void Update(ContactForm entity);
    }
}
