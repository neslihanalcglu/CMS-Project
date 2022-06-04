using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.Contracts
{
    public interface IVw_TitleContainer
    {
        public int titleid { get; set; }
        public string menutitle { get; set; }
        public string menudescription { get; set; }
        public string targetselection { get; set; }
        public string currentslanguage { get; set; }
        public int rownumber { get; set; }
        public int rootid { get; set; }
        public string pagetitle { get; set; }
        public string pagedescription { get; set; }
        public string pagedetails { get; set; }
        public string texteditor { get; set; }
        public string language { get; set; }
        public bool isactive { get; set; }
        public DateTime createddate { get; set; }
        public DateTime modifieddate { get; set; }
    }
}
