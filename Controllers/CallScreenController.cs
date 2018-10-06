using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test__Connection.Models;

namespace Test__Connection.Controllers
{
    public class CallScreenController : Controller
    {
        // GET: CallScreen
        [HttpGet]
        public ActionResult Index(string reference, string name, string telephone, string renewalDate, string lastAnnualPremium, string thisYearsPremium, 
            string alternativePremium, string claimsMade, string premium, string quoteSource, string quoteDate, string coverDate)
        {
            ViewBag.Reference = reference;
            ViewBag.name =  name;
            ViewBag.telephone = telephone;
            ViewBag.renewalDate = renewalDate;
            ViewBag.lastAnnualPremium = lastAnnualPremium;
            ViewBag.thisYearsPremium =  thisYearsPremium;
            ViewBag.alternativePremium =  alternativePremium;
            ViewBag.claimsMade =  claimsMade;
            ViewBag.premium =  premium;
            ViewBag.quoteSource = quoteSource;
            ViewBag.quoteDate =  quoteDate;
            ViewBag.coverDate = coverDate;

            Phone_SystemEntities30 db = new Phone_SystemEntities30();

            CallOutcome model = new CallOutcome
            {

                Outcomes = new SelectList(db.CallOutcomeLists.ToList(), "OutcomeID", "Name")
                
            };

            return View(model);

        }


        // POST: CallScreen
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CallOutcome model)
        {

            Phone_SystemEntities30 db = new Phone_SystemEntities30();

            if (!ModelState.IsValid)
            {
                model.Outcomes = new SelectList(db.CallOutcomeLists.ToList(), "OutcomeID", "Name");
                return View (model);
            }

            string reference = model.Reference;

            CallOutcome model2 = db.CallOutcomes.FirstOrDefault(x => x.Reference == reference);

            if (model2 == null)
            {
                model.LastCalled = DateTime.Now;

                db.CallOutcomes.Add(model);
                db.SaveChanges();

                model.Outcomes = new SelectList(db.CallOutcomeLists.ToList(), "OutcomeID", "Name");

                ViewBag.Message = "Client Record Updated";
                return Redirect("~/Home/Index");

            }

            if (model.Reference == model2.Reference)
            {
                model.Reference = model2.Reference;
                model.Id = model2.Id;
                model.LastCalled = DateTime.Now;
                db.CallOutcomes.Add(model);
                db.CallOutcomes.Remove(model2);
                db.SaveChanges();
            }

            return Redirect("~/Home/Index");


        }






        public ActionResult RetrieveClient(string reference)
        {
            Phone_SystemEntities30 db = new Phone_SystemEntities30();

            pr_RenewalListtest_Result model = new pr_RenewalListtest_Result();

            var dateOne = DateTime.Now;

            var datethree = dateOne.AddYears(100);

            var datetwo = dateOne.AddYears(-30);

           
            model = db.pr_RenewalListtest(datetwo, datethree).Where(x => x.Reference == reference).FirstOrDefault();

            return View("RetrieveClient", model);


        }

      
    }
}
