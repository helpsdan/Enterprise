using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Professor /*EXTENDS*/: Pessoa, ITrabalhador
    {

        //Constructor
        public Professor(string nome):base(nome)
        {

        }

        public string Pf { get; set; }
        public IList<string> Disciplinas { get; set; }


        // Métodos 
        public override void FazerProva()
        {
            Console.WriteLine("Professor desenvolvendo a prova");
        }

        public void ReceberSalario()
        {
            Console.WriteLine("Ganhando Dinheiro");
        }

        public void TirarFerias()
        {
            Console.WriteLine("Tirando férias");
        }
    }
}
