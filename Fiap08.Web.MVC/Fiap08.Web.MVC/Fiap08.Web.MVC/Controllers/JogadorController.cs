using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap08.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarTimes();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _unit.JogadorRepository.Cadastrar(jogador);
            _unit.Salvar();
            TempData["msg"] = "Jogador cadastrado!";
            return RedirectToAction("Cadastrar");
        }
        private void CarregarTimes()
        {
            //Buscar por todas as categorias
            var lista = _unit.TimeRepository.Listar();
            //Enviar para a tela a lista de categorias para o select
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
        }
        //Libera os recursos
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}