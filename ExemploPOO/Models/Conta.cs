using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta//CLASSES ABASTRATAS SÃO USADAS APENAS COMO MODELO NÃO PODEM SER INSTANCIADAS COMO OBJ;
    {
        protected double saldo;

        public abstract void Creditar(double valor);//MÉTODOS DE CLASSES ABSTRATAS SOMENTE SÃO HERDADAS E obrigatoriamente SOBRESCRITos

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {saldo}");
        }
    }
}
