namespace FuncoesVariaveisDebug.FuncoesComValorPadraoDeParametros;

public class FuncoesComValorPadraoDeParametros
{
    //definir um value default para um parametro
    //value default nao pode ser atribuido ao primeiro parametro! apenas do segundo em diante
    //caso declare um parametro como default, todos os demais paramentros terão que possuir um value default
    public void ValorPadraoDoParametro(int valor1, int valor2 = 0, string valor3 = "value default")
    {
        Console.WriteLine(valor1 + valor2 + valor3);
    }
}