using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3.EF.Entities;
using TP3.EF.Logic;
using TP3.EF.MVC.Models;

namespace TP3.EF.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {
            
            List<Entities.Shippers> shippers = logic.GetAll();
            List<ShippersView> shippersViews = shippers.Select(s => new ShippersView
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone,

            }).ToList();
            return View(shippersViews);
        }

        // GET: Shippers/Details/5
        public ActionResult Details(int id)
        {
            var logic = new ShippersLogic();
            List<Entities.Shippers> shippers = logic.GetAll();
            return View(shippers);
                       
        }

        // GET: Shippers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shippers/Create
        [HttpPost]
        public ActionResult Create(ShippersView shippersViews)
        {
            try
            {
                Shippers shipperEntity = new Shippers { CompanyName = shippersViews.CompanyName, Phone = shippersViews.Phone};

                logic.Add(shipperEntity);
              
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index","Error");
            }
        }

        // GET: Shippers/Edit/5
        public ActionResult Edit(int id) 
        {
            return View();
        }

        // POST: Shippers/Edit/5
        [HttpPost]
        public ActionResult Edit(ShippersView shippersViews)
        {
            try
            {
                Shippers shipperUpdate = new Shippers { ShipperID = shippersViews.ShipperID };
                
                shipperUpdate.CompanyName = shippersViews.CompanyName;
                shipperUpdate.Phone = shippersViews.Phone;
                shippersViews.ShipperID = shipperUpdate.ShipperID;
                logic.Update(shipperUpdate);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Shippers/Delete/5
        public ActionResult Delete(int id)
        {

            logic.Delete(id);
            return RedirectToAction("Index");
        }

        
    }
}
