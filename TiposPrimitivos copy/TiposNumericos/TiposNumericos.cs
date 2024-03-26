using System;

namespace TiposPrimitivos.TiposNumericos
{
    public class Program
    {
        static void TiposNumericos()
        {

            //todos os tipos inteiros no site
            //https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types


            //numeros inteiros; positivos e negativos
            int numeroInteiro = 22;

            //numeros muito longos; positivos e negativos
            long numeroLongo = 2147483648;

            //numeros sem sinais, ou seja, numero positivo
            uint numeroUint = 10;

            //numeros flutuantes
            double numeroDouble = 3.14;
            float numeroFloat = 4.16F;
            decimal numeroDecimal = 6.78M;

            Console.WriteLine(numeroInteiro);
            Console.WriteLine(numeroLongo);
            Console.WriteLine(numeroUint);
            Console.WriteLine(numeroDouble);
            Console.WriteLine(numeroFloat);
            Console.WriteLine(numeroDecimal);
        }
    }
}
