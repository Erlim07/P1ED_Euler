using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    internal class Program
    {

        static int questionadora()
        {
            Console.WriteLine("Qual acao deseja realisar? ");
            Console.WriteLine("[1]Inserir inteiro na Fila");
            Console.WriteLine("[2]Remover inteiro da Fila");
            Console.WriteLine("[3]Inserir após um outro a ser escolhido");
            Console.WriteLine("[4]Imprimir a lista");
            Console.WriteLine("[5] SAIR");
            return Convert.ToInt16(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int aux = questionadora();

            Fila fila = new Fila();
            while(aux != 5)
            {
                if(aux == 1)
                {
                    Console.WriteLine("Qual elemento deseja adicionar? ");
                    fila.addElement(Convert.ToInt32(Console.ReadLine()));

                    aux = questionadora();
                }
                else if (aux == 2)
                {
                    Console.WriteLine("Voce removeu o int" + fila.removeElement());

                    aux = questionadora();
                }
                else if (aux == 3)
                {
                    Console.WriteLine("Qual elemento quer inserir?");
                    int elem = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Quer inserir após qual elemento?");
                    int pos = Convert.ToInt32(Console.ReadLine());

                    fila.addWhere(elem, pos);

                    aux = questionadora();
                }
                else if (aux == 4)
                {
                    fila.printFila();

                    aux = questionadora();
                }   
            }
        }
    }
}
