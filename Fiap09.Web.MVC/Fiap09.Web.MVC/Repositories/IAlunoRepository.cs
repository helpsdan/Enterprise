using Fiap09.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap09.Web.MVC.Repositories
{
    public interface IAlunoRepository
    {
        void Cadastrar(Aluno aluno);
        IList<Aluno> Listar();
    }
}
