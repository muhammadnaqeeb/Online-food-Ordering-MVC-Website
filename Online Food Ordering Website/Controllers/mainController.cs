using Online_Food_Ordering_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Food_Ordering_Website.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult mainFirstPage()
        {
            return View();
        }
        // Register
        CustumerContext dc = new CustumerContext();
        public ActionResult RegisterCustumer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterCustumer(CustumerRegister cusTumer)
        {
            if (ModelState.IsValid)
            {
                dc.custumer_Reg.Add(cusTumer);
                dc.SaveChanges();
                return RedirectToAction("LoginCustumer");
            }
            else
            {
                // return ModelState.AddModelError("Error OCCURIED!");

            }
            return View(cusTumer);
        }


        // login and validation
        // (get and post view for login)
        public ActionResult LoginCustumer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginCustumer(CustumerRegister cus)
        {
            if (ModelState.IsValid)
            {

                using (CustumerContext db = new CustumerContext())
                {

                    var result = db.custumer_Reg.Where(U => U.cu_email.Equals(cus.cu_email)
                    && U.cu_password.Equals(cus.cu_password)).FirstOrDefault();

                    if (result != null)
                    {

                        return RedirectToAction("mainFirstPage");

                    }
                    else
                    {
                    }
                }
            }
            return View(cus);
        }
    }
}
