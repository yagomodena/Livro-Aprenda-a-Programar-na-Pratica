using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EstudosNaFaculdade
{
    class ClassPrincipal
    {
        static void Linha()
        {
            Console.WriteLine("========================================================");
        }
        static void Main(string[] args)
        {
            bool inicio = false;

            while(inicio != true)
            {
                Console.Clear();
                int op;
                
                ClasseConverteString muda = new ClasseConverteString();
                
                ClasseOrdena ordenar = new ClasseOrdena();

                Linha();
                Console.SetCursorPosition(15, 1);
                Console.Write("Menu de Opções\n");
                
                Linha();
                Console.SetCursorPosition(10, 4);
                Console.Write("1- Conversão de String");
                Console.SetCursorPosition(10, 6);
                Console.Write("2- Ordernar números");
                Console.SetCursorPosition(10, 8);
                Console.Write("3- Finalizar\n\n");

                Linha();
                Console.SetCursorPosition(15, 11);
                Console.Write("Opção[ ]");
                Console.SetCursorPosition(21, 11);

                try
                {
                    op = int.Parse(Console.ReadLine());

                    if(op == 1)
                    {
                        Console.WriteLine("\nA frase convertida ->" + muda.entrada());
                    }
                    if(op == 2)
                    {
                        ordenar.organizar();
                    }
                    if(op == 3)
                    {
                        Console.Clear();
                        inicio = true;
                        Console.WriteLine("***** FIM DE EXECUÇÃO *****");
                    }
                    else if(op != 1 && op != 2 && op != 3)
                    {
                        Console.WriteLine("\n\n***** OPÇÃO INVALÍDA!!! *****");
                    }

                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.Clear();
                    Linha();
                    Console.WriteLine("\nDigite um dos valores das opções!\n\nTente novamente!");
                    Linha();
                    Console.ReadLine();
                }
            }
        }
    }
}
