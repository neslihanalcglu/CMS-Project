using Cms.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.Contracts
{
    public interface ITitleContent
    {
        public int MenuId { get; set; }
        public PageTitle pageTitle { get; set; }
        public int ContentId { get; set; }
        public PageContent pageContent { get; set; }
    }
}
