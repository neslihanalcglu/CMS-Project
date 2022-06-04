using Cms.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Entities.DataContext
{
    public class Setting: ISetting
    {
        public int Id { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string WebServerAddress { get; set; }
        public string WebServerPort { get; set; }
        public string SMTPServerAddress { get; set; }
        public string SMTPServerPort { get; set; }
        public string WebMailUserName { get; set; }
        public string WebMailPassword { get; set; }

        public string Tel { get; set; }
        public string Gsm { get; set; }
        public string Fax { get; set; }
        public string CompanyAddress { get; set; }
        public string Location_Lat { get; set; }
        public string Location_Lng { get; set; }
        public string CompanyLogo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
