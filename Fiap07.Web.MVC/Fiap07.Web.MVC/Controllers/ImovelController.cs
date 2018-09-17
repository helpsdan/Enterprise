using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class ImovelController : Controller
    {
        private ImobiliariaContext _context = new ImobiliariaContext();



        [HttpGet]
        public ActionResult Listar()
        {
            CarregarCategorias();
            // Incluide -> carrega os dados do relacionamento
            var lista = _context.Imoveis.Include("Categoria").ToList();
            var lista2 = _context.Imoveis.Include("Escritura").ToList();
            //Retornar uma lista
            return View(_context.Imoveis.ToList());
        }

        [HttpGet]
        public ActionResult Buscar(int? categoriaId)
        {
            CarregarCategorias();
            // Incluide -> carrega os dados do relacionamento
            var lista = _context.Imoveis.Include("Categoria").Where(c => c.CategoriaId == categoriaId || categoriaId == null).ToList();
            var lista2 = _context.Imoveis.Include("Escritura").ToList();
            //retornar para a página listar com a lista de bebidas
            return View("Listar", lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarCategorias();
            return View();
        }

        private void CarregarCategorias()
        {
            //Buscar por todas as categorias
            var lista = _context.Categorias.ToList();
            //Enviar para a tela a lista de categorias para o select
            ViewBag.categorias = new SelectList(lista, "CategoriaId", "Nome");
        }

        [HttpPost]
        public ActionResult Cadastrar(Imovel imovel)
        {
            _context.Imoveis.Add(imovel);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }


    }
}