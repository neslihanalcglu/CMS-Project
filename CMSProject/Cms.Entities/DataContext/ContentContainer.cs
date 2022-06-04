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
    public class ContentContainer: IContentContainer
    {
       
        public int contentid { get; set; }
        public PageContent pageContent { get; set; }
        
        public int containerid { get; set; }
        public PageContainer pageContainer { get; set; }
    }
}
