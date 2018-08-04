using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Pessoa
    {
        //Campos (atributos)
        sprivate string _nome;
        
        //Propriedades (gets e sets)
        public float Peso { get; set; }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }
    }
}