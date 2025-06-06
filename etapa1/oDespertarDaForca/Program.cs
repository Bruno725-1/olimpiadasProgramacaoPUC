using System;
class Program {
    static void Main (string[] args) {
        string[] entrada = Console.ReadLine().Split(' ');
        int n = int.Parse(entrada[0]);
        int m = int.Parse(entrada[1]);
        int[,] terreno = new int[n, m];
        for (int i = 0; i < n; i++) {
            string[] linha = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
                terreno[i, j] = int.Parse(linha[j]);
        }
        for (int i = 1; i < n - 1; i++) {
            for (int j = 1; j < m - 1; j++) {
                if (terreno[i, j] == 42) {
                    if (terreno[i-1,j-1] == 7 && terreno[i-1,j] == 7 && terreno[i-1,j+1] == 7 &&
                    terreno[i,j-1] == 7                 && terreno[i,j+1] == 7 &&
                    terreno[i+1,j-1] == 7 && terreno[i+1,j] == 7 && terreno[i+1,j+1] == 7) {
                        Console.WriteLine($"{i + 1} {j + 1}");
                        return;
                    }
                }
            }
        }
        Console.WriteLine("0 0");
    }
}