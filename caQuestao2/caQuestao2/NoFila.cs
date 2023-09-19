using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    internal class NoFila
    {
        private int data;
        private NoFila next;

        public NoFila() //construtor default
        {

        }

        public NoFila(int _data)
        {
            this.data = _data;
            next = null;
        }

        public NoFila(int _data, NoFila _next)
        {
            this.data = _data;
            this.next = _next;
        }

        public int Data { get => data; set => data = value; }
        internal NoFila Next { get => next; set => next = value; }
    }
}
