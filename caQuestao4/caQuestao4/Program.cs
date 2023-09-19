using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao4
{
    internal class Program
    {

        static int questionadora()
        {
            Console.WriteLine("[1] adicionar elemento.");
            Console.WriteLine("[2] retornar soma.");
            Console.WriteLine("[3] imprime. ");
            Console.WriteLine("[4] parar.");
            Console.WriteLine("Insira o código da acao que deseja: ");
            int b = Convert.ToInt16(Console.ReadLine());
            return b;
        }
        static void Main(string[] args)
        {
            int aux = questionadora();

            Pilha pilha = new Pilha();
            while(aux != 4)
            {
                if (aux == 1)
                {
                    Console.WriteLine("Qual elemento deseja adicionar?");
                    pilha.addNo(Convert.ToInt32(Console.ReadLine()));

                    aux = questionadora();
                }
                else if (aux == 2)
                {
                    Console.WriteLine("A soma dos elementos é: " + pilha.somaTd());

                    aux = questionadora();
                }
                else if (aux == 3)
                {
                    pilha.printPilha();

                    aux = questionadora();
                }
            }
        }
    }
}
