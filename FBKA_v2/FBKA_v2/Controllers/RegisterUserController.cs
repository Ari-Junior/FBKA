using FBKA_v2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ActionResult ValidNames (string Name, int IdUser)
        {
            if(IdUser == 0)
            {
                return Json(string.Format("Primeiro preencha o Código do Aluno"), JsonRequestBehavior.AllowGet);
            }
            if(Name.Length <3 || Name.Length >= 50)
            {
                return Json(string.Format("O campo Nome deve ter entre 3 e 50 caracteres"), JsonRequestBehavior.AllowGet);
            }
            var NamesDB = new Collection<string>
            {
                "ari",
                "carlos",
                "matheus",
                "caio",
                "roberto"
            };
            if (NamesDB.IndexOf(Name.ToLower()) >= 0)
            {
                return Json(string.Format("Nome '{0}' já cadastrado", Name), JsonRequestBehavior.AllowGet);
            }
            return Json(true,JsonRequestBehavior.AllowGet);
        }
    }
}