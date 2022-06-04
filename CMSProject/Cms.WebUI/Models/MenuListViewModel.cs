using Cms.DataAccess.Dtos;
using Cms.Entities.DataContext;
using Cms.WebUI.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Models
{
    public class MenuListViewModel
    {
        public List<PageTitle> pageTitle { get; set; }
        public Functions myfunc { get; set; }
    }
}
