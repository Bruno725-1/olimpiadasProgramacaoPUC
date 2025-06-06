using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        string[] linha = Console.ReadLine().Split(' ');
        for (int i = 0; i < vetor.Length; i++)
            vetor[i] = int.Parse(linha[i]);
        PercorrerVetor(vetor);
    }
    static void PercorrerVetor(int[] vetor)
    {
        int pos = 0, menor = 1001;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
                pos = i;
            }
        }
        Console.WriteLine("Menor valor: " + menor);
        Console.WriteLine("Posicao: " + pos);
    }
}