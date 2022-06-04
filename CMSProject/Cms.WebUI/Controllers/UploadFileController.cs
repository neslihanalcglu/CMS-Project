using Cms.Bussiness.Abstract;
using Cms.DataAccess.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers
{
    public class UploadFileController : Controller
    {
        private IUploadFileService _uploadFileService;
        public UploadFileController(IUploadFileService uploadFileService)
        {
            _uploadFileService = uploadFileService;
        }
        public IActionResult Index()
        {
            var entity = _uploadFileService.GetAll();
            return View(entity);
        }
        [HttpGet]
        public IActionResult CreateUploadFile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUploadFile(UploadFileDto file)
        {
            DateTime date = DateTime.Now;
            var model = new UploadFileDto()
            {
                Id = file.Id,
                Path = file.Path,
                FileName = file.FileName,
                Extension = file.Extension,
                IsActive = file.IsActive,
                CreatedDate = date,
                ModifiedDate = DateTime.Now.AddDays(0.00),
                IsDeleted = file.IsDeleted
            };
            _uploadFileService.Create(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUploadFile(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var entity = _uploadFileService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new UploadFileDto()
            {
                Id = entity.Id,
                Path = entity.Path,
                FileName = entity.FileName,
                Extension = entity.Extension,
                IsActive = entity.IsActive,
                //CreatedDate = entity.CreatedDate,
                //ModifiedDate = entity.ModifiedDate,
                //IsDeleted = entity.IsDeleted
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditUploadFile(UploadFileDto file)
        {
            DateTime date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var entity = _uploadFileService.GetById(file.Id);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.Path = file.Path;
                entity.FileName = file.FileName;
                entity.Extension = file.Extension;
                entity.IsActive = file.IsActive;
                entity.CreatedDate = file.CreatedDate;
                entity.ModifiedDate = date;
                //entity.IsDeleted = file.IsDeleted;
                _uploadFileService.Update(entity);
                return RedirectToAction("Index");
            }

            return View(file);
        }
        public IActionResult DeleteUploadFile(int id)
        {
            var entity = _uploadFileService.GetById(id);
            if (entity != null)
            {

                entity.IsDeleted = true;
                _uploadFileService.Update(entity);
            }
            return RedirectToAction("Index");
        }

    }
}
