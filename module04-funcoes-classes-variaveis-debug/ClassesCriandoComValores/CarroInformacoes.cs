namespace CsharpFundamentos.Module04FuncoesClassesVariaveisDebug.ClassesCriandoComValores;

public class CarroInformacoes
{

    public static void Acessar()
    {

        // var carro = new Carro();

        // carro.Modelo = "Lamborghini";
        // carro.LancadoEm = new DateOnly(2023, 01, 21);
        // carro.Cor = Cor.VERMELHO;

        var carro = new Carro()
        {
            Modelo = "Lamborghini",
            LancadoEm = new DateOnly(2023, 01, 21),
            Cor = Cor.AMARELO
        };

        carro.NomeDoModelo();


        //tornar a propriedade obrigatoria
        //EXEMPLO 01

        var carroExemplo01 = new CarroInformacaoObrigatoria01
        {
            Cor = Cor.VERMELHO,
            LancadoEm = new DateOnly(2021, 10, 21),
            Modelo = "Ferrari"
        };

        carroExemplo01.CorDoCarro();


        //tornar a propriedade obrigatoria
        //EXEMPLO 02

        var carroExemplo02 = new CarroInformacaoObrigatoria02("Aston Martin", new DateOnly(2023, 03, 18), Cor.AZUL);

        carroExemplo02.DataDeLancamento();


    }
}