using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test__Connection.Models;

namespace Test__Connection.Controllers
{
    public class ProspectsController : Controller
    {
        // GET: Prospects

        //public ActionResult ProspectsReturned(string Lowerdate, string Upperdate, string radioValue/*, string lowerdatecover, string upperdatecover*/)

        //{
        //    ThamesbankEntities3 _context = new ThamesbankEntities3();

        //    DateTime lowerdate = Convert.ToDateTime(Lowerdate);
        //    DateTime upperdate = Convert.ToDateTime(Upperdate);


        //    //CODE TO GO HERE 

        //    //DateTime? lowerDateCover = Convert.ToDateTime(lowerdatecover);
        //    //DateTime? upperDateCover = Convert.ToDateTime(upperdatecover);


        //    DateTime? lowerDateCover = null;
        //    DateTime? upperDateCover = null;


        //    var report = radioValue;

        //    IEnumerable quoteReport = _context.ListHICallOuts_v3(report, lowerdate, upperdate, lowerDateCover, upperDateCover);


        //    return PartialView(quoteReport);
        //}


        //------------------------------------------------------------------

        //  $(document).ready(function () {

        //    $('input[type ="radio"]').click(function() {


        //        if ($(this).attr('id') == 'quoteInput') {
        //            $('#quote').show();
        //        }

        //        else {
        //            $('#quote').hide();
        //        }

        //        if ($(this).attr('id') == 'coverInput') {
        //            $('#cover').show();
        //        }

        //        else {
        //            $('#cover').hide();
        //        }

        //        if ($(this).attr('id') == 'qCInput') {
        //                $('#quoteandcover').show();
        //        }

        //        else {
        //                $('#quoteandcover').hide();
        //        }

        //    });

            
       
        //    $("#btndatefilter").click(function() {
        //        var startdate = $('#datepicker-lower').val();
        //        var enddate = $('#datepicker-upper').val();
        //        var loaderImage = '<img src="/Content/Images/ajax-loader(1).gif" />'
        //        var quotesChecked = $("input[name='prospectsChecked']:checked").val();


        //        $("#newList").html(loaderImage);
        //        debugger
        //        $.ajax({
        //            url: "@(Url.Action("ProspectsReturned"))",
        //            type: "GET",
        //            data: { 'Lowerdate': startdate, 'Upperdate': enddate, 'radioValue': quotesChecked },
        //           cache: false,
        //           success: function(data) {
        //            //Fill div with results

        //               $("#newList").html(data);
        //            },
        //           error: function(xhr, status, error) {
        //                alert(xhr.responseText);
        //            }


        //        });

        //    });


        //});


    }
}