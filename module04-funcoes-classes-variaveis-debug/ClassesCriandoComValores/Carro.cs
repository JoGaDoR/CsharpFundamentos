namespace CsharpFundamentos.Module04FuncoesClassesVariaveisDebug.ClassesCriandoComValores;

public class Carro{
    public string? Modelo {get; set;}
    public DateOnly LancadoEm {get; set;}

    public Cor Cor {get; set;}

    public void NomeDoModelo() => Console.WriteLine(Modelo);
    
}

public class CarroInformacaoObrigatoria01{

    // com o required a propriedade é obrigatória e deve ser informada para evitar erros
    public required string? Modelo {get; set;}
    public required DateOnly LancadoEm {get; set;}
    public required Cor Cor {get; set;}

    public void CorDoCarro() => Console.WriteLine(Cor);

}

public class CarroInformacaoObrigatoria02{
    
    public string? Modelo {get; set;}
    public DateOnly LancadoEm {get; set;}

    public Cor Cor {get; set;}

    public CarroInformacaoObrigatoria02(string modelo, DateOnly lancadoEm, Cor cor){
        Modelo = modelo;
        LancadoEm = lancadoEm;
        Cor = cor;
    }
    public void DataDeLancamento () => Console.WriteLine(LancadoEm);
}