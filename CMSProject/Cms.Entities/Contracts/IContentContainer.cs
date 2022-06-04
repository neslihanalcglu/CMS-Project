using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.Contracts
{
    public interface IContentContainer
    {

        public int contentid { get; set; }
        public PageContent pageContent { get; set; }

        public int containerid { get; set; }
        public PageContainer pageContainer { get; set; }
    }
}
