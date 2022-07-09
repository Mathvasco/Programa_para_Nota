using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_para_Nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int mediaP, trabalho, nota1, nota2;
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a nota do trabalho: ");
            trabalho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota da primeira prova: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda prova: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            mediaP = (nota1 + nota2 + trabalho) / 3;

            if (mediaP >= 8.5)
            {
                Console.WriteLine("O conceito é A");
            }

            else if (mediaP >= 7)
            {
                Console.WriteLine("O conceito é B");
            }

            else if (mediaP >= 6)
            {
                Console.WriteLine("O conceito é C");
            }

            else if (mediaP >= 0.1)
            {
                Console.WriteLine("O conceito é D");
            }

            else if (mediaP == 0)
            {
                Console.WriteLine("O conceito é E");
            }



            Console.ReadKey();
        }
    }
}
