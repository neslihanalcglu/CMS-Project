using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAccess.Dtos
{
    public class SettingDto:Setting
    {
        public SettingDto()
        {
            IsActive = false;
            IsDeleted = false;
        }
    }
}
