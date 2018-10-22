using Fiap09.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap09.Web.MVC.Repositories
{
    public interface ITurmaRepository
    {
        void Cadastrar(Turma turma);
        void Atualizar(Turma turma);
        void Remover(int codigo);
        IList<Turma> Listar();
        IList<Turma> BuscarPor(Expression<Func<Turma, bool>> filtro);
        Turma Buscar(int codigo);
    }
}
