using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            string a = vetor[0], b = vetor[1];
            char[] alternado = new char[a.Length + b.Length + 1];
            Console.WriteLine(alternado.Length);
            for (int j = 0; j < alternado.Length; j++)
            {
                alternado[j] = a[j];
                alternado[j + 1] = b[j];
            }
            Console.WriteLine(new string(alternado));
        }
    }
}
