using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAccess.Dtos
{
    public class Vw_TitleContentDto: Vw_TitleContent
    {
        public Vw_TitleContentDto()
        {
            isactive = false;
            isdeleted = false;
        }
    }
}
