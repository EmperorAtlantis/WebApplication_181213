using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_181213.Models.DataModel.Entity;
using WebApplication_181213.Models.ServiceModel;

namespace WebApplication_181213.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Verify()
        {
            string name = Request.Params.GetValues("Name")[0];
            string pwd = Request.Params.GetValues("Pwd")[0];
            UserService service = new UserService();
            ViewBag.CheckUser= service.CheckUser(new Users(name, pwd));
            return View();
        }
    }
}