using Cms.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.DataContext
{
    public class PageTitle: IPageTitle
    {
        [Key]
        public int id { get; set; }
        public string menutitle { get; set; }
        public string link { get; set; }
        public string menudescription { get; set; }
        public string targetselection { get; set; }

        public string currentslanguage { get; set; }
        public int rownumber { get; set; }
        public int rootid { get; set; }
        public bool isdeleted { get; set; }

      
     
        public List<TitleContent> titleContents { get; set; }
    }
}
