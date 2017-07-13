using ModernHall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModernHall.Controllers
{
    public class UserAccountController : Controller
    {
        ModernHallEntities _dbContext = new ModernHallEntities();
        // GET: UserAccount
        public ActionResult Index()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            var user = new User
            {
                Name = model.Name,
                EmailID = model.EmailID,
                Mobile = model.Mobile,
                Password = model.Password,
                UserType = 2,//customer;
                CreatedOn = DateTime.Now
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            Session["UserID"] = user.Id;
            Session["Role"] = user.UserType;
            return RedirectToAction("Index", "Booking");
        }

        public ActionResult Login(UserModel model)
        {
            var user = _dbContext.Users.Where(x => x.EmailID == model.EmailID && x.Password == model.Password).FirstOrDefault();
            if (user != null)
            {
                Session["UserID"] = user.Id;
                Session["Role"] = user.UserType;
                if (user.UserType == 1)
                    return RedirectToAction("BookingList", "Booking");
                else
                    return RedirectToAction("Index", "Booking");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            Session["UserID"] = null;
            Session["Role"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}