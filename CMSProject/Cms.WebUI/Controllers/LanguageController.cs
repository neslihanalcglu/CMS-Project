using Cms.Bussiness.Abstract;
using Cms.DataAccess.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers
{
    public class LanguageController : Controller
    {
        private ILanguageService _languageService;
        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }
        public IActionResult Index()
        {
            var entity = _languageService.GetAll();
            return View(entity);
        }
        [HttpGet]
        public IActionResult CreateLanguage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateLanguage(LanguageDto language)
        {
            _languageService.Create(language);
            return RedirectToAction("Language","Index");
        }
        [HttpGet]
        public IActionResult EditLanguage(int? id)
        {
      
            if (id == null)
            {
                return NotFound();
            }

            var entity = _languageService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new LanguageDto()
            {
                Id = entity.Id,
                LanguageTag = entity.LanguageTag,
                Title = entity.Title,
                Value = entity.Value,
                IsDeleted = entity.IsDeleted
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditLanguage(LanguageDto l)
        {
            if (ModelState.IsValid)
            {
                var entity = _languageService.GetById(l.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.LanguageTag = l.LanguageTag;
                entity.Title = l.Title;
                entity.Value = l.Value;
                _languageService.Update(entity);
                return RedirectToAction("Index");
            }

            return View(l);
        }
      
        public IActionResult DeleteLanguage(int id)
        {
            var entity = _languageService.GetById(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _languageService.Update(entity);
            }
            return RedirectToAction("Index");
        }
    }
}
