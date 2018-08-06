using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Fiap.Model
{
    sealed class ContaCorrente : Conta
    {
        // Properties
        public TipoConta tipo { get; set; }

        // Methods
        public override void Depositar(decimal valor)
        {
            base.Depositar(valor);

            Console.WriteLine("Depositando " + valor + " reais");
        }

        public override void Retirar(decimal valor)
        {
            if (tipo == TipoConta.Comum && Saldo >= valor)
            {
                base.Retirar(valor);
            }
            else
            {
                throw new Exception("Erro ao realizar retirada");
            }

            Console.WriteLine("Retirando " + valor + " reais");
        }


    }
}
