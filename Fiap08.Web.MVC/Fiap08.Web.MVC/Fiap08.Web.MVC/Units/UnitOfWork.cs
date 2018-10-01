using Fiap08.Web.MVC.Persistencia;
using Fiap08.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private FutebolContext _context = new FutebolContext();

        private ITimeRepository _timeRepository;

        private IJogadorRepository _jogadoRepository;

        public IJogadorRepository JogadorRepository
        {
            get
            {
                if(_jogadoRepository == null)
                {
                    _jogadoRepository = new JogadorRepository(_context);
                }
                return _jogadoRepository;
            }
        }


        public ITimeRepository TimeRepository
        {
            get
            {
                if (_timeRepository == null)
                {
                    _timeRepository = new TimeRepository(_context);
                }
                return _timeRepository;
            }
        }

        //Fechar a conexão com o banco de dados
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

    }
}