using Cms.Bussiness.Abstract;
using Cms.WebUI.Models;
using Cms.WebUI.Models.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.ViewComponents
{
    public class FooterMenuListViewComponent: ViewComponent
    {
        private IPageTitleService _pageTitleService;
        public FooterMenuListViewComponent(IPageTitleService pageTitleService)
        {
            _pageTitleService = pageTitleService;
        }
        public IViewComponentResult Invoke()
        {
            return View(new MenuListViewModel()
            {
                pageTitle = _pageTitleService.GetAll(), 
                myfunc = new Functions()
            }
            );;

        }
    }
}
