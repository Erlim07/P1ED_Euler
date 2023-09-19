using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao4
{
    internal class Pilha
    {
        Nopilha topo;


        public Pilha()
        {
            topo = null;
        }

        public void addNo(int info)
        {
            Nopilha aux = topo;
            topo = new Nopilha(info);
            topo.Next = aux;
        }

        public int somaTd(Nopilha aux = null) 
        {
            if(aux == null)
            {
                aux = topo;
            }
            
            if(aux.Next != null)
            {
                return aux.Info + somaTd(aux.Next);
            }
            else
            {
                return aux.Info;
            }
            
            
        }

        public void printPilha()
        {
            Nopilha aux = topo;
            while (aux != null)
            {
                Console.WriteLine(aux.Info);
                aux = aux.Next;
            }
        }
    }
}
