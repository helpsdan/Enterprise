using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Fiap.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        // Properties

        public decimal Taxa { get; set; }
        private readonly decimal _rendimento;

        // Constructor
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        // Methods
        public override void Depositar(decimal valor)
        {
            base.Depositar(valor);

            Console.WriteLine("Depositando " + valor + " reais");
        }

        public override void Retirar(decimal valor)
        {
            if(Saldo >= valor)
            {
                base.Retirar(valor + Taxa);
            }
            else
            {
                throw new Exception("Não foi possível fazer a retirada");
            }

            Console.WriteLine("Retirando " + valor + " reais");
        }

        public void CalculaRetornoInvestimento()
        {
            Console.WriteLine(Saldo * _rendimento);
        }
    }
}
