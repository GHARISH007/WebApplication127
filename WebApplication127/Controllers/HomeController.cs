using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using WebApplication127.Models;

namespace WebApplication127.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()

        {
            var obj = new HomeViewModel()

            {
                Name = "harish",
                id = 23,
                
            };
           

                    return View(obj);
          

        }



        [HttpPost]

        public IActionResult Update(HomeViewModel obj)
        {

            var name = obj.Name;

            return View("Index");


        }

        [HttpPost]
        public IActionResult Getval(HomeViewModel obj) {
            var ivla = obj.id;
            return View("Index");
        }
    }
}