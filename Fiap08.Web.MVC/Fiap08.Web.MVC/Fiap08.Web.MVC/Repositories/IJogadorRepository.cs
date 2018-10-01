using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap08.Web.MVC.Repositories
{
    public interface IJogadorRepository
    {
        Jogador Buscar(int codigo);
        void Remover(int codigo);
        IList<Jogador> Listar();
        void Alterar(Jogador jogador);
        void Cadastrar(Jogador jogador);
        IList<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro);
    }
}
