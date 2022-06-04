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
    public class UploadFileManager : IUploadFileService
    {
        private IUploadFileDal _uploadFileDal;
        public UploadFileManager(IUploadFileDal uploadFileDal)
        {
            _uploadFileDal = uploadFileDal;
        }
        public void Create(UploadFile entity)
        {
            _uploadFileDal.Create(entity);
        }

        public void Delete(UploadFile entity)
        {
            _uploadFileDal.Delete(entity);
        }

        public List<UploadFile> GetAll(Expression<Func<UploadFile, bool>> filter = null)
        {
            return _uploadFileDal.GetAll(x=>x.IsDeleted==false);
        }

        public UploadFile GetById(int id)
        {
            return _uploadFileDal.GetById(id);
        }

        public void Update(UploadFile entity)
        {
            _uploadFileDal.Update(entity);
        }
    }
}
