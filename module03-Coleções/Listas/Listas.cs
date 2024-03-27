namespace Colecoes.Listas;

public class Listas
{
    public static void ListCollection()
    {
        List<int> inteiros = new List<int>();

        //Add() para adicionar um elemento/valor e nao um indice
        inteiros.Add(1);
        inteiros.Add(2);
        inteiros.Add(3);
        inteiros.Add(4);
        inteiros.Add(5);

        //Remove() para remover um elemento/valor e nao um indice
        inteiros.Remove(1);

        //Count para saber quantos elementos tem na lista
        Console.WriteLine($"Quantidade de elementos: {inteiros.Count}");
        Console.WriteLine($"Elemento na posição 0: {inteiros[0]}");

        foreach (int i in inteiros)
        {
            Console.WriteLine($"valor {i}");
        }

        //First() para ver o primeiro elemento da lista
        int primeiroElemento = inteiros.First();
        //Last() para ver o last elemento da lista
        int ultimoElemento = inteiros.Last();

        Console.WriteLine($"Primeiro elemento: {primeiroElemento}");
        Console.WriteLine($"Ultimo elemento: {ultimoElemento}");

        //ElementAt() escolher qual posição deseja ver o elemento/valor
        int posicaoList = 2;
        int escolherPosicaoDoElemento = inteiros.ElementAt(posicaoList);
        Console.WriteLine($"Elemento na posicao {posicaoList}: valor = {escolherPosicaoDoElemento}");

        //RemoveAt() remove um elemento da lista na posição escolhida
        inteiros.RemoveAt(posicaoList);

        Console.WriteLine($"Quantidade de elementos: {inteiros.Count}");

        //Clear() para remover todos os elementos/valores da lista
        inteiros.Clear();

        Console.WriteLine($"Quantidade de elementos: {inteiros.Count}");
        
    }
}