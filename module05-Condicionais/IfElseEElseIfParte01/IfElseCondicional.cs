namespace CsharpFundamentos.Module05Condicionais.IfElseEElseIfParte01;

public class IfElseEElseIfParte01{

    enum Cores{
        Vermelho,
        Amarelo,
        Verde
    }


    public static void Exemplos(){
        
        int numero = -10;
        double saldo = 100.50;
        bool ativo = true;
        string author = "Thiago";
        List<int> lista = new List<int> {1, 3, 9};
        string? mensagemDeErro = null;
        // Cores cor = Cores.Amarelo;

        /*
            > Maior
            < Menor
            >= Maior ou igual
            <= Menor ou igual
            == Igual
            != Diferente
            is É
            is not NÃO É
        */
        if(numero > 0){
            Console.WriteLine("O número é positivo");
        }else{
            Console.WriteLine("O número é negativo");
        }

        if( saldo >= 100 ){
            Console.WriteLine($"Seu saldo é: {saldo}");
        }else if( saldo < 100 || saldo > 50){
            Console.WriteLine($"Saldo é: {saldo}");
        }else{
            Console.WriteLine(saldo);
        }

        if(ativo){
            Console.WriteLine($"O ativo é: {ativo}");
        }

        if(author.Equals("Jarv")){
            Console.WriteLine("Autor é Jarv");
        }else if(author.Contains("Thiago")){
            Console.WriteLine("Autor contém Thiago");
        }else{
            Console.WriteLine("Author nao encontrado");
        }

        if(lista[0] < 1){
            Console.WriteLine("O elemento da lista é menor que 1");
        }else if(lista[1] >= 3){
            Console.WriteLine("O elemento da lista é maior ou igual a 3");
        }else{
            Console.WriteLine("Algo deu errado!");
        }


        // o is representa o ==
        // o is not representa o !=
        if(mensagemDeErro is not null){
            Console.WriteLine("Sem erro aqui!");
        }else if(mensagemDeErro is null){
            Console.WriteLine("Foi encontrado um erro!");
        }
    }
}