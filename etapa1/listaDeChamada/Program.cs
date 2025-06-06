using System;
class Program {
    static void Main (string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        string[] nomes = new string[n];
        for (int i = 0; i < n; i++) {
            nomes[i] = Console.ReadLine();
        }
        OrganizarNomes(nomes);
        Console.WriteLine($"{nomes[k - 1]}");
    }
    static void OrganizarNomes (string[] nomes) {
        for (int i = 0; i < nomes.Length; i++) {
            for (int j = 0; j < nomes.Length - i - 1; j++) {
                if (string.Compare(nomes[j], nomes[j + 1]) > 0) {
                    string temp = nomes[j];
                    nomes[j] = nomes[j + 1];
                    nomes[j + 1] = temp;
                }
            }
        }
    }
}