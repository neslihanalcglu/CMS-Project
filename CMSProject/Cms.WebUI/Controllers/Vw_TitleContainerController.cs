using Cms.Bussiness.Abstract;
using Cms.DataAccess.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers
{
    public class Vw_TitleContainerController : Controller
    {
        private IVw_TitleContainerService _vw_TitleContainerService;
        public Vw_TitleContainerController(IVw_TitleContainerService vw_TitleContainerService)
        {
            _vw_TitleContainerService = vw_TitleContainerService;
        }
        public IActionResult Index()
        {
            var entity = _vw_TitleContainerService.GetAll();
            return View(entity);
        }
        [HttpGet]
        public IActionResult CreateVw_TitleContainer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateVw_TitleContainer(Vw_TitleContainerDto vw_TitleContainer)
        {
            DateTime date = DateTime.Now;
            var model = new Vw_TitleContainerDto()
            {
                menutitle = vw_TitleContainer.menutitle,
                menudescription = vw_TitleContainer.menudescription,
                targetselection = vw_TitleContainer.targetselection,
                currentslanguage = vw_TitleContainer.currentslanguage,
                rownumber = vw_TitleContainer.rownumber,
                rootid = vw_TitleContainer.rootid,
                pagetitle = vw_TitleContainer.pagetitle,
                pagedescription = vw_TitleContainer.pagedescription,
                texteditor = vw_TitleContainer.texteditor,
                language = vw_TitleContainer.language,
                isactive = vw_TitleContainer.isactive,
            };
            _vw_TitleContainerService.Create(model);
            return RedirectToAction("Index");
        }
    }
}
