using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AuthSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace AuthSystem.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Donation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Donation(Donation ur)
        {
            string connection = "Server=tpisql01.avcol.school.nz ; Database=MVCAuthDB-Shravan;Trusted_Connection=True;MultipleActiveResultSets=true";
            
                using(SqlConnection sqlconn=new SqlConnection(connection))
                {
                string sqlquery = "insert into Donation(ID,Name,Email,PhoneNumner,Address,Suburb,City,PostCode,DonationAmount,CardNumber,CVV,ExpirationDate) values " +
                    "('" + ur.ID + "', '" + ur.Name + "','" + ur.Email + "', '" + ur.PhoneNumber + "', '" + ur.Address + "', '" + ur.Suburb + "', '" + ur.City + "', '" + ur.PostCode + "', '" + ur.DonationAmount + "', '" + ur.CardNumber + "', '" + ur.CVV + "', '" + ur.ExpirationDate + "')";
                using (SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn))
                {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    ViewData["Message"] = "Donation is accepted";
                    return View(ur);
                }
            }
       
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
