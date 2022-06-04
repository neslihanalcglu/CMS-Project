using Cms.DataAccess.Abstract;
using Cms.DataAccess.DataContext;
using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAccess.Concrete
{
    public class LanguageDal:GenericRepository<Language, DatabaseContext>, ILanguageDal
    {
    }
}
