using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacaogit
{
    internal class Aluno
    {
        //atributos
        public string nome;
        public int anonascimento;



        //metodos
        public int calcularidade()
        {
            return 2026 - this.anonascimento;

        }
            
        
    }
}
