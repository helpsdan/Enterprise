using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap09.Web.MVC.Models;
using Fiap09.Web.MVC.Persistencia;

namespace Fiap09.Web.MVC.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private EscolaContext _context;

        public AlunoRepository(EscolaContext context)
        {
            _context = context;
        }

        public void Cadastrar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
        }

        public IList<Aluno> Listar()
        {
            return _context.Alunos.Include("Turma").ToList();
        }
    }
}