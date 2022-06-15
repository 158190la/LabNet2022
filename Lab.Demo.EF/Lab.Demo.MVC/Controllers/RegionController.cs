using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Lab.Demo.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Demo.MVC.Controllers
{
    public class RegionController : Controller
    {
        RegionLogic logic = new RegionLogic();
        // GET: Region
        public ActionResult Index()
        {
            
            List<EF.Entities.Region> regiones = logic.GetAll();
            List<RegionView> regionViews = regiones.Select(s => new RegionView
            {
                Id = s.RegionID,
                Descripcion = s.RegionDescription
            }).ToList();



            return View(regionViews);
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(RegionView regionView)
        {
            try
            {
                var regionEntity = new Region { RegionDescription = regionView.Descripcion };
               
                logic.Add(regionEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}