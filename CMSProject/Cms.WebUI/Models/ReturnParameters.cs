using Cms.Bussiness.Abstract;
using Cms.DataAccess.Abstract;
using Cms.DataAccess.DataContext;
using Cms.DataAccess.Dtos;
using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Models
{
    public class ReturnParameter
    {
        public string key { get; set; }
        public string value { get; set; }
        public PageTitle pageTitleDtos { get; set; }
        public Vw_TitleContent titleContent { get; set; }
        public List<Vw_TitleContainer> titleContainers { get; set; }
        
    }
    public class ReturnParameters : List<ReturnParameter>
    {
        public PageTitle pageTitle { get; set; }
    }
}
