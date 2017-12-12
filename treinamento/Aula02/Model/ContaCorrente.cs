using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Model
{
    public class ContaCorrente : Conta
    {
        public override void Movimentar()
        {
            throw new NotImplementedException();
        }

        public ContaCorrente(int agencia, int conta)
        {
            this.Agencia = agencia;
            this.Numero = conta;
        }
    }
}
