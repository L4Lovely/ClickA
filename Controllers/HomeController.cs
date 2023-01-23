﻿using ClickA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace ClickA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new IndexView());
        }

        //public IActionResult MainView()
        //{
        //    return View();
        //}


        //Für Sql-Server folgendes einkommentieren und in Program.cs die Zeile mit SqlConnector mit NpgsqlConnecor tauschen

        //[HttpPost]
        //public IActionResult Index(SignUp su)
        //{
        //    SQLConnector.NewSignUp(su.Username, su.Password);
        //    return View(new IndexView());
        //}


        //[HttpPost]
        //public IActionResult MainView(IndexView iv)
        //{
        //    if (SQLConnector.SignIn(iv.Sfp.Username, iv.Sfp.Password))
        //    {
        //        SQLConnector.SFP = iv.Sfp;
        //        return View(SQLConnector.SFP);
        //    }
        //    else
        //    {
        //        iv.Message = true;
        //        return View("Index", iv);
        //    }
        //}

        //Folgendes auskommentieren um Sql-Connector zu nutzen

        [HttpPost]
        public IActionResult Index(SignUp su)
        {
            NpgsqlConnector.NewSignUp(su.Username, su.Password);
            return View(new IndexView());
        }


        [HttpPost]
        public IActionResult MainView(IndexView iv)
        {
            if (NpgsqlConnector.SignIn(iv.Sfp.Username, iv.Sfp.Password))
            {
                NpgsqlConnector.SFP = iv.Sfp;
                return View(SQLConnector.SFP);

            }
            else
            {
                iv.Message = true;
                return View("Index", iv);
            }
        }


        public IActionResult SignUp()
        {
            return View();
        }
    }
}
