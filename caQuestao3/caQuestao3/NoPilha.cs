using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao3
{
    internal class NoPilha
    {
        private string codigo;
        private NoPilha antes;


        public NoPilha(string codigo)
        {
            this.codigo = codigo;
        }


        public NoPilha(string codigo, NoPilha antes)
        {
            this.codigo = codigo;
            this.antes = antes;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        internal NoPilha Antes { get => antes; set => antes = value; }
    }
}
