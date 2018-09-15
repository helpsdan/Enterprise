using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Escritura
    {
        public int EscrituraId { get; set; }
        public string Proprietario { get; set; }

        [Display(Name="Número Cartório")]
        public int NumeroCartorio { get; set; }
    }
}