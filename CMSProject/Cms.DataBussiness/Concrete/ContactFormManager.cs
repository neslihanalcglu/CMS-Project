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
    public class ContactFormManager : IContactFormService
    {
        private IContactFormDal _contactFormDal;
        public ContactFormManager(IContactFormDal contactFormDal)
        {
            _contactFormDal = contactFormDal;
        }
        public void Create(ContactForm entity)
        {
            _contactFormDal.Create(entity);

        }

        public void Delete(ContactForm entity)
        {
            _contactFormDal.Delete(entity);
        }

        public List<ContactForm> GetAll(Expression<Func<ContactForm, bool>> filter = null)
        {
            return _contactFormDal.GetAll(x => x.IsDeleted == false);
        }

        public ContactForm GetById(int id)
        {
            return _contactFormDal.GetById(id);
        }

        public void Update(ContactForm entity)
        {
            _contactFormDal.Update(entity);
        }
    }
}
