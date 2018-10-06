using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test__Connection.Models;

namespace Test__Connection.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]

        public ActionResult Index()
        {

            return View();
        }



        //Lapses

        public ActionResult Lapses()
        {
           
            return View();
        }


        public ActionResult LapsesReturned(string Lowerdate, string Upperdate)
        {

            ThamesbankEntities10 _context = new ThamesbankEntities10();
       
            DateTime lowerdate = Convert.ToDateTime(Lowerdate);
            DateTime upperdate = Convert.ToDateTime(Upperdate);

            IEnumerable dateRange = _context.DateRangeLapseTEST(lowerdate, upperdate);

            return View(dateRange);

        }

        

        //Renewals

        public ActionResult Renewals()
        {
            return View();

        }

        

        public ActionResult RenewalsReturned(string Lowerdate, string Upperdate)
        {

            Phone_SystemEntities30 _contextTwo = new Phone_SystemEntities30();


            DateTime lowerdate = Convert.ToDateTime(Lowerdate);
            DateTime upperdate = Convert.ToDateTime(Upperdate);

            IEnumerable renewals = _contextTwo.pr_RenewalListtest(lowerdate, upperdate);

            return View(renewals);

        }



       

        //Prospects

        //GET
        public ActionResult Prospects()

        {
           
            return View();
        }


        
        public ActionResult ProspectsReturned(string Lowerdate, string Upperdate, string radioValue, string lowerdatecover, string upperdatecover)

        {
            ThamesbankEntities10 _context = new ThamesbankEntities10();

            var report = radioValue;


            DateTime lowerdate = Convert.ToDateTime(Lowerdate);
            DateTime upperdate = Convert.ToDateTime(Upperdate);


            if (report == "QuoteAndCover")
            {
                DateTime? lowerDateCover = Convert.ToDateTime(lowerdatecover);
                DateTime? upperDateCover = Convert.ToDateTime(upperdatecover);

                IEnumerable quoteReport = _context.ListHICallOuts_v3TESTS(report, lowerdate, upperdate, lowerDateCover, upperDateCover);
                return PartialView(quoteReport);

            }

            else
            {
                DateTime? lowerDateCover = null;
                DateTime? upperDateCover = null;

                IEnumerable quoteReport = _context.ListHICallOuts_v3TESTS(report, lowerdate, upperdate, lowerDateCover, upperDateCover);
                return PartialView(quoteReport);
            }

           

        }




        public ActionResult Test()
        {
            DateTime lowerdate = new DateTime(2018,5,1);
            DateTime upperdate = new DateTime(2018,5,4);


            DateTime? lowerDateCover = null;
            DateTime? upperDateCover = null;

            ThamesbankEntities10 _context = new ThamesbankEntities10();
            var report = "Quote";

            IEnumerable quoteReport = _context.ListHICallOuts_v3TESTS(report, lowerdate, upperdate, lowerDateCover, upperDateCover);
            return View(quoteReport);

        }





    }
}