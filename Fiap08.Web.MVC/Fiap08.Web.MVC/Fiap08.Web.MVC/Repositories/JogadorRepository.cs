using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Persistencia;

namespace Fiap08.Web.MVC.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        private FutebolContext _context;
        //Construtor
        public JogadorRepository(FutebolContext context)
        {
            _context = context;
        }

        public object EntryState { get; private set; }

        public void Alterar(Jogador jogador)
        {
            _context.Entry(jogador).State = EntityState.Modified;
        }

        public Jogador Buscar(int codigo)
        {
            return _context.Jogadores.Find(codigo);
        }

        public IList<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro)
        {
            return _context.Jogadores.Where(filtro).ToList();
        }

        public void Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
        }

        public IList<Jogador> Listar()
        {
            return _context.Jogadores.ToList();
        }

        public void Remover(int codigo)
        {
            var jogador = Buscar(codigo);
            _context.Jogadores.Remove(jogador);
        }
    }
}