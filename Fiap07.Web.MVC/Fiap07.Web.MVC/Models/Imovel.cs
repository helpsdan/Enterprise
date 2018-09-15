using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Imovel
    {
        public int ImovelId { get; set; }
        public string Endereco { get; set; }
        public decimal Valor { get; set; }

        //Relacionamentos
        public Escritura Escritura { get; set; }
        public int EscrituraId { get; set; }

        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        public IList<Corretor> Corretores { get; set; }
    }
}