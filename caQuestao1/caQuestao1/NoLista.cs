using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{
    internal class NoLista
    {
        private int info;
        private NoLista anterior;//qnd cabeca, primeiro
        private NoLista posterior;//qnd cabeca, ultimo



        public NoLista()
        {

        }

        public NoLista(int info)
        {
            this.info = info;
            this.anterior = null;
            this.posterior = null;
        }

        public int Info { get => info; set => info = value; }
        internal NoLista Anterior { get => anterior; set => anterior = value; }
        internal NoLista Posterior { get => posterior; set => posterior = value; }

    }
}
