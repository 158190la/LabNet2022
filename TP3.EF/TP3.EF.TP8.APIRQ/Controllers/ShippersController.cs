using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3.EF.Logic;
using TP3.EF.Entities;
using TP3.EF.MVC;
using TP3.EF.MVC.Models;
using FluentValidation;
using FluentValidation.Results;
using System.Web.Http;
using System.Net;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace TP3.EF.TP8.APIRQ.Controllers
{
    public class ShippersController : ApiController
    {
        ShippersLogic logic = new ShippersLogic();


        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                List<Entities.Shippers> shippers = logic.GetAll();
                List<ShippersView> shippersViews = shippers.Select(s => new ShippersView
                {
                    ShipperID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone,

                }).ToList();
                return Ok(shippersViews);
            }
            catch (Exception e)
            {

                return Content(HttpStatusCode.NotFound, e.Message);
            }
            
        }




        [HttpPost]
        public IHttpActionResult Create(ShippersView shippersViews)
        {
            try
            {
                ShippersValidator shippersvalidator = new ShippersValidator();
                ValidationResult result = shippersvalidator.Validate(shippersViews);

                if (result.IsValid)
                {
                    Shippers shipperEntity = new Shippers { CompanyName = shippersViews.CompanyName, Phone = shippersViews.Phone };

                    logic.Add(shipperEntity);


                }
                else
                {

                    foreach (var failure in result.Errors)
                    {
                        ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                    }
                    
                }
                return Ok(shippersViews);
            }
            catch (Exception e)
            {

                return Content(HttpStatusCode.NotFound, e.Message);
            }
            
        }

        
        [HttpPut]
        public IHttpActionResult Edit(ShippersView shippersViews)
        {
            try
            {
                ShippersValidator shippersvalidator = new ShippersValidator();
                ValidationResult result = shippersvalidator.Validate(shippersViews);
                Shippers shipperUpdate = new Shippers();

                if (result.IsValid)
                {
                    shipperUpdate.CompanyName = shippersViews.CompanyName;
                    shipperUpdate.Phone = shippersViews.Phone;
                    shipperUpdate.ShipperID = shippersViews.ShipperID;
                    logic.Update(shipperUpdate);

                }
                else
                {
                    foreach (var failure in result.Errors)
                    {
                        ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                    }

                }
                return Ok(shippersViews);
            }
            catch (Exception e)
            {

                return Content(HttpStatusCode.NotFound, e.Message);
            }
            


        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {

                return Content(HttpStatusCode.NotFound, e.Message);
            }
            
            
        }


    }
}