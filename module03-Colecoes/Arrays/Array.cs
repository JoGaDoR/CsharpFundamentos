namespace CsharpFundamentos.Module03Colecoes.Arrays;

public class Arrays
{
    public static void ArrayCollection()
    {
        //é preciso passar o tamanho do array
        //array são coleções com tamanhos fixos
        // int[] inteiros = new int[5];
        // inteiros[0] = 1;
        // inteiros[1] = 20;
        // inteiros[2] = 400;

        // Console.WriteLine(inteiros.Length);
        // Console.WriteLine(inteiros[0]);
        // Console.WriteLine(inteiros[1]);
        // Console.WriteLine(inteiros[2]);

        int[] inteiros2 = [10, 200, 4000];

        Console.WriteLine(inteiros2.Length);
        Console.WriteLine(inteiros2[0]);
        Console.WriteLine(inteiros2[1]);
        Console.WriteLine(inteiros2[2]);
    }

    public static void ArrayCollectionMultidimensional()
    {
        //array multidimensional
        //é como se fosse um array com varias colunas.. a virgula no int[,,] determina quantas colunas serão
        int[,] inteiros = new int[3, 3];
        inteiros[0, 0] = 1;
        inteiros[0, 1] = 20;
        inteiros[0, 2] = 400;

        inteiros[1, 0] = 10;
        inteiros[1, 1] = 200;
        inteiros[1, 2] = 4000;

        Console.WriteLine(inteiros.Length);
        Console.WriteLine(inteiros[0, 0]);
        Console.WriteLine(inteiros[0, 1]);
        Console.WriteLine(inteiros[0, 2]);

        Console.WriteLine(inteiros[1, 0]);
        Console.WriteLine(inteiros[1, 1]);
        Console.WriteLine(inteiros[1, 2]);
    }
}