using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Bussiness.Abstract
{
    public interface IUploadFileService
    {
        List<UploadFile> GetAll(Expression<Func<UploadFile, bool>> filter = null);
        UploadFile GetById(int id);
        void Create(UploadFile entity);
        void Delete(UploadFile entity);
        void Update(UploadFile entity);
    }
}
