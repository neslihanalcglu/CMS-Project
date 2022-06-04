
using Cms.Bussiness.Abstract;
using Cms.DataAccess.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers
{
    public class PageContainerController : Controller
    {
        private IPageContainerService _pageContainerService;
        public PageContainerController(IPageContainerService pageContainerService)
        {
            _pageContainerService = pageContainerService;
        }
        public IActionResult Index()
        {
            var entity = _pageContainerService.GetAll();
            return View(entity);
        }
        [HttpGet]
        public IActionResult CreatePageContainer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePageContainer(PageContainerDto p)
        {
            DateTime date = DateTime.Now;
            var entity = new PageContainerDto()
            {
                texteditor=p.texteditor,
                language=p.language,
                isactive=p.isactive,
                createddate=date,
                modifieddate = DateTime.Now.AddDays(0.00),
                isdeleted=p.isdeleted
            };
            _pageContainerService.Create(entity);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPageContainer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _pageContainerService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new PageContainerDto()
            {
                texteditor = entity.texteditor,
                language = entity.language,
                isactive = entity.isactive
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditPageContainer(PageContainerDto p)
        {
            DateTime date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var entity = _pageContainerService.GetById(p.id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.texteditor = p.texteditor;
                entity.language = p.language;
                entity.isactive = p.isactive;
                entity.createddate = p.createddate;
                entity.modifieddate = date;
                //entity.IsDeleted = file.IsDeleted;
                _pageContainerService.Update(entity);
                return RedirectToAction("Index");
            }

            return View(p);
        }
        public IActionResult DeletePageContainer(int id)
        {
            var entity = _pageContainerService.GetById(id);
            if (entity != null)
            {

                entity.isdeleted = true;
                _pageContainerService.Update(entity);
            }
            return RedirectToAction("Index");
        }
    }
}
