using Cms.Bussiness.Abstract;
using Cms.Entities.DataContext;
using Cms.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers.PageContents
{
    public class PageDetailController : Controller
    {
        private IVw_TitleContainerService _vw_TitleContainerService;
        public PageDetailController(IVw_TitleContainerService vw_TitleContainerService)
        {
            _vw_TitleContainerService = vw_TitleContainerService;
        }
        [HttpGet]
        [Route("PageContents/{Container}/{Index}/{page?}")]
        public IActionResult Index( string id)
        {

            ReturnParameters param = new ReturnParameters();
            if (RouteData.Values["Index"] != null) //&& Convert.ToInt32(RouteData.Values["Index"]) > 0)
            {
                List<Vw_TitleContainer> dtoList = _vw_TitleContainerService.GetAll().Where(w => w.menutitle == RouteData.Values["Index"].ToString()).ToList();

                param.Add(new ReturnParameter() { key = "page", value = RouteData.Values["Index"].ToString(), titleContainers = dtoList });

            }
            else
                param.Add(new ReturnParameter() { key = "null", value = "0" });

            return View(param);
        }
        public IActionResult CreativeAgency()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Features()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
