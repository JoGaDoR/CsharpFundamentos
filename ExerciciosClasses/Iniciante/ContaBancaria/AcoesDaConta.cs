namespace CsharpFundamentos.ExerciciosClasses.Iniciante.ContaBancaria;

public class AcoesDaConta{

    public static void MinhaConta(){
        var conta = new ContaBancaria(1234, "Thiago Coelho");

        Console.WriteLine($"O saldo atual é: {conta.ObterSaldo()}");
        conta.Depositar(500);
        conta.Sacar(200);
        conta.ObterSaldo();

        Console.WriteLine($"Saldo atual: {conta.ObterSaldo()}");
    }
}