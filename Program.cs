using TiposPrimitivos.DatasEHoras;
using TiposPrimitivos.OperacoesComTexto;
using TiposPrimitivos.TiposBoleanos;
using TiposPrimitivos.TiposNumericos;
using TiposPrimitivos.TiposTexto;
using Colecoes.Arrays;
using Colecoes.Listas;
using Colecoes.Dicionarios;
using FuncoesVariaveisDebug.FuncoesComParametros;
using FuncoesVariaveisDebug.FuncoesDevolvendoValores;
using FuncoesVariaveisDebug.FuncoesComValorPadraoDeParametros;


namespace Program;

class Program
{
    static void Main(string[] args)
    {
        // Dicionarios.DictionaryCollection();
        // Listas.JoinElementsList();
        // Listas.ListCollection();
        // Arrays.ArrayCollectionMultidimensional();
        // Arrays.ArrayCollection();
        // DatasEHoras.DateAndTime();
        // OperacoesComTexto.OperationWithText();
        // TiposBoleanos.BooleanTypes();
        // TiposNumericos.NumericTypes();
        // TiposTexto.TextTypes();


        // var calcFuncoesComParametros = new FuncoesComParametros();
        // calcFuncoesComParametros.Adicionar(10, 20);

        // //agora um exemplo de função com parametro nomeado
        // //é a forma recomendada de se passar um parametro

        // var calcFuncoesComParametrosNomeados = new FuncoesComParametros();
        // calcFuncoesComParametrosNomeados.Subtrair(valor1: 10, valor2: 20); //parametro nomeado

        // var calcFuncoesDevolvendoValores = new FuncoesDevolvendoValores();
        // var resultado = calcFuncoesDevolvendoValores.Multiplicar(10, 20);
        // Console.WriteLine($"A multiplicação de 10 * 20 = {resultado}");



        // //aqui a função irá retornar 2 valores de tipos diferentes
        // var calcFuncaoRetornaDoisValoresDiferentes = new FuncoesDevolvendoValores();
        // var resultado = calcFuncaoRetornaDoisValoresDiferentes.Somar(2024, 03);
        // Console.WriteLine(resultado);

        // //acessando os valores do retorno na ordem que foram declarados
        // //no exemplo foi int e string
        // Console.WriteLine($"Resultado do primeiro item: {resultado.Item1}");
        // Console.WriteLine($"Resultado do segundo item: {resultado.Item2}");

        // //forma correta de acessar os valores do retorno
        // Console.WriteLine(resultado.resultadoDaSoma);
        // Console.WriteLine(resultado.author);

        // //outra forma de acessar os valores diferentes
        // var segundaForma = new FuncoesDevolvendoValores();
        // (int resultadoDaSoma, string author) = segundaForma.Somar(22, 58);
        // Console.WriteLine(resultadoDaSoma);
        // Console.WriteLine(author);

        //funcao que foi definido default para o valor2
        var funcaoComValorPadrao = new FuncoesComValorPadraoDeParametros();
        funcaoComValorPadrao.ValorPadraoDoParametro(valor1: 201); //valor2 ja tem um value default
    }
}

