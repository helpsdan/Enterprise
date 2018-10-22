using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap09.Web.MVC.Models
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public string Nome { get; set; }

        public IList<Aluno> Alunos { get; set; }
    }
}