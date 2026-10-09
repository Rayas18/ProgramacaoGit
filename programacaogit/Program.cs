using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacaogit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.nome = "Daniel";
            a1.anonascimento = 2010;

            Console.WriteLine("A idade de "+a1.nome+" é: " + a1.calcularidade());

            Console.ReadKey();
        }
    }
}
