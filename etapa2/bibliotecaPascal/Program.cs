using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int n = int.Parse(entrada[0]);
            int d = int.Parse(entrada[1]);
            if (n == 0 && d == 0)
                break;
            bool[] vetor = new bool[n];
            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                bool participaDeTodos = true;
                for (int j = 0; j < d; j++)
                {
                    if (int.Parse(linha[j]) == 0)
                    {
                        participaDeTodos = false;
                        break;
                    }
                }
                vetor[i] = participaDeTodos;
            }
            if (AlguemParticipaDeTodos(vetor))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
    static bool AlguemParticipaDeTodos(bool[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (!vetor[i])
                return false;
        }
        return true;
    }
}