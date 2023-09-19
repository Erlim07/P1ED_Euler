using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    internal class Fila
    {
        private NoFila start;
        private NoFila end;

        internal NoFila Start { get => start; set => start = value; }
        internal NoFila End { get => end; set => end = value; }

        public Fila()
        {
            this.start = null;
            this.end = null;
        }

        public bool isEmpty()
        {
            if (this.start == null) return true; return false;
        }

        public void addElement(int data)
        {
            NoFila novono = new NoFila(data);
            if (this.isEmpty())
            {
                start = novono;
                end = novono;
            }
            else
            {
                end.Next = novono;
                end = novono;
            }
        }

        public int removeElement()
        {
            NoFila memo = start;
            start = start.Next;
            return memo.Data;
        }

        public void addWhere(int elem, int pos)
        {
            NoFila novono = new NoFila(elem);
            NoFila aux = start;
            while(aux != null)
            {
                if(aux.Data == pos)
                {
                    novono.Next = aux.Next;
                    aux.Next = novono;
                    return;
                }
                aux = aux.Next;
            }
        }

        public void printFila()
        {
            NoFila aux = start;
            if (isEmpty())
                Console.WriteLine("Fila Vazia!!!");
            else
            {
                while (aux != null)
                {
                    Console.WriteLine(aux.Data.ToString());
                    aux = aux.Next;
                }
            }
        }
    }
}
