using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap09.Web.MVC.Models;
using Fiap09.Web.MVC.Persistencia;

namespace Fiap09.Web.MVC.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        private EscolaContext _context;

        public TurmaRepository(EscolaContext context)
        {
            _context = context;
        }

        public void Atualizar(Turma turma)
        {
            _context.Entry(turma).State = EntityState.Modified;
        }

        public Turma Buscar(int codigo)
        {
            return _context.Turmas.Find(codigo);
        }

        public IList<Turma> BuscarPor(Expression<Func<Turma, bool>> filtro)
        {
            return _context.Turmas.Where(filtro).ToList();
        }

        public void Cadastrar(Turma turma)
        {
            _context.Turmas.Add(turma);
        }

        public IList<Turma> Listar()
        {
            return _context.Turmas.ToList();
        }

        public void Remover(int codigo)
        {
            var turma = Buscar(codigo);
            _context.Turmas.Remove(turma);
        }
    }
}