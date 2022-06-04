using Cms.Bussiness.Abstract;
using Cms.DataAccess.Concrete;
using Cms.DataAccess.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers
{
    public class PageContentController : Controller
    {
        private IPageContentService _pageContentService;
        public PageContentController(IPageContentService pageContentService)
        {
            _pageContentService = pageContentService;
        }
        public IActionResult Index()
        {
            //  PageContainerDal sa = new PageContainerDal(); 
            //var deger=  sa.GetByPageContainer(1);

            // --------- Lazım olacak

            //     PageContentDal asd = new PageContentDal();
            //var deger2=  asd.GetByPageContents(1);


            var entity = _pageContentService.GetAll();
            return View(entity);
        }
        [HttpGet]
        public IActionResult CreatePageContent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePageContent(PageContentDto p)
        {
            DateTime date = DateTime.Now;
            var model = new PageContentDto()
            {
                pagetitle = p.pagetitle,
                pagedescription = p.pagedescription,
                pagedetails=p.pagedetails,
                isactive = p.isactive,
                createddate = date,
                modifieddate = DateTime.Now.AddDays(0.00),
                isdeleted = p.isdeleted
            };
            _pageContentService.Create(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPageContent(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _pageContentService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new PageContentDto()
            {
                pagetitle = entity.pagetitle,
                pagedescription = entity.pagedescription,
                pagedetails = entity.pagedetails,
                isactive = entity.isactive,
                //CreatedDate = entity.CreatedDate,
                //ModifiedDate = entity.ModifiedDate,
                //IsDeleted = entity.IsDeleted
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditPageContent(PageContentDto p)
        {
            DateTime date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var entity = _pageContentService.GetById(p.id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.pagetitle = p.pagetitle;
                entity.pagedescription = p.pagedescription;
                entity.pagedetails = p.pagedetails;
                entity.isactive = p.isactive;
                entity.createddate = p.createddate;
                entity.modifieddate = date;
                //entity.IsDeleted = file.IsDeleted;
                _pageContentService.Update(entity);
                return RedirectToAction("Index");
            }
            return View(p);
        }
        public IActionResult DeletePageContent(int id)
        {
            var entity = _pageContentService.GetById(id);
            if (entity != null)
            {
                entity.isdeleted = true;
                _pageContentService.Update(entity);
            }
            return RedirectToAction("Index");
        }
    }
}
