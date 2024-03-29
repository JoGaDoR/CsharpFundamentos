namespace CsharpFundamentos.Module05Condicionais.Ternario
{
    public class Ternario{
        public static void CondicionalTernario(){
            int numero = 10;
            int numero2 = 21;

            int soma = numero + numero2;
            int subtrair = numero - numero2;

            //exemplo de condicional ternario
            string resultado = soma > 10 ? "Maior" : "Menor";
            Console.WriteLine(resultado);

            string resultado2 = subtrair > 20 ? "Maior" : "Menor";
            Console.WriteLine(resultado2);
            
        }
    }
}