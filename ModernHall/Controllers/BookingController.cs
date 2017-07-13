using ModernHall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModernHall.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        ModernHallEntities1 dbContext = new ModernHallEntities1();
        public ActionResult Index(int? packageType)
        {
            var userID = Session["UserID"];
            if (userID == null)
            {
                return RedirectToAction("Index", "Home");
            }
            BookingModel model = new BookingModel();
            model.PackageType = packageType;
            return View(model);
        }

        public ActionResult AddBooking(BookingModel model)
        {
            var userID = Convert.ToInt64(Session["UserID"]);
            var booking = new Booking
            {
                BookingDate = model.BookingDate,
                Title = model.Title,
                EventDescription = model.EventDescription,
                FullName = model.FullName,
                Location = model.Location,
                Mobile = model.Mobile,
                CreatedBy = userID,
                UserID = (int)userID,
                Createdon = DateTime.Now,
                PackageType = model.PackageType
            };
            dbContext.Bookings.Add(booking);
            dbContext.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("Index", new { packageType = model.PackageType });
        }

        public JsonResult GetDiaryEvents()
        {
            var ApptListForDate = dbContext.Bookings.ToList();
            var eventList = from e in ApptListForDate
                            select new
                            {
                                id = e.Id,
                                title = e.Title,
                                start = e.BookingDate.Value.ToString("yyyy-MM-dd"),
                            };
            var rows = eventList.ToArray();
            return Json(rows, JsonRequestBehavior.AllowGet);
        }

        public string PackageType(int packageType)
        {
            string package = string.Empty;
            switch (packageType)
            {
                case 1:
                    package = "Executive";
                    break;
                case 2:
                    package = "Royal";
                    break;
                case 3:
                    package = "Premium";
                    break;
            }
            return package;
        }

        public ActionResult BookingList()
        {
            var userID = Convert.ToInt64( Session["UserID"]);
            var userType = Convert.ToInt64(Session["Role"]);
            if (userID == null)
            {
                return RedirectToAction("Index", "Home");
            }
            BookingModel model = new BookingModel();
            if (userType == 1)
            {
                model.BookingList = dbContext.Bookings.Select(x => new BookingModel
                {
                    Title = x.Title,
                    EventDescription = x.EventDescription,
                    BookingDate = x.BookingDate.Value,
                    PackageType = x.PackageTypeId,
                    Mobile = x.Mobile,
                }).ToList();
            }
            else
            {
                model.BookingList = dbContext.Bookings.Where(x => x.UserID == userID).Select(x => new BookingModel
                {

                    Title = x.Title,
                    EventDescription = x.EventDescription,
                    BookingDate = x.BookingDate.Value,
                    PackageType = x.PackageTypeId,
                    Mobile = x.Mobile,
                   
                }).ToList();
            }
            //model.BookingList.ForEach(x =>
            //{
            //    x.PackageName = PackageType(x.PackageType.Value);
            //});
            return View(model);
        }
    }
}