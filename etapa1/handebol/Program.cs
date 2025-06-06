using System;
class Program {
    static void Main (string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int contador = 0;
        for (int i = 0; i < n; i++) {
            string[] entrada = Console.ReadLine().Split(' ');
            bool golsEmTodas = true;
            for (int j = 0; j < m; j++) {
                if (int.Parse(entrada[j]) == 0) {
                    golsEmTodas = false;
                    break;
                }
            }
            if (golsEmTodas) {
                contador++;
            }
        }
        Console.WriteLine(contador);
    }
}