using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oiMundo.Models
{
    class Conta
    {   
        //atributos da conta
        public int numero;
        public string titular;
        // inicializo todas as contas com o valor de R$ 100.0
        public double saldo = 100.0;


        //métodos
        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;

                return true;
            }
            return false;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }
    }
}
