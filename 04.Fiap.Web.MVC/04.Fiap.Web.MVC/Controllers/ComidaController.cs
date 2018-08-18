using _04.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04.Fiap.Web.MVC.Controllers
{
    public class ComidaController : Controller
    {
        //Simular um Banco de Dados
        private static List<Comida> _banco = new List<Comida>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_banco); //envia a lista para a tela
        }


        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Comida comida)
        {
            // cadastrar no "banco"
            _banco.Add(comida);
            //enviar mensagem de sucesso para a pagina
            TempData["msg"] = "Comida Cadastrada!";
            //redirect para pagina de cadastro novamente
            return RedirectToAction("Cadastrar");
        }
    }
}