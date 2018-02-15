using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNet.Models;

namespace WebNet.Controllers
{
    public class HomeController : Controller
    {
        WebNetContext db = new WebNetContext();

        public ActionResult Index()
        {
            db.Users.Add(new User
            {
                FName = "Lenny",
                LName = "Wright",
                Login = "flower11",
                Password = "545454",
                Email = "flo1990@gmail.com",
                Phone = "+190698756964",
                CreatedAt = DateTime.Now,
                Gender = true,
                isOnline = false,
                Salt = "tdrtrd5454ydry4r5y4d6dx45",
                isDeleted = false
            });

            db.SaveChanges();

            // получаем из бд все объекты User
            IEnumerable<User> users = db.Users;
            // передаем все объекты в динамическое свойство Users в ViewBag
            ViewBag.Users = users;
            // возвращаем представление
            return View();
        }
    }
}