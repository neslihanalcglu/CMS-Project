using Cms.Bussiness.Abstract;
using Cms.DataAccess.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers
{
    public class PanelUserController : Controller
    {
        IPanelUserService _panelUserService;
        public PanelUserController(IPanelUserService panelUserService)
        {
            _panelUserService = panelUserService;
        }
        public IActionResult Index()
        {
            var entity = _panelUserService.GetAll();
            return View(entity);
        }
        [HttpGet]
        public IActionResult CreatePanelUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePanelUser(PanelUserDto p)
        {
            DateTime date = DateTime.Now;
            var model = new PanelUserDto()
            {
                Id = p.Id,
                UserName = p.UserName,
                Password = p.Password,
                RePassword = p.RePassword,
                Email = p.Email,
                Role = p.Role,
                IsActive = p.IsActive,
                CreatedDate = p.CreatedDate,
                ModifiedDate = DateTime.Now.AddDays(0.00),
                IsDeleted = p.IsDeleted
            };
            _panelUserService.Create(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPanelUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _panelUserService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new PanelUserDto()
            {
                Id = entity.Id,
                UserName = entity.UserName,
                Password = entity.Password,
                RePassword = entity.RePassword,
                Email = entity.Email,
                Role = entity.Role,
                IsActive = entity.IsActive,
                //CreatedDate = entity.CreatedDate,
                //ModifiedDate = DateTime.Now.AddDays(0.00),
                //IsDeleted = entity.IsDeleted
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditPanelUser(PanelUserDto p)
        {
            DateTime date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var entity = _panelUserService.GetById(p.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.UserName = p.UserName;
                entity.Password = p.Password;
                entity.RePassword = p.RePassword;
                entity.Email = p.Email;
                entity.Role = p.Role;
                entity.IsActive = p.IsActive;
                entity.CreatedDate = p.CreatedDate;
                entity.ModifiedDate = date;
                //entity.IsDeleted = p.IsDeleted;
                _panelUserService.Update(entity);
                return RedirectToAction("Index");
            }

            return View(p);
        }
        public IActionResult DeletePanelUser(int id)
        {
            var entity = _panelUserService.GetById(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _panelUserService.Delete(entity);
            }
            return RedirectToAction("Index");
        }
    }
}
