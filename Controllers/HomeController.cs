﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult About()
        {
            return View("About");   
        }
        public ViewResult Contact() 
        {
            return View();
        }

    }
}
