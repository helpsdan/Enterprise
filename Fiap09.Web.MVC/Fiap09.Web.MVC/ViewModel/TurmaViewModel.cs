using Fiap09.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap09.Web.MVC.ViewModel
{
    public class TurmaViewModel
    {
        public Turma Turma { get; set; }

        public IList<Turma> Turmas { get; set; }
    }
}