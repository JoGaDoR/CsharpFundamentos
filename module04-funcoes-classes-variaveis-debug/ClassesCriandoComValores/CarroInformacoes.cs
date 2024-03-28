namespace CsharpFundamentos.Module04FuncoesClassesVariaveisDebug.ClassesCriandoComValores;

public class CarroInformacoes{

    public static void Acessar(){

        // var carro = new Carro();

        // carro.Modelo = "Lamborghini";
        // carro.LancadoEm = new DateOnly(2023, 01, 21);
        // carro.Cor = Cor.VERMELHO;

        var carro = new Carro(){
            Modelo = "Lamborghini",
            LancadoEm = new DateOnly(2023, 01, 21),
            Cor = Cor.VERMELHO
        };

        carro.NomeDoModelo();
    }
}