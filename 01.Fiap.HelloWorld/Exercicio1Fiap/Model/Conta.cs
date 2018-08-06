using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Fiap.Model
{
    abstract class Conta
    {
        //Properties
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }

        // Methods

        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine("Depositando " + valor + " reais");
        }

        public virtual void Retirar(decimal valor)
        {
            Saldo -= valor;
            Console.WriteLine("Retirando " + valor + " reais");
        }

    }
}
