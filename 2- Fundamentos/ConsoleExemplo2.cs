using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosNaFaculdade._2__Fundamentos
{
    class TiposInterios
    {
        class ConsoleExemplo2
        {
            static void Linha()
            {
                for (int linha = 1; linha <= 40; linha++)
                {
                    Console.Write("-");
                }
            }

            static void Main(string[] args)
            {
                byte idade1 = 30;
                sbyte idade2 = 40;
                short valor1 = 30000;
                ushort valor2 = 65535;
                int pontos1 = 10000;
                uint pontos2 = 30000;
                ulong contador = 2000000;
                long contagem = 8000000;

                Linha();

                Console.SetCursorPosition(10, 1);
                Console.Write("Tipos Inteiros em C#\n");
                Linha();
                Console.WriteLine("\n\nVariável do tipo byte : {0}", idade1);
                Linha();
                Console.WriteLine("\n\nVariável do tipo sbyte : {0}", idade2);
                Linha();
                Console.WriteLine("\n\nVariável do tipo short : {0}", valor1);
                Linha();
                Console.WriteLine("\n\nVariável do tipo ushort : {0}", valor2);
                Linha();
                Console.WriteLine("\n\nVariável do tipo int : {0}", pontos1);
                Linha();
                Console.WriteLine("\n\nVariável do tipo uint : {0}", pontos2);
                Linha();
                Console.WriteLine("\n\nVariável do tipo ulong : {0}", contador);
                Linha();
                Console.WriteLine("\n\nVariável do tipo long : {0}", contagem);
                Linha();

                Console.Write("\n\nPressione qualquer tecla...\n\n");
                Linha();
                Console.ReadKey();
            }
        }
    }
}
