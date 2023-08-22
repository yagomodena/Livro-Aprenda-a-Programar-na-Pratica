using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosNaFaculdade
{
    class ClasseConverteString
    {
        private string nome;
        private string mnome;

        public String entrada()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome ou uma frase:\n");
            nome = Console.ReadLine();
            mnome = nome.ToUpper();
            return nome;
        }
    }
}
