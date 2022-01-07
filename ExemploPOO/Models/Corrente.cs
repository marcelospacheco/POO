using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    class Corrente : Conta
    {
        public override void Creditar(double valor)//override sobrescreve um método da classes herdada
        {
            base.saldo = valor;//utilizar base ao invés do this, dizendo que essa propriedade pertence a classe pai Conta
        }
    }
}
