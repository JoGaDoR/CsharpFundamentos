namespace FuncoesVariaveisDebug.FuncoesComParametros;

public class FuncoesComParametros
{
    //receber dois valores
    public void Adicionar(int valor1, int valor2)
    {
        var resultado = valor1 + valor2;

        Console.WriteLine($"A soma de {valor1} + {valor2} = {resultado}");
    }
}