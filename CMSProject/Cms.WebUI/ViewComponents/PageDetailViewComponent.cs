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
    public class PageDetailViewComponent: ViewComponent
    {
        private IVw_TitleContentService _vw_TitleContentService;
        public PageDetailViewComponent(IVw_TitleContentService vw_TitleContentService)
        {
            _vw_TitleContentService = vw_TitleContentService;
        }
        public IViewComponentResult Invoke()
        {
            //var value = _databaseContext.pagetitles.Where(x => x.SubPageId == 0).Select(y => y.MenuTitle);
            //ViewBag.value = value;_
            //return View(model: new PageDetailsViewModel(int id)
            //{
            //    pageTitle = _vw_TitleContentService.GetById(id)
            //}
            //);
            return null;
        }
    }
}
