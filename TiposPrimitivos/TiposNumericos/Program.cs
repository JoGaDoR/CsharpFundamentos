using System;

namespace TiposPrimitivos.TiposNumericos
{
    class Program
    {
        static void Main()
        {

            //todos os tipos inteiros no site
            //https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types


            //numeros inteiros; positivos e negativos
            int numeroInteiro = 22;

            //numeros muito longos; positivos e negativos
            long numeroLongo = 2147483648;

            //numeros sem sinais, ou seja, numero positivo
            uint numeroUint = 10;

            Console.WriteLine(numeroInteiro);
            Console.WriteLine(numeroLongo);
            Console.WriteLine(numeroUint);
        }
    }
}
