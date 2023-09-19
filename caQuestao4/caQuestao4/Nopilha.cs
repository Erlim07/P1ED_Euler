using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao4
{
    internal class Nopilha
    {
        int info;
        Nopilha next;

        public Nopilha()
        {
            next = null;
        }

        public Nopilha(int _info)
        {
            info = _info;
            next = null;
        }

        public int Info { get => info; set => info = value; }
        internal Nopilha Next { get => next; set => next = value; }
    }
}
