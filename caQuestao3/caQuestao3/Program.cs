using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao3
{
    internal class Program
    {

        static int questionadora()
        {
            Console.WriteLine("[1] empilhar container.");
            Console.WriteLine("[2] desempilhar container.");
            Console.WriteLine("[3] imprimir conteudo.");
            Console.WriteLine("[4] parar.");
            Console.WriteLine("Insira o código da acao que deseja: ");
            int b = Convert.ToInt16(Console.ReadLine());
            return b;
        }

        static void Main(string[] args)
        {
            Pilha[] pilhas = new Pilha[4];
            pilhas[0] = new Pilha(0);
            pilhas[1] = new Pilha(1);
            pilhas[2] = new Pilha(2);
            pilhas[3] = new Pilha(3);


            int a = questionadora();

            while (a == 1 | a == 2 | a == 3)
            {
                if (a == 1)
                {
                    //inserindo um container
                    Console.WriteLine("Insira o código do container: ");
                    string codigo = Console.ReadLine();
                    //confirmar se o código já existe
                    bool existe = false;
                    for (int i = 0; i < 4; i++)
                    {
                        if (pilhas[i].codigoExiste(codigo))
                        {
                            existe = true;
                        }
                    }


                    if (!existe)
                    {
                        int menorpilha = 4;
                        int menorqtd = 4;
                        //acha a pilha com menos containers
                        for (int i = 0; i < 4; i++)
                        {
                            if (pilhas[i].qtdNaPilha() < menorqtd)
                            {
                                menorqtd = pilhas[i].qtdNaPilha();
                                menorpilha = pilhas[i].Porto;
                            }
                        }
                        //Insere o container(caso esteja cheio já tratei na classe)
                        pilhas[menorpilha].inserir(codigo);
                        if (!pilhas[menorpilha].estaCheia())
                        {
                            Console.WriteLine("Inserido na pilha " + (menorpilha + 1));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Código inválido! | Container já existe");
                    }

                    a = questionadora();

                }
                else if (a == 2)
                {
                    Console.WriteLine("Insira o código do container: ");
                    string codigo = Console.ReadLine();
                    //variavel para checar se está no topo ou não
                    bool problemas = true;
                    //checando se o container existe
                    bool existe = false;
                    bool td_vazio = true;
                    for (int i = 0; i < 4; i++)
                    {
                        if (pilhas[i].codigoExiste(codigo))
                        {
                            existe = true;
                        }
                        if (!pilhas[i].estaVazia())
                        {
                            td_vazio = false;
                        }

                    }

                    if (td_vazio)
                    {
                        Console.WriteLine("Impossivel desempilhar! | Nao há containers!");
                    }
                    else
                    {
                        if (existe)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (pilhas[i].Topo == null)
                                {
                                    continue;
                                }
                                else if (pilhas[i].Topo.Codigo == codigo)
                                {
                                    pilhas[i].remover();
                                    problemas = false;
                                    Console.WriteLine("Container removido da pilha " + (i + 1));
                                }
                            }
                            if (problemas)
                            {
                                Console.WriteLine("Impossível desempilhar! | Container não está no topo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Código inválido! | Container não existe");
                        }
                    }
                    a = questionadora();
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        pilhas[i].imprimir();
                    }
                    a = questionadora();
                }
            }
        }
    }
}
