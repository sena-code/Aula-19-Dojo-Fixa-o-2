using System;

namespace Aula18Dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVip bilhete = new IngressoVip();

            bilhete.Valor = 20.5f;
            bilhete.ValorAdicional = 27.8f;
            bilhete.ImprimirValor();
            bilhete.ImprimirValorAdicional();
            Console.WriteLine($"A diferença de valor entre os dois Ingressos é de {bilhete.ValorAdicional}");
        }
    }
}
