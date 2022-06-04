using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Models.Helpers
{
    public class Functions
    {
        private string siteLink
        {
            get
            {
                return "http://localhost:44380";
            }
        }
        public string GetUrl(string link, string controller, string index, string parameter)
        {
            if (!string.IsNullOrEmpty(link))
            //if(link is not null and "")
            {
                return link;
            }
            else
            {
                if (!string.IsNullOrEmpty(index))
                    if (!string.IsNullOrEmpty(parameter)) return siteLink + "/" + controller + "/" + index + "/" + parameter;
                    else return siteLink + "/" + controller + "/" + index;
                else
                    return siteLink + "/" + controller + "/" + parameter;
            }
        }
    }
}
