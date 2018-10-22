using Fiap09.Web.MVC.Persistencia;
using Fiap09.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap09.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private EscolaContext _context = new EscolaContext();

        private IAlunoRepository _alunoRepository;

        public IAlunoRepository AlunoRepository
        {
            get
            {
                if (_alunoRepository == null)
                {
                    _alunoRepository = new AlunoRepository(_context);
                }
                return _alunoRepository;
            }
        }

        private ITurmaRepository _turmaRepository;

        public ITurmaRepository TurmaRepository
        {
            get
            {
                if (_turmaRepository == null)
                {
                    _turmaRepository = new TurmaRepository(_context);
                }
                return _turmaRepository;
            }            
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}