namespace TiposPrimitivos.OperacoesComTexto;

public class OperacoesComTexto

{
    public static void OperationWithText()
    {
        string nome = "Thiago";
        string sobrenome = "Coelho";

        //concatenação
        string nomeCompleto = nome + " " + sobrenome;

        string nomeCompleto2 = $"{nome} {sobrenome}";

        Console.WriteLine(nomeCompleto);
        Console.WriteLine(nomeCompleto2);

        string texto = "O usuario {0} tem {1} anos.";

        string resultado = string.Format(texto, nome, 22);
        Console.WriteLine(resultado);
    }
}