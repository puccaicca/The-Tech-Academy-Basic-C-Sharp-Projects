using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        InsuranceEntities db = new InsuranceEntities();//instantiate the entity object which gives access to the database
        public ActionResult Index()
        {

            {
                return View(db.Insurees.ToList());
            }
        }

    }
}