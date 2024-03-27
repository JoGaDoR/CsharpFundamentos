namespace Colecoes.Dicionarios;

public class Dicionarios
{
    public static void DictionaryCollection()
    {
        //dicionário é uma coleção de chave e valor
        //sempre vai ter uma chave atribuida a algum valor
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        dicionario.Add(1, "Thiago");
        dicionario.Add(22, "Arruda");
        dicionario.Add(36, "Coelho");

        Console.WriteLine(dicionario[1]);
        Console.WriteLine(dicionario[22]);
        Console.WriteLine(dicionario[36]);

        Console.WriteLine(dicionario.ContainsKey(22));
        Console.WriteLine(dicionario.ContainsValue("Trutina"));
        Console.WriteLine(dicionario.ContainsValue("Thiago"));
}
}