using Cms.Bussiness.Abstract;
using Cms.DataAccess.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers
{
    public class PageTitleController : Controller
    {
        private IPageTitleService _pageTitleService;
        public PageTitleController(IPageTitleService pageTitleService)
        {
            _pageTitleService = pageTitleService;
        }
        public IActionResult Index()
        {
            var entity = _pageTitleService.GetAll();
            return View(entity);
        }
        [HttpGet]
        public IActionResult CreatePageTitle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePageTitle(PageTitleDto p)
        {
            DateTime date = DateTime.Now;
            var model = new PageTitleDto()
            {
                menutitle = p.menutitle,
                link = p.link,
                menudescription = p.menudescription,
                targetselection = p.targetselection,
                currentslanguage = p.currentslanguage,
                rownumber = p.rownumber,
                rootid = p.rootid,
                isdeleted = p.isdeleted
            };
            _pageTitleService.Create(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPageTitle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _pageTitleService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new PageTitleDto()
            {
                menutitle = entity.menutitle,
                link = entity.link,
                menudescription = entity.menudescription,
                targetselection = entity.targetselection,
                currentslanguage = entity.currentslanguage,
                rownumber = entity.rownumber,
                rootid = entity.rootid
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditPageTitle(PageTitleDto p)
        {
            var entity = _pageTitleService.GetById(p.id);
            if (entity == null)
            {
                return NotFound();
            }
            entity.menutitle = p.menutitle;
            entity.link = p.link;
            entity.menudescription = p.menudescription;
            entity.targetselection = p.targetselection;
            entity.currentslanguage = p.currentslanguage;
            entity.rownumber = p.rownumber;
            entity.rootid = p.rootid;
            _pageTitleService.Update(entity);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePageTitle(int id)
        {
            var entity = _pageTitleService.GetById(id);
            if (entity != null)
            {

                entity.isdeleted = true;
                _pageTitleService.Update(entity);
            }
            //_pageTitleService.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}
