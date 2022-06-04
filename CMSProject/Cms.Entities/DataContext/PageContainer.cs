using Cms.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.DataContext
{
    public class PageContainer: IPageContainer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string texteditor { get; set; }
        public string language { get; set; }
        public bool isactive { get; set; }
        public DateTime createddate { get; set; }
        public DateTime modifieddate { get; set; }
        public bool isdeleted { get; set; }
        public List<ContentContainer> contentContainers { get; set; }
    }
}
