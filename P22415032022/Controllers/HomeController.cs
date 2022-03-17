using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace P22415032022.Controllers
{
    public class HomeController : Controller
    {
        //public ContentResult Index()
        //{
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "P224 Content";
        //    contentResult.ContentType = "application/json";
        //    contentResult.StatusCode = (int?)HttpStatusCode.OK;

        //    return contentResult;

        //}

        //public JsonResult Index()
        //{
        //    JsonResult jsonResult = new JsonResult("{name:Hamid,surname:Mammadov}");
        //    return jsonResult;
        //}

        //public FileResult Index()
        //{
        //    FileResult fileResult = new FileResult("path");
        //    return fileResult;
        //}

        //public ViewResult Index()
        //{
        //    ViewResult viewResult = new ViewResult();
        //    viewResult.ViewName = "test";
        //    return viewResult;

        //}

        //public void Index()
        //{
        //    ViewResult view = new ViewResult();
        //    JsonResult jsonResult = new JsonResult();
        //    ContentResult contentResult = new ContentResult();
        //    FileResult fileResult = new FileResult();
        //}

        //public ActionResult Index()
        //{
        //    if (false)
        //    {
        //        return new ViewResult { ViewName = "test" };
        //    }
        //    else if(false)
        //    {
        //        return new ContentResult { Content = "P224" };
        //    }

        //    return NotFound("Test");
        //}

        public IActionResult Index(int? id, string name)
        {

            //if (id != null)
            //{
            //    if (id > 0)
            //    {
            //        return Content($"A sifirdan Boyukdur {name}");
            //    }
            //    return Content($"A sifirdan Deyil {name}");
            //}

            ViewData["Name"] = "Hamid";
            ViewData["SurName"] = "Mammadov";

            ViewBag.Name1 = "Kamil";
            ViewBag.SurName1 = "Quliyev";

            TempData["Name"] = "Altan";
            TempData["SurName"] = "Ibrahimli";
            return View();

        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        //public IActionResult Test()
        //{
        //    //return Json();
        //    //return Content();
        //    //return File();

        //}
    }
}
