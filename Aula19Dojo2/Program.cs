using System;

namespace Aula19Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP bilhete = new IngressoVIP();
            bilhete.Valor=10f;
            bilhete.ValorAdicional=10.5f;
            bilhete.ImprimirValor();
            bilhete.ValorVip();


           // System.Console.WriteLine($"Valor do ingresso adicional é R$ {bilhete.ValorAdicional}");

        }
    }
}
