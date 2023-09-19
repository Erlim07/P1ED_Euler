using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao3
{
    internal class Pilha
    {
        private NoPilha topo;
        private int porto;

        public int Porto { get => porto; set => porto = value; }
        internal NoPilha Topo { get => topo; set => topo = value; }

        public Pilha(int _porto)
        {
            this.topo = null;
            this.porto = _porto;
        }

        public Pilha(NoPilha _topo, int _porto)
        {
            this.topo = _topo;
            this.porto = _porto;
        }

        public bool estaVazia()
        {
            if (topo == null) return true;
            else return false;
        }

        public void inserir(string codigo)
        {
            if (estaVazia())
            {
                NoPilha novoNo = new NoPilha(codigo);
                topo = novoNo;
            }
            else if (estaCheia())
            {
                Console.WriteLine("Impossível empilhar! | Pilhas cheias");
            }
            else
            {
                NoPilha novoNo = new NoPilha(codigo, topo);
                topo = novoNo;
            }
        }

        public string remover()
        {
            if (estaVazia())
            {
                return "Impossível desempilhar";
            }
            else
            {
                string removido = topo.Codigo;
                topo = topo.Antes;
                return removido;
            }
        }

        public int qtdNaPilha()
        {
            int n = 0;
            NoPilha temp = topo;
            while (temp != null)
            {
                temp = temp.Antes;
                n++;
            }
            return n;
        }

        public bool estaCheia()
        {
            if (qtdNaPilha() >= 3)
            {
                return true;
            }
            else return false;
        }

        public bool codigoExiste(string codigo)
        {
            NoPilha temp = topo;
            while (temp != null)
            {
                if (temp.Codigo == codigo)
                {
                    return true;
                }
                temp = temp.Antes;
            }
            return false;
        }

        public void imprimir()
        {
            Console.WriteLine("A pilha " + (this.porto + 1) + " possui:");
            NoPilha atual = topo;
            while (atual != null)
            {
                Console.WriteLine(atual.Codigo);
                atual = atual.Antes;
            }
        }
    }
}
