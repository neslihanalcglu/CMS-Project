using Cms.Entities.DataContext;
using Cms.WebUI.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Models
{
    public class PageDetailViewModel
    {
        public List<PageTitle> pageTitle{ get; set; }
        public Vw_TitleContent vw_TitleContentDtos { get; set; }
    }
}
