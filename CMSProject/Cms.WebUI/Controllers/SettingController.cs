using Cms.Bussiness.Abstract;
using Cms.DataAccess.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers
{
    public class SettingController : Controller
    {
        private ISettingService _settingService;
        public SettingController(ISettingService settingService)
        {
            _settingService = settingService;
        }
        public IActionResult Index()
        {
            var entity = _settingService.GetAll();
            return View(entity);
        }
        [HttpGet]
        public IActionResult CreateSetting()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSetting(SettingDto settingDto)
        {
            DateTime date = DateTime.Now;
            var model = new SettingDto()
            {
                Id = settingDto.Id,
                PageTitle = settingDto.PageTitle,
                PageDescription = settingDto.PageDescription,
                WebServerAddress = settingDto.WebServerAddress,
                WebServerPort = settingDto.WebServerPort,
                SMTPServerAddress = settingDto.SMTPServerAddress,
                SMTPServerPort = settingDto.SMTPServerPort,
                WebMailUserName = settingDto.WebMailUserName,
                WebMailPassword = settingDto.WebMailPassword,
                Tel = settingDto.Tel,
                Gsm = settingDto.Gsm,
                Fax = settingDto.Fax,
                CompanyAddress = settingDto.CompanyAddress,
                Location_Lat = settingDto.Location_Lat,
                Location_Lng = settingDto.Location_Lng,
                CompanyLogo = settingDto.CompanyLogo,
                IsActive = settingDto.IsActive,
                CreatedDate = date,
                ModifiedDate = DateTime.Now.AddDays(0.00),
                IsDeleted = settingDto.IsDeleted
            };
            _settingService.Create(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSetting(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _settingService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new SettingDto()
            {
                Id = entity.Id,
                PageTitle = entity.PageTitle,
                PageDescription = entity.PageDescription,
                WebServerAddress = entity.WebServerAddress,
                WebServerPort = entity.WebServerPort,
                SMTPServerAddress = entity.SMTPServerAddress,
                SMTPServerPort = entity.SMTPServerPort,
                WebMailUserName = entity.WebMailUserName,
                WebMailPassword = entity.WebMailPassword,
                Tel = entity.Tel,
                Gsm = entity.Gsm,
                Fax = entity.Fax,
                CompanyAddress = entity.CompanyAddress,
                Location_Lat = entity.Location_Lat,
                Location_Lng = entity.Location_Lng,
                CompanyLogo = entity.CompanyLogo,
                IsActive = entity.IsActive,
                //CreatedDate = entity.CreatedDate,
                //ModifiedDate = entity.ModifiedDate,
                //IsDeleted = entity.IsDeleted
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditSetting(SettingDto s)
        {
            DateTime date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var entity = _settingService.GetById(s.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.PageTitle = s.PageTitle;
                entity.PageDescription = s.PageDescription;
                entity.WebServerAddress = s.WebServerAddress;
                entity.WebServerPort = s.WebServerPort;
                entity.SMTPServerAddress = s.SMTPServerAddress;
                entity.SMTPServerPort = s.SMTPServerPort;
                entity.WebMailUserName = s.WebMailUserName;
                entity.WebMailPassword = s.WebMailPassword;
                entity.Tel = s.Tel;
                entity.Gsm = s.Gsm;
                entity.Fax = s.Fax;
                entity.CompanyAddress = s.CompanyAddress;
                entity.Location_Lat = s.Location_Lat;
                entity.Location_Lng = s.Location_Lng;
                entity.CompanyLogo = s.CompanyLogo;
                entity.IsActive = s.IsActive;
                entity.CreatedDate = s.CreatedDate;
                entity.ModifiedDate = date;
                //entity.IsDeleted = s.IsDeleted;
                _settingService.Update(entity);
                return RedirectToAction("Index");
            }

            return View(s);
        }
        public IActionResult DeleteSetting(int id)
        {
            var entity = _settingService.GetById(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _settingService.Delete(entity);
            }
            return RedirectToAction("Index");
        }
    }
}
