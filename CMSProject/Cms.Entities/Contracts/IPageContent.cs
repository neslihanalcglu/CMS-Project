using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.Contracts
{
    public interface IPageContent
    {
        [Key]
        public int id { get; set; }
        public string pagetitle { get; set; }
        public string pagedescription { get; set; }
        public string pagedetails { get; set; }
        public bool isactive { get; set; }
        public int titleid { get; set; }
        public DateTime createddate { get; set; }
        public DateTime modifieddate { get; set; }
        public bool isdeleted { get; set; }
    }
}
