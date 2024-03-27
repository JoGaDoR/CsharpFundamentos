namespace Colecoes.HashSet;

public class HashSet
{
    public static void HashSetCollection()
    {
        //HashSet é uma coleção de valores unicos
        //nao vai aceitar inserir valores duplicados

        HashSet<int> set = new HashSet<int>();

        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(1);

        Console.WriteLine(set.Count());

    }
}