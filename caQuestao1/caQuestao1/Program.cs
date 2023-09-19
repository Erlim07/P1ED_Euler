using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{
    internal class Program
    {

        static int questionadora()
        {
            Console.WriteLine("Qual acao deseja realisar? ");
            Console.WriteLine("[1]Inserir inteiro na Lista");
            Console.WriteLine("[2]Remover inteiro da lista");
            Console.WriteLine("[3]Imprimir o maior elemento da lista"   );
            Console.WriteLine("[4]Imprimir a lista");
            Console.WriteLine("[5] SAIR");
            return Convert.ToInt16(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            int aux = questionadora();
            
            ListaEncadeada lista = new ListaEncadeada();

            while(aux != 5)
            {
                if(aux == 1)
                {
                    Console.WriteLine("Qual inteiro quer inserir? ");
                    lista.insere(Convert.ToInt32(Console.ReadLine()));

                    aux = questionadora();
                }
                else if(aux == 2)
                {
                    Console.WriteLine("Qual inteiro quer remover? ");
                    Console.WriteLine("Voce removeu " +lista.remove(Convert.ToInt32(Console.ReadLine())));

                    aux = questionadora();
                }
                else if(aux == 3)
                {
                    Console.WriteLine(lista.maior());
                    aux = questionadora();
                }
                else if( aux == 4) 
                {
                    lista.imprime();
                    aux = questionadora();
                }
            }


        }
    }
}
