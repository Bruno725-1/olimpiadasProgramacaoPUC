using System;
using System.Collections.Generic;
class Program {
    static void Main(string[] args)
    {
        string linha = Console.ReadLine();
        List<char> vogais = new List<char>();
        foreach (char letra in linha)
        {
            if ("aeiou".Contains(letra.ToString()))
                vogais.Add(letra);
        }
        char[] vetor = new char[vogais.Count];
        int j = 0;
        for (int i = vogais.Count - 1; i >= 0; i--)
        {
            vetor[j] = vogais[i];
            j++;
        }
        string original = new string(vogais.ToArray());
        string invertida = new string(vetor);
        if (original == invertida)
            Console.WriteLine("S");
        else
            Console.WriteLine("N");
    }
}