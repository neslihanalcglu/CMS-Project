using Cms.Bussiness.Abstract;
using Cms.DataAccess.Dtos;
using Cms.Entities.DataContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers
{
    [Authorize ]
    public class ContactFormController : Controller
    {
        private IContactFormService _contactformService;
        public ContactFormController(IContactFormService contactformService)
        {
            _contactformService = contactformService;
        }
        public IActionResult Index()
        {
            return View(_contactformService.GetAll());
        }
        [HttpGet]
        public IActionResult CreateContactForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContactForm(ContactFormDto c)
        {
            //DateTime date = DateTime.Now;
            var entity = new ContactFormDto()
            {
             
                NameSurname = c.NameSurname,
                Email = c.Email,
                Tel = c.Tel,
                FormContent = c.FormContent,
                IsReaded = c.IsReaded,
                IsAnswered = c.IsAnswered,
                IsDeleted=c.IsDeleted
            };

            _contactformService.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditContactForm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _contactformService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new ContactFormDto()
            {
                Id = entity.Id,
                NameSurname = entity.NameSurname,
                Email = entity.Email,
                Tel = entity.Tel,
                FormContent = entity.FormContent,
                IsReaded = entity.IsReaded,
                IsAnswered = entity.IsAnswered
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditContactForm(ContactFormDto c)
        {
            if (ModelState.IsValid)
            {
                var entity = _contactformService.GetById(c.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.NameSurname = c.NameSurname;
                entity.Email = c.Email;
                entity.Tel = c.Tel;
                entity.FormContent = c.FormContent;
                entity.IsReaded = c.IsReaded;
                entity.IsAnswered = c.IsAnswered;
                _contactformService.Update(entity);
                return RedirectToAction("ContactForm","Index");
            }

            return View(c);
        }
        public IActionResult DeleteContactForm(int id)
        {
            var entity = _contactformService.GetById(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _contactformService.Update(entity);
            }
            return RedirectToAction("Index");
        }
    }
}
