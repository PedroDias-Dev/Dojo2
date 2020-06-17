using System;

namespace Dojo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP ingresso = new IngressoVIP();
            ingresso.valor = 12f;
            ingresso.valorAdicional = 10f;
            

            ingresso.ImprimirValor();
            ingresso.ImprimirValorVIP();

        }
    }
}
