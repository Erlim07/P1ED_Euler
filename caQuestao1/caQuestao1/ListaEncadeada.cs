using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{
    internal class ListaEncadeada
    {
        public NoLista cabeca;

        public ListaEncadeada() 
        {
            cabeca = new NoLista();
            cabeca.Anterior = null;
            cabeca.Posterior = null;
        }

        public bool estaVazia()
        {
            if (cabeca.Anterior == null && cabeca.Posterior == null)
                return true;
            return false;
        }

        public void insere(int _info)//1
        {
            NoLista auxNovo = new NoLista(_info);
            if (estaVazia())
            {
                cabeca.Anterior = auxNovo; cabeca.Posterior = auxNovo;
                auxNovo.Anterior = cabeca; auxNovo.Posterior = cabeca;
            }
            else
            {
                auxNovo.Posterior = cabeca.Anterior;
                auxNovo.Posterior.Anterior = auxNovo;
                auxNovo.Anterior = cabeca;
                cabeca.Anterior = auxNovo;

            }
        }//fim 1

        public int remove(int aremover)//2
        {
            if (this.cabeca.Anterior.Info == aremover)
            {
                cabeca.Anterior = cabeca.Anterior.Posterior;
                //primeiro é o segundo
                cabeca.Anterior.Anterior = cabeca;
                //antes segundo q agr é primeiro tem o anterior setado pro cabeca
                return aremover;
            }
            else if (this.cabeca.Posterior.Info == aremover)
            {
                Console.WriteLine("Ultimo"); 
                cabeca.Posterior = cabeca.Posterior.Anterior;
                Console.WriteLine(cabeca.Posterior.Info);
                cabeca.Posterior.Posterior = cabeca;
                return aremover;
            }
            else
            {
                NoLista temp = cabeca.Anterior.Posterior;
                while (temp != cabeca.Posterior)
                {
                    if (temp.Info == aremover)
                    {
                        temp.Anterior.Posterior = temp.Posterior;
                        temp.Posterior.Anterior = temp.Anterior;
                        return aremover;
                    }
                    temp = temp.Posterior;
                }
                return -1;
            }
        }//fim 2

        public int maior()//3
        {
            NoLista temp = cabeca.Anterior;
            int maior = cabeca.Anterior.Info;
            while (temp != cabeca)
            {
                if (temp.Info > maior)
                {
                    maior = temp.Info;
                }
                temp = temp.Posterior;
            }
            return maior;
        }// fim 3

        public void imprime()
        {
            NoLista temp = cabeca.Anterior;
            while (temp != cabeca)
            {
                Console.WriteLine(temp.Info);
                temp = temp.Posterior;
            }
        }
    }
}
