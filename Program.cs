using TiposPrimitivos.DatasEHoras;
using TiposPrimitivos.OperacoesComTexto;
using TiposPrimitivos.TiposBoleanos;
using TiposPrimitivos.TiposNumericos;
using TiposPrimitivos.TiposTexto;
using Colecoes.Arrays;
using Colecoes.Listas;
using Colecoes.Dicionarios;
using FuncoesVariaveisDebug.FuncoesComParametros;


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


        var calcFuncoesComParametros = new FuncoesComParametros();
        calcFuncoesComParametros.Adicionar(10, 20);

        //agora um exemplo de função com parametro nomeado
        //é a forma recomendada de se passar um parametro

        var calcFuncoesComParametrosNomeados = new FuncoesComParametros();
        calcFuncoesComParametrosNomeados.Subtrair(valor1: 10, valor2: 20); //parametro nomeado
    }
}

