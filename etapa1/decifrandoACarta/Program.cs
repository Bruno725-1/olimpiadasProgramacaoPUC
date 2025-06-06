using System;
class Program {
    static void Main (string[] args) {
        string input;
        while ((input = Console.ReadLine()) != null) {
            string[] entrada = input.Split(' ');
            string linha1 = Console.ReadLine();
            string linha2 = Console.ReadLine();
            int n = int.Parse(entrada[1]);
            for (int i = 0; i < n; i++) {
                string linha = Console.ReadLine();
                string decifrada = DecifrarString(linha1, linha2, linha);
                Console.WriteLine(decifrada);
            }
            Console.WriteLine();
        }
    }
    static string DecifrarString(string linha1, string linha2, string linha) {
        char[] vetor = linha.ToCharArray();
        for (int i = 0; i < vetor.Length; i++) {
            char c = vetor[i];
            char cMinusculo = char.ToLower(c);
            for (int j = 0; j < linha1.Length; j++) {
                if (cMinusculo == char.ToLower(linha1[j])) {
                    char substituto = linha2[j];
                    if (char.IsUpper(c)) {
                        substituto = char.ToUpper(substituto);
                    } else {
                        substituto = char.ToLower(substituto);
                    }
                    vetor[i] = substituto;
                } else if (cMinusculo == char.ToLower(linha2[j])) {
                    char substituto = linha1[j];
                    if (char.IsUpper(c)) {
                        substituto = char.ToUpper(substituto);
                    } else {
                        substituto = char.ToLower(substituto);
                    }
                    vetor[i] = substituto;
                }
            }
        }
        return new string(vetor);
    }
}