using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mediator;
using RandallQuesadaSPA.Interfaces;

namespace RandallQuesadaSPA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Call entity framework to connect to database
            UIUserMediator userMediator = new UIUserMediator("UserEfDal");

            IEnumerable<UserBase> users = userMediator.LoadUsers();

            return View();
        }

        public ActionResult DisplayUserProjectList()
        {
            return PartialView();
        }

    }
}