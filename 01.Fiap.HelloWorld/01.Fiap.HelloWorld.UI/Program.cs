using _01.Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um aluno
            Aluno aluno = new Aluno();
            aluno.Nome = "Jefty"; //Set
            Console.WriteLine(aluno.Nome);//Get
        }

    }
}
