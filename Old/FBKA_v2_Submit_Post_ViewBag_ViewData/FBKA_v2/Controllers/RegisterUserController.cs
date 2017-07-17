﻿using FBKA_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBKA_v2.Controllers
{
    public class RegisterUserController : Controller
    {
        public ActionResult Register()// Tem que ser o mesmo nome do arquivo da View
        {
            ModUser user = new ModUser();

            return View(user);
        }
        
        [HttpPost]
        public ActionResult ConfirmData(FormCollection form)
        {
            ViewData["IdUser"] = form["IdUser"];
            ViewData["Name"] = form["Name"];
            ViewData["Email"] = form["Email"];
            return View();
        }
        [HttpPost]
        public ActionResult ConfirmDataTipado(ModUser user)
        {
            return View(user);
        }
    }
}