using System;
class Program {
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] linha = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            string palavra = linha[i];
            if (palavra.Length == 3)
            {
                char[] vetor = palavra.ToCharArray();
                if ((vetor[0] == 'O' && vetor[1] == 'B') || (vetor[0] == 'U' && vetor[1] == 'R'))
                {
                    vetor[2] = 'I';
                    palavra = new string(vetor);
                }
            }
            linha[i] = palavra;
        }
        Console.WriteLine(string.Join(" ", linha));
    }
}