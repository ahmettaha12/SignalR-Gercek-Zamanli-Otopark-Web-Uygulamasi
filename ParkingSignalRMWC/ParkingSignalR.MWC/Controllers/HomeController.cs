using ParkingSignalR.MWC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParkingSignalR.MWC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        ProjectSignalRDBEntities db = new ProjectSignalRDBEntities();
        public ActionResult getSlots()
        {

            return PartialView("PV_FloorList", db.Slots.ToList());
        }

        public JsonResult ChangeStatus(int Id, bool currentStatus)
        {
            Slots slot = db.Slots.Find(Id);
            slot.Status = !currentStatus;
            db.Entry(slot).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Json("");
        }
    }
}