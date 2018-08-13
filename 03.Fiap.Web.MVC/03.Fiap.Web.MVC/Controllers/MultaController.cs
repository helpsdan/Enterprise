using _03.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Fiap.Web.MVC.Controllers
{
    public class MultaController : Controller
    {
        [HttpGet]//abrir a página de formulario
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]//recuperar dados e cadastrar no db
        public ActionResult Cadastrar(Multa multa)
        {

            ViewBag.churros = multa.Placa;
            TempData["msg"] = "Multa Cadastrada!";
            return View(multa);
            // exibe a placa na tela
            //return Content(multa.Placa);
        }
    }
}