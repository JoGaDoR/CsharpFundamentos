namespace CsharpFundamentos.Module04FuncoesClassesVariaveisDebug.FuncoesDevolvendoValores;

public class FuncoesDevolvendoValores
{
    //declaar o tipo de retorno da função
    // public int Multiplicar(int valor1, int valor2)
    // {
    //     return valor1 * valor2;
    // }

    public int Multiplicar(int valor1, int valor2) => valor1 * valor2;

    //se for passar valores diferentes na função
    //a forma correta é nomear os valores do retorno (resultadoDaSoma, author)
    public (int resultadoDaSoma, string author) Somar(int valor1, int valor2)
    {
        var resultado = valor1 + valor2;

        return (resultado, "Thiago");
    }
}