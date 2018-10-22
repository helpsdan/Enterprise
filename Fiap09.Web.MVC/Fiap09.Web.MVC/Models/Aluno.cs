using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap09.Web.MVC.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public bool Aprovado { get; set; }

        public Turma Turma { get; set; }
        public int TurmaId { get; set; }
    }
}