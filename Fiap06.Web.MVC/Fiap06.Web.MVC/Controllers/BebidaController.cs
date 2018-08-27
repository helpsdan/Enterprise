using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class BebidaController : Controller
    {
        private BotecoContext _context = new BotecoContext();

        [HttpPost]
        public ActionResult Excluir(Bebida bebida)
        {
            // apaga a bebida do banco de dados
            _context.Bebidas.Remove(bebida);
            _context.SaveChanges();
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            // Busca a bebida no banco de dados
            var bebida = _context.Bebidas.Find(id);
            // retorna a view com o objeto bebida
            return View(bebida);
        }

        [HttpPost]
        public ActionResult Atualizar(Bebida bebida)
        {
            //Atualiza no banco da dados
            _context.Entry(bebida).State = EntityState.Modified;
            _context.SaveChanges();
            //mensagem
            TempData["msg"] = "Bebida atualizada!";
            //retornar
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Bebida bebida)
        {
            _context.Bebidas.Add(bebida);
            _context.SaveChanges();
            TempData["msg"] = "Bebida cadastrada!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Retornar uma lista
            return View(_context.Bebidas.ToList());
        }

    }
}