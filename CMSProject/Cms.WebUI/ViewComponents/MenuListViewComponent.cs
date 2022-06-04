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
    public class MenuListViewComponent : ViewComponent
    {
        private IPageTitleService _pageTitleService;
        public MenuListViewComponent(IPageTitleService pageTitleService)
        {
            _pageTitleService = pageTitleService;
        }
        public IViewComponentResult Invoke()
        {
            //var value = _databaseContext.pagetitles.Where(x => x.SubPageId == 0).Select(y => y.MenuTitle);
            //ViewBag.value = value;_
            return View(model: new MenuListViewModel()
            {
                pageTitle = _pageTitleService.GetAll(),
                myfunc = new Functions()
            }
            );

        }
    }
}
