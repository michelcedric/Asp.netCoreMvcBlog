﻿using AspNetCoreBlogTutorial.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreBlogTutorial.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Person person = new Person()
            {
                ID = 1,
                LastName = "Michel",
                FirstName = "Cedric"
            };
            return View(person);
        }
    }
}
