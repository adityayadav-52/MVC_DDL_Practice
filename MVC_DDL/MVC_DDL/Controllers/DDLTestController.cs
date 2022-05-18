using MVC_DDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DDL.Controllers
{
    public class DDLTestController : Controller
    {
        // GET: DDLTest
        AppDbContext dbobj = new AppDbContext();
        public ActionResult Index()
        {
            ViewBag.CountryList = new SelectList(GetCountryList(), "CId", "CName");
            return View();
        }
        public List<Country> GetCountryList()
        {
            List<Country> countries = dbobj.Countries.ToList();
            return countries;
        }
        public ActionResult GetStateList(int Cid)
        {
            List<State> selectlist = dbobj.MyStates.Where(a => a.CId == Cid).ToList();
            ViewBag.Slist = new SelectList(selectlist, "SId", "SName");
            return PartialView("DisplayStates");
        }

        public ActionResult GetCityList(int Sid)
        {
            List<City> selectlist = dbobj.Cities.Where(a => a.SId == Sid).ToList();
            ViewBag.Citylist = new SelectList(selectlist, "CityId", "CityName");
            return PartialView("DisplayCities");
        }
    }
}