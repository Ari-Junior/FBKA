using FBKA_v2.Models;
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
        public ActionResult ConfirmData(ModUser user)
        {
            //if (user.Name == null || user.IdUser <= 0)
            //{
            //    ModelState.AddModelError("IdUser", "Id inválido");
            //}

            //if (user.Name == null || user.Name.Trim().Length <= 0)
            //{
            //    ModelState.AddModelError("Name", "O Nome precisa ser preenchido");
            //}


            //valida o modelo em caso de alguém burlar o JS.
            if (ModelState.IsValid == false)
            {
                return View("Register", user);
            }
            return View(user);

        }
    }
}