using Exercicio1Fiap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Fiap
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc1 = new ContaCorrente()
            {
                Agencia = 1234,
                Numero = 1234567,
                Saldo = 0,
                tipo = TipoConta.Comum
            };

            ContaPoupanca cp1 = new ContaPoupanca(5)
            {
                Agencia = 3214,
                Numero = 5431455,
                Saldo = 0,
                Taxa = 2
            };

            //cc1.Depositar(1000);
            cp1.Depositar(1000);


            //cc1.Retirar(1001);
            cp1.Retirar(1001);
        }
    }
}

