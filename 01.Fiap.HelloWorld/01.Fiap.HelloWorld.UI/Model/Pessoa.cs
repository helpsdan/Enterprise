using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{

    /*
        Classe abstrata: não pode ser instanciada e pode conter métodos abstratos.
         */
    abstract class Pessoa
    {

        // cprop -> tab tab
        // Constructor
        public Pessoa(string nome)
        {
            this._nome = nome;
        }

        //Campos (atributos)
        private string _nome;
        
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

        public Genero Genero { get; set; }

        // métodos
        // virtual -> permite a sobrescrita de método
        public virtual void Estudar()
        {
            Console.WriteLine("Pessoa estudando");
        }

        public abstract void FazerProva();


    }
}